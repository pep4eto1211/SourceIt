using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;
using System.Net;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Media.Effects;
using System.IO.Compression;

namespace SourceIt
{
    /// <summary>
    /// The help finder service
    /// </summary>
    public partial class helpFinder : Page
    {
        public helpFinder(string currentUser)
        {
            InitializeComponent();
            username = currentUser;
        }

        private string username = "";

        //Go back to the startup page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartupPage(username));
        }

        BackgroundWorker tabLoadWork = new BackgroundWorker();

        //Unselect all tabs
        private void normalizeButtons()
        {
            allTabLabel.FontSize = 18;
            mineTabLabel.FontSize = 18;
        }

        //Set some tab to selected
        private void changeTab(Button currentTab, Label currentLabel)
        {
            normalizeButtons();
            currentLabel.FontSize = 20;
        }

        //Start the background worker,which loads the data in the current tab
        private void changeTabInit()
        {
            itemsStackPanel.Children.Clear();
            currentQuestions.Clear();
            loader.Visibility = System.Windows.Visibility.Visible;
            tabLoadWork.DoWork += tabLoadWork_DoWork;
            tabLoadWork.RunWorkerCompleted += tabLoadWork_RunWorkerCompleted;
            tabLoadWork.RunWorkerAsync();
        }

        BackgroundWorker loadAnswersWork = new BackgroundWorker();
        string currentOpenQuestion = "";

        //Populate the stack panel with the returned data
        void tabLoadWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            itemsStackPanel.Children.Clear();
            foreach (var singleQuestion in currentQuestions)
            {
                theQuestion newQuestion = new theQuestion(singleQuestion);
                newQuestion.openAnswers += (object senderr, EventArgs ee) =>
                {
                    currentOpenQuestion = singleQuestion.id;
                    loader.Visibility = System.Windows.Visibility.Visible;
                    questionContent.Text = singleQuestion.content;
                    loadAnswersWork.DoWork += loadAnswersWork_DoWork;
                    loadAnswersWork.RunWorkerCompleted += loadAnswersWork_RunWorkerCompleted;
                    loadAnswersWork.RunWorkerAsync();
                };
                itemsStackPanel.Children.Add(newQuestion);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        //Show the answers to the current question
        void loadAnswersWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            answersStackPanel.Children.Clear();
            answersStackPanel.Children.Add(answersLabelGrid);
            foreach (var item in currentAnswers)
            {
                singleAnswer answer = new singleAnswer(item);
                answersStackPanel.Children.Add(answer);
            }
            openQuestionGrid.Visibility = System.Windows.Visibility.Visible;
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        List<answer> currentAnswers = new List<answer>();

        //Load the answers to the current question
        void loadAnswersWork_DoWork(object sender, DoWorkEventArgs e)
        {
            currentAnswers.Clear();
            NameValueCollection idValue = new NameValueCollection();
            idValue["id"] = currentOpenQuestion;
            WebClient client = new WebClient();
            byte[] response = client.UploadValues(mainServerUrl + "getAnswers.php", "POST", idValue);
            string raw = Encoding.UTF8.GetString(response);
            string[] allIds;
            if (raw.Length > 0)
            {
                raw = raw.Remove(raw.Length - 1);
            }
            allIds = raw.Split(',');
            foreach (string item in allIds)
            {
                answer ans = new answer(item);
                ans.answerInit();
                currentAnswers.Add(ans);
            }
            if (raw == "")
            {
                currentAnswers.RemoveAt(0);
            }
        }

        private string mainServerUrl = "";

        List<question> currentQuestions = new List<question>();

        //Load the data needed to populate the stack panel
        void tabLoadWork_DoWork(object sender, DoWorkEventArgs e)
        {
            currentQuestions.Clear();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string requestUrl = "";
            WebClient client = new WebClient();
            NameValueCollection userValue = new NameValueCollection();
            userValue["user"] = username;

            switch (currentTab)
            {
                case 1:
                    requestUrl = mainServerUrl + "allQuestions.php";
                    break;
                case 2:
                    requestUrl = mainServerUrl + "mineQuestions.php";
                    break;
            }

            byte[] response = client.UploadValues(requestUrl, "POST", userValue);
            string raw = Encoding.UTF8.GetString(response);
            string[] rawArray;
            if (raw.Length > 0)
            {
                raw = raw.Remove(raw.Length - 1);
            }
            rawArray = raw.Split(',');
            foreach (var singleId in rawArray)
            {
                question item = new question(singleId);
                item.questionInit();
                currentQuestions.Add(item);
            } 
            if (rawArray.Length == 0)
            {
                currentQuestions.RemoveAt(0);
            }
        }

        private int currentTab = 1;

        //Select the first tab and load it
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            changeTab(allTab, allTabLabel);
            changeTabInit();
        }

        //Change tab
        private void mineTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(mineTab, mineTabLabel);
            currentTab = 2;
            changeTabInit();
        }

        //Change tab
        private void allTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(allTab, allTabLabel);
            currentTab = 1;
            changeTabInit();
        }

        //Open the add question window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addQuestionWindow quest = new addQuestionWindow(username, "");
            bool? result = quest.ShowDialog();
            if (result == true)
            {
                changeTabInit();
            }
        }

        //Close the answers for the current question
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            openQuestionGrid.Visibility = System.Windows.Visibility.Hidden;
        }

        //Open the add answer window
        private void addAnswerButtonClick(object sender, RoutedEventArgs e)
        {
            addAnswerWindow ans = new addAnswerWindow(username, currentOpenQuestion);
            bool? result = ans.ShowDialog();
            if (result == true)
            {
                loader.Visibility = System.Windows.Visibility.Visible;
                loadAnswersWork.DoWork += loadAnswersWork_DoWork;
                loadAnswersWork.RunWorkerCompleted += loadAnswersWork_RunWorkerCompleted;
                loadAnswersWork.RunWorkerAsync();
            }
        }
    }
}
