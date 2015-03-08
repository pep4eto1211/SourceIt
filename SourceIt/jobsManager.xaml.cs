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
using System.Windows.Threading;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace SourceIt
{
    /// <summary>
    /// The jobs manager service
    /// </summary>
    public partial class jobsManager : Page
    {
        public jobsManager(string currentUser)
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

        BackgroundWorker initialWork = new BackgroundWorker();
        private string mainServerUrl = "";

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            initialWork.DoWork += initialWork_DoWork;
            initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            initialWork.RunWorkerAsync();
        }

        List<singleJob> allJobs = new List<singleJob>();

        //Show all job offers in the stack panel
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            allPostsPanel.Children.Clear();
            foreach (var singleJob in allJobs)
            {
                jobControl job = new jobControl(singleJob);
                job.sendMessage += (object senderr, EventArgs ee) =>
                {
                    WebClient client = new WebClient();
                    NameValueCollection receiverValue = new NameValueCollection();
                    receiverValue["user"] = singleJob.user;
                    string url = mainServerUrl + "getUserId.php";
                    string receiver = Encoding.UTF8.GetString(client.UploadValues(url, "POST", receiverValue));
                    newMessageWindow newMessage = new newMessageWindow(username, receiver);
                    newMessage.ShowDialog();
                };
                allPostsPanel.Children.Add(job);
            }
            if (allJobs.Count == 0)
            {
                allPostsPanel.Children.Add(emptyLabel);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        //Load the data for all the job offers
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            string rawJobs = client.DownloadString(mainServerUrl + "allJobs.php");
            if (rawJobs.Length > 0)
            {
                rawJobs = rawJobs.Remove(rawJobs.Length - 1);
            }
            string[] rawArray = rawJobs.Split(',');

            foreach (string item in rawArray)
            {
                singleJob job = new singleJob(item);
                job.jobInit();
                allJobs.Add(job);
            }
            if (rawJobs == "")
            {
                allJobs.RemoveAt(0);
            }
        }

        //Open the window for adding new job offer
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addJobWindow addJob = new addJobWindow(username);
            bool? result = addJob.ShowDialog();
            if (result == true)
            {
                NavigationService.Navigate(new jobsManager(username));
            }
        }

    }
}
