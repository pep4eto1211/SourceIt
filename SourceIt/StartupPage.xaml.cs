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
using System.Net;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace SourceIt
{
    /// <summary>
    /// Startup page
    /// </summary>
    public partial class StartupPage : Page
    {
        public StartupPage(string userName)
        {
            InitializeComponent();
            username = userName;
        }

        public string username = "";

        BackgroundWorker dashboardLoading = new BackgroundWorker();

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dashboardLoading.DoWork += dashboardLoading_DoWork;
            dashboardLoading.RunWorkerCompleted += dashboardLoading_RunWorkerCompleted;
            dashboardLoading.RunWorkerAsync();
        }

        public string mainServerUrl = "";

        //Load all posts related to the user
        void dashboardLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var singlePost in postsData)
            {
                startupPagePostControl singlePostControl = new startupPagePostControl(singlePost, username);
                singlePostControl.openProjectPressed += (object senderr, EventArgs ee) =>
                {
                    projectPage pp = new projectPage(singlePost.project);
                    pp.projectDeleted += pp_projectDeleted;
                    pp.modalDialogHidden += pp_modalDialogHidden;
                    pp.modalDialogShowed += pp_modalDialogShowed;
                    NavigationService.Navigate(pp);
                };
                singlePostControl.deletePostPressed += (object senderr, EventArgs ee) =>
                {
                    confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да изтриете?");
                    //confirmDialogEvent(e);
                    if (conf.ShowDialog() == true)
                    {
                        deletePost(singlePost.theId);
                        NavigationService.Navigate(new StartupPage(username));
                    }
                };
                postsPanel.Children.Add(singlePostControl);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        public event EventHandler projectDeleted;
        public event EventHandler modalDialogShowed;
        public event EventHandler modalDialogHidden;

        //Fire events
        private void pp_modalDialogShowed(object sender, EventArgs e)
        {
            modalDialogShowed(this, e);
        }

        private void pp_modalDialogHidden(object sender, EventArgs e)
        {
            modalDialogHidden(this, e);
        }

        private void pp_projectDeleted(object sender, EventArgs e)
        {
            projectDeleted(this, e);
        }

        List<startupPagePost> postsData = new List<startupPagePost>();
        public event EventHandler confirmDialogShowed;

        private void confirmDialogEvent(EventArgs e)
        {
            confirmDialogShowed(this, e);
        }

        //Delete cuurent post
        void deletePost(string projectId)
        {
            WebClient webClient = new System.Net.WebClient();
            string deleteUrl = mainServerUrl + "deletePost.php";
            NameValueCollection deleteValues = new NameValueCollection();
            deleteValues["id"] = projectId;
            byte[] deleteResponse = webClient.UploadValues(deleteUrl, "POST", deleteValues);
        }

        //Show all the posts loaded
        void dashboardLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"serverAddress.sid");
                mainServerUrl = reader.ReadToEnd();
                reader.Close();
                WebClient webClent = new System.Net.WebClient();
                string dashboardUrl = mainServerUrl + "startupPage.php";
                NameValueCollection startupPageNameValue = new NameValueCollection();
                startupPageNameValue["username"] = username;
                byte[] startupRequest = webClent.UploadValues(dashboardUrl, "POST", startupPageNameValue);
                string allPostsRaw = Encoding.UTF8.GetString(startupRequest);
                allPostsRaw = allPostsRaw.Remove(allPostsRaw.Length - 1);
                List<string> allPostsRawArray = allPostsRaw.Split(',').ToList<string>();
                int index = 1;
                string tempContent = "";
                string tempType = "";
                string tempUser = "";
                string tempProject = "";
                string tempId = "";
                foreach (var singleRawItem in allPostsRawArray)
                {
                    switch (index)
                    {
                        case 1:
                            tempContent = singleRawItem;
                            index++;
                            break;
                        case 2:
                            tempType = singleRawItem;
                            index++;
                            break;
                        case 3:
                            tempUser = singleRawItem;
                            index++;
                            break;
                        case 4:
                            tempProject = singleRawItem;
                            index++;
                            break;
                        case 5:
                            tempId = singleRawItem;
                            postsData.Add(new startupPagePost(tempContent, tempType, tempUser, tempProject, tempId));
                            index = 1;
                            break;
                    }
                }
            }
            catch(Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
            }
        }

        //Open services
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new helpFinder(username));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new jobsManager(username));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new store(username));
        }
    }
}
