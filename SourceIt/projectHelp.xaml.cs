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
using System.Windows.Media.Animation;

namespace SourceIt
{
    /// <summary>
    /// Page for showing all questions, releted to the current project
    /// </summary>
    public partial class projectHelp : Page
    {
        public projectHelp(string theProjectName)
        {
            InitializeComponent();
            currentProject = theProjectName;
        }

        string currentProject = "";
        private string username = "";

        BackgroundWorker initialWork = new BackgroundWorker();
        BackgroundWorker loadAnswersWork = new BackgroundWorker();

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            initialWork.DoWork += initialWork_DoWork;
            initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            initialWork.RunWorkerAsync();
        }

        private string currentOpenQuestion = "";

        //Show all the questions
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            allPostsPanel.Children.Clear();
            allPostsPanel.Children.Add(questionsLabelGrid);
            foreach (var singleQuestion in all)
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
                allPostsPanel.Children.Add(newQuestion);
            }
            if (all.Count == 0)
            {
                allPostsPanel.Children.Add(emptyLabel);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }
        //Show the answers for the current question
        private void loadAnswersWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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

        private List<answer> currentAnswers = new List<answer>();

        //Load the answers for he current question
        private void loadAnswersWork_DoWork(object sender, DoWorkEventArgs e)
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
        List<question> all = new List<question>();

        //Load all the questions
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            all.Clear();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            StreamReader usernameReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = usernameReader.ReadToEnd();
            reader.Close();
            string requestUrl = "";
            WebClient client = new WebClient();
            NameValueCollection userValue = new NameValueCollection();
            userValue["project"] = currentProject;
            requestUrl = mainServerUrl + "getProjectHelp.php";
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
                all.Add(item);
            }
            if (raw.Length == 0)
            {
                all.RemoveAt(0);
            }
        }

        //Hide the grid with the answers
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openQuestionGrid.Visibility = System.Windows.Visibility.Hidden;
        }

        //Open the add answer button
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

        //Open the add question window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addQuestionWindow quest = new addQuestionWindow(username, currentProject);
            bool? result = quest.ShowDialog();
            if (result == true)
            {
                NavigationService.Navigate(new projectHelp(currentProject));
            }
        }
    }
}
