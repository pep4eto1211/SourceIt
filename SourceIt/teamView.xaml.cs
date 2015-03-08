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
    /// Page for showing posts only from the teem of the project
    /// </summary>
    public partial class teamView : Page
    {
        public teamView(string theProjectName)
        {
            InitializeComponent();
            projectName = theProjectName;
        }

        BackgroundWorker postLoading = new BackgroundWorker();
        string projectName = "";
        string username = "";

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            postLoading.DoWork += postLoading_DoWork;
            postLoading.RunWorkerCompleted += postLoading_RunWorkerCompleted;
            postLoading.RunWorkerAsync();
        }

        //Show the loaded posts
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

        //Delete selected post
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

        //Load team feed posts
        void postLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            StreamReader usernameReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = usernameReader.ReadToEnd();
            reader.Close();
            WebClient webClient = new WebClient();
            string allPostsUrl = mainServerUrl + "getAllProjectPostsTeam.php";
            NameValueCollection getAllPostsValues = new NameValueCollection();
            getAllPostsValues["projectName"] = projectName;
            byte[] allPostsResponse = webClient.UploadValues(allPostsUrl, "POST", getAllPostsValues);
            string allPostsRaw = Encoding.UTF8.GetString(allPostsResponse);
            allPostsRaw = allPostsRaw.Remove(allPostsRaw.Length - 1);
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
    }
}
