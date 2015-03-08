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
    /// Dashboard of the current project
    /// </summary>
    /// 

    public partial class projectDashboard : Page
    {

        public string projectName = "";

        public projectDashboard(string theProjectName)
        {
            InitializeComponent();
            projectName = theProjectName;
        }

        public string username = "";
        BackgroundWorker postLoading = new BackgroundWorker();

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            postLoading.DoWork += postLoading_DoWork;
            postLoading.RunWorkerCompleted += postLoading_RunWorkerCompleted;
            postLoading.RunWorkerAsync();
        }

        //Show all posts releted to the project
        void postLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var singlePost in postsData)
            {
                singleProjectPost newPost = new singleProjectPost(singlePost, username);
                newPost.deletePostPressed += (object senderr, EventArgs ee) => 
                {
                    confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да изтриете този пост?");
                    if (conf.ShowDialog() == true)
                    {
                        deletePost(singlePost.theId);
                        NavigationService.Navigate(new projectDashboard(projectName));
                    }
                };
                allPostsPanel.Children.Add(newPost);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        //Delete post
        void deletePost(string projectId)
        {
            WebClient webClient = new System.Net.WebClient();
            string deleteUrl = mainServerUrl + "deletePost.php";
            NameValueCollection deleteValues = new NameValueCollection();
            deleteValues["id"] = projectId;
            byte[] deleteResponse = webClient.UploadValues(deleteUrl, "POST", deleteValues);
        }

        List<Post> postsData = new List<Post>();
        string mainServerUrl = "";

        //Load all the data about the posts
        void postLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            StreamReader usernameReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = usernameReader.ReadToEnd();
            reader.Close();
            WebClient webClient = new WebClient();
            string allPostsUrl = mainServerUrl + "getAllProjectPosts.php";
            NameValueCollection getAllPostsValues = new NameValueCollection();
            getAllPostsValues["projectName"] = projectName;
            byte[] allPostsResponse = webClient.UploadValues(allPostsUrl, "POST", getAllPostsValues);
            string allPostsRaw = Encoding.UTF8.GetString(allPostsResponse);
            allPostsRaw = allPostsRaw.Remove(allPostsRaw.Length-1);
            List<string> allPostsRawArray = allPostsRaw.Split(',').ToList<string>();
            int index = 1;
            string tempContent = "";
            string tempType = "";
            string tempUser = "";
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
                        tempId = singleRawItem;
                        index = 1;
                        postsData.Add(new Post(tempContent, tempType, tempUser, tempId));
                        break;
                }
            }
        }

        //Show the create new post grid
        private void newPostButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation slideDown = new DoubleAnimation();
            slideDown.From = 0;
            slideDown.To = 108;
            slideDown.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            newPostPanel.Visibility = System.Windows.Visibility.Visible;
            newPostPanel.BeginAnimation(Grid.HeightProperty, slideDown);
        }

        //Hide the create new post grid
        private void cancelPostCreationButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation slideDown = new DoubleAnimation();
            slideDown.From = 108;
            slideDown.To = 0;
            slideDown.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            slideDown.Completed += (object senderr, EventArgs ee) =>
            {
                newPostPanel.Visibility = System.Windows.Visibility.Hidden;
            };
            newPostPanel.BeginAnimation(Grid.HeightProperty, slideDown);
        }

        //Remove the placeholder of the new post box
        private void newPostContent_GotFocus(object sender, RoutedEventArgs e)
        {
            if (newPostContent.Text == "Напишете съдържанието на поста тук.")
            {
                newPostContent.Text = "";
                BrushConverter foregroundBrush = new BrushConverter();
                newPostContent.Foreground = (Brush)foregroundBrush.ConvertFrom("#FF303030");
            }
        }

        //Place back the placeholder
        private void newPostContent_LostFocus(object sender, RoutedEventArgs e)
        {
            if (newPostContent.Text == "")
            {
                newPostContent.Text = "Напишете съдържанието на поста тук.";
                BrushConverter foregroundBrush = new BrushConverter();
                newPostContent.Foreground = (Brush)foregroundBrush.ConvertFrom("#FFA6A6A6");
            }
        }

        //Create the new post and reload the dashboard
        private void createPostButton_Click(object sender, RoutedEventArgs e)
        {
            loaderLable.Text = "Създаване на пост";
            loader.Visibility = System.Windows.Visibility.Visible;
            string newPostContentText = newPostContent.Text;
            if (newPostContentText != "" && newPostContentText != "Напишете съдържанието на поста тук.")
            {
                string newPostUrl = mainServerUrl + "createNewPost.php";
                WebClient webClient = new WebClient();
                NameValueCollection newPostValues = new NameValueCollection();
                newPostValues["content"] = newPostContent.Text;
                newPostValues["project"] = projectName;
                newPostValues["user"] = username;
                byte[] serverResponse = webClient.UploadValues(newPostUrl, "POST", newPostValues);
                NavigationService.Navigate(new projectDashboard(projectName));
            }
            else
            {
               
            }
        }

        private void newPostButton_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
