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
    /// Single project page
    /// </summary>
    public partial class projectPage : Page
    {
        public projectPage(string projectName)
        {
            InitializeComponent();
            currentProjectName = projectName;
        }

        BackgroundWorker loadingWorker = new BackgroundWorker();

        public string currentProjectName = "";

        public string mainServerUrl = "";

        public string username = "";

        //Get the current user and start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = reader.ReadToEnd();
            reader.Close();
            loadingWorker.DoWork += loadingWorker_DoWork;
            loadingWorker.RunWorkerCompleted += loadingWorker_RunWorkerCompleted;
            loadingWorker.RunWorkerAsync();
        }

        //Show the deadline, set the first tab to selected and populate the settings menu
        void loadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thickness border = new Thickness(1, 0, 1, 0);
            dashboardTab.BorderThickness = border;
            dashboardTabLabel.FontSize = 20;
            projectNameBlock.Text = currentProjectName;
            descriptionBlock.Text = description;
            if (deadline != "0")
            {
                deadlineLabel.Visibility = System.Windows.Visibility.Visible;
                deadlineBox.Text = deadline;
                string[] dateTimeArray = deadline.Split('.');
                DateTime deadlineDateTime = new DateTime(int.Parse(dateTimeArray[2]), int.Parse(dateTimeArray[1]), int.Parse(dateTimeArray[0]));
                DateTime now = new DateTime();
                now = DateTime.Now;
                TimeSpan timeLeft = new TimeSpan();
                timeLeft = deadlineDateTime - now;
                if (timeLeft.Days>0)
                {
                    timeLeftBox.Text = "След " + timeLeft.Days + " дни";
                    timeLeftBox.ToolTip = "След " + timeLeft.Days + " дни";
                }
                else
                {
                    timeLeftBox.Text = "Преди " + Math.Abs(timeLeft.Days) + " дни";
                    timeLeftBox.ToolTip = "Преди " + Math.Abs(timeLeft.Days) + " дни";
                }
            }
            else
            {
                deadlineBox.Text = "Не е зададен";
            }
            Loader.Visibility = System.Windows.Visibility.Hidden;
            if (isOwner)
            {
                deleteProjectButton.Visibility = System.Windows.Visibility.Visible;
                editInfoButton.Visibility = System.Windows.Visibility.Visible;
                setDeadlineButton.Visibility = System.Windows.Visibility.Visible;
            }
            mainSubFrame.Navigate(new projectDashboard(currentProjectName));
        }

        public string description = "";
        public bool isOwner = false;
        public string deadline = "";

        //Get the project owner, description and deadline
        void loadingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"serverAddress.sid");
                mainServerUrl = reader.ReadToEnd();
                reader.Close();
                WebClient webClient = new WebClient();
                string descriptionUrl = mainServerUrl + "getProjectDescription.php";
                NameValueCollection projectNameValues = new NameValueCollection();
                projectNameValues["project"] = currentProjectName;
                byte[] responseBytes = webClient.UploadValues(descriptionUrl, "POST", projectNameValues);
                description = Encoding.UTF8.GetString(responseBytes);
                string checkOwnerUrl = mainServerUrl + "checkOwner.php";
                NameValueCollection checkOwnerVAlues = new NameValueCollection();
                checkOwnerVAlues["project"] = currentProjectName;
                checkOwnerVAlues["user"] = username;
                byte[] ownerResponseBytes = webClient.UploadValues(checkOwnerUrl, "POST", checkOwnerVAlues);
                string ownerResponse = Encoding.UTF8.GetString(ownerResponseBytes);
                if (ownerResponse == "ok")
                {
                    isOwner = true;
                }
                else
                {
                    isOwner = false;
                }
                string getDeadlineUrl = mainServerUrl + "getDeadline.php";
                NameValueCollection getDeadlineValues = new NameValueCollection();
                getDeadlineValues["project"] = currentProjectName;
                byte[] getDeadlineResponse = webClient.UploadValues(getDeadlineUrl, "POST", getDeadlineValues);
                deadline = Encoding.UTF8.GetString(getDeadlineResponse);
            }
            catch(Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
            }
        }

        //Open the project settings
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation fadeIn = new DoubleAnimation();
            fadeIn.From = 0;
            fadeIn.To = 1;
            fadeIn.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            projectSettingsPanel.Visibility = System.Windows.Visibility.Visible;
            projectSettingsPanel.BeginAnimation(StackPanel.OpacityProperty, fadeIn);
        }

        //Close the project settings
        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation fadeIn = new DoubleAnimation();
            fadeIn.From = 1;
            fadeIn.To = 0;
            fadeIn.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            fadeIn.Completed += (object senderr, EventArgs ee) =>
            {
                projectSettingsPanel.Visibility = System.Windows.Visibility.Hidden;
            };
            projectSettingsPanel.BeginAnimation(StackPanel.OpacityProperty, fadeIn);
        }

        public event EventHandler projectDeleted;
        public event EventHandler modalDialogShowed;
        public event EventHandler modalDialogHidden;

        //Fire events
        private void projectDeletedEvent(EventArgs e)
        {
            projectDeleted(this, e);
        }

        private void modalDialogShowedEvent(EventArgs e)
        {
            modalDialogShowed(this, e);
        }

        private void modalDialogHiddenEvent(EventArgs e)
        {
            modalDialogHidden(this, e);
        }

        //Delete current project
        private void deleteProjectButton_Click(object sender, RoutedEventArgs e)
        {
            projectSettingsPanel.Visibility = System.Windows.Visibility.Hidden;
            confirmWindow confirmDelete = new confirmWindow("Сигурни ли сте, че искате да изтриете този проект?");
            modalDialogShowedEvent(e);
            DoubleAnimation dialogAnimation = new DoubleAnimation();
            dialogAnimation.From = 0;
            dialogAnimation.To = 1;
            dialogAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            confirmDelete.BeginAnimation(Window.OpacityProperty, dialogAnimation);
            if (confirmDelete.ShowDialog() == true)
            {
                modalDialogHiddenEvent(e);
                WebClient webClent = new WebClient();
                string deleteServerUrl = mainServerUrl + "deleteProject.php";
                NameValueCollection deleteProjectValies = new NameValueCollection();
                deleteProjectValies["project"] = currentProjectName;
                deleteProjectValies["user"] = username;
                byte[] deleteProjectResponse = webClent.UploadValues(deleteServerUrl, "POST", deleteProjectValies);
                string serverResponse = Encoding.UTF8.GetString(deleteProjectResponse);
                if (serverResponse == "ok")
                {
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    folderPath += @"\SourceIt";
                    string projectsFolderPath = folderPath + @"\Projects";
                    File.Delete(projectsFolderPath + @"\" + currentProjectName + ".sid");
                    projectDeletedEvent(e);
                    NavigationService.Navigate(new StartupPage(username));
                }
                else
                {

                }
            }
            else
            {
                modalDialogHiddenEvent(e);
            }
        }

        //Open the project info for editing
        private void editInfoButton_Click(object sender, RoutedEventArgs e)
        {
            mainSubFrame.Navigate(new projectSettings(currentProjectName));
            projectSettingsPanel.Visibility = System.Windows.Visibility.Hidden;
        }

        //Open the set deadline page
        private void setDeadlineButton_Click(object sender, RoutedEventArgs e)
        {
            setDeadlinePage deadlinePage = new setDeadlinePage(currentProjectName);
            deadlinePage.deadlineChanged += deadlinePage_deadlineChanged;
            mainSubFrame.Navigate(deadlinePage);
            projectSettingsPanel.Visibility = System.Windows.Visibility.Hidden;
        }

        //Reload the project page
        void deadlinePage_deadlineChanged(object sender, EventArgs e)
        {
            NavigationService.Navigate(new projectPage(currentProjectName));
        }

        //Go back to startup page
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartupPage(username));
        }

        //Open the files operations wondow
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                modalDialogShowedEvent(e);
                filesOperations files = new filesOperations(currentProjectName);
                files.ShowDialog();
                modalDialogHiddenEvent(e);
            }
            catch (Exception error)
            {
                errorWindow err = new errorWindow("Настъпи неочаквана грешка.");
                errorReporter.reportError(error, "projectPage.cs", mainServerUrl);
                err.ShowDialog();
                Application.Current.Shutdown();
            }
        }

        //This is now available in the files operations window
        private void viewProjectFilesButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(mainServerUrl + "Projects/" + currentProjectName + "/");
        }

        //Unselect all tabs
        private void normalizeButtons()
        {
            Thickness border = new Thickness(0, 0, 0, 0);
            teamTab.BorderThickness = border;
            storeTab.BorderThickness = border;
            dashboardTab.BorderThickness = border;
            helpTab.BorderThickness = border;
            teamTabLabel.FontSize = 18;
            dashboardTabLabel.FontSize = 18;
            storeTabLabel.FontSize = 18;
            helpTabLabel.FontSize = 18;
        }

        //Select tabs
        private void teamTab_Click(object sender, RoutedEventArgs e)
        {
            normalizeButtons();
            Thickness border = new Thickness(1, 0, 1, 0);
            teamTab.BorderThickness = border;
            teamTabLabel.FontSize = 20;
            mainSubFrame.Navigate(new teamView(currentProjectName));
        }

        private void dashboardTab_Click(object sender, RoutedEventArgs e)
        {
            normalizeButtons();
            Thickness border = new Thickness(1, 0, 1, 0);
            dashboardTab.BorderThickness = border;
            dashboardTabLabel.FontSize = 20;
            mainSubFrame.Navigate(new projectDashboard(currentProjectName));
        }

        private void helpTab_Click(object sender, RoutedEventArgs e)
        {
            normalizeButtons();
            Thickness border = new Thickness(1, 0, 1, 0);
            helpTab.BorderThickness = border;
            helpTabLabel.FontSize = 20;
            mainSubFrame.Navigate(new projectHelp(currentProjectName));
        }

        private void storeTab_Click(object sender, RoutedEventArgs e)
        {
            normalizeButtons();
            Thickness border = new Thickness(1, 0, 1, 0);
            storeTab.BorderThickness = border;
            storeTabLabel.FontSize = 20;
            mainSubFrame.Navigate(new projectStore(currentProjectName));
        }

    }
}
