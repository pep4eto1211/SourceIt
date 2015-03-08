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

namespace SourceIt
{
    /// <summary>
    /// Project info settings
    /// </summary>
    public partial class projectSettings : Page
    {

        public string theProjectName = "";

        public projectSettings(string projectName)
        {
            InitializeComponent();

            theProjectName = projectName;
        }

        BackgroundWorker loadingWorker = new BackgroundWorker();

        public string mainServerUrl = "";

        public string username = "";

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = reader.ReadToEnd();
            reader.Close();
            loadingWorker.DoWork += loadingWorker_DoWork;
            loadingWorker.RunWorkerCompleted += loadingWorker_RunWorkerCompleted;
            loadingWorker.RunWorkerAsync();
        }

        //Show the current project info
        private void loadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            projectNameBox.Text = theProjectName;
            projectDescription.Text = description;
            projectCategory.SelectedIndex = projectCategoryIndex - 1;
            foreach (var singleUser in usersIncluded)
            {
                usersIncludedListBox.Items.Add(singleUser);
            }
            hider.Visibility = System.Windows.Visibility.Hidden;
        }

        public int projectCategoryIndex = 0;
        public string description = "";
        public string[] usersIncluded = new string[500];

        //Load the current project info
        private void loadingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient webClient = new WebClient();
            string descriptionUrl = mainServerUrl + "getProjectDescription.php";
            NameValueCollection projectNameValues = new NameValueCollection();
            projectNameValues["project"] = theProjectName;
            byte[] responseBytes = webClient.UploadValues(descriptionUrl, "POST", projectNameValues);
            description = Encoding.UTF8.GetString(responseBytes);
            string getCategoryUrl = mainServerUrl + "getProjectCategory.php";
            NameValueCollection projectNameValue = new NameValueCollection();
            projectNameValue["project"] = theProjectName;
            byte[] projectCategoryResponse = webClient.UploadValues(getCategoryUrl, "POST", projectNameValue);
            projectCategoryIndex = int.Parse(Encoding.UTF8.GetString(projectCategoryResponse));
            string getUsersIncludedUrl = mainServerUrl + "getIncludedUsers.php";
            NameValueCollection getUsersValues = new NameValueCollection();
            getUsersValues["name"] = theProjectName;
            byte[] getUsersResponse = webClient.UploadValues(getUsersIncludedUrl, "POST", getUsersValues);
            usersIncluded = Encoding.UTF8.GetString(getUsersResponse).Remove(Encoding.UTF8.GetString(getUsersResponse).Length-1).Split(',');
        }

        //Go back to the dashboard
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new projectDashboard(theProjectName));
        }

        //Update project info
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            descriptionError.Visibility = System.Windows.Visibility.Hidden;
            if (projectDescription.Text != "")
            {
                if (projectDescription.Text.Length < 500)
                {
                    WebClient webClient = new WebClient();
                    string updateUrl = mainServerUrl + "updateInfo.php";
                    NameValueCollection updateValues = new NameValueCollection();
                    updateValues["category"] = (projectCategory.SelectedIndex + 1).ToString();
                    updateValues["description"] = projectDescription.Text;
                    updateValues["name"] = theProjectName;
                    byte[] response = webClient.UploadValues(updateUrl, "POST", updateValues);
                    NavigationService.Navigate(new projectSettings(theProjectName));
                }
                else
                {
                    descriptionError.Visibility = System.Windows.Visibility.Visible;
                    descriptionError.ToolTip = "Описанието трябва да е под 500 символа";
                }
            }
            else
            {
                descriptionError.Visibility = System.Windows.Visibility.Visible;
                descriptionError.ToolTip = "Това не може да е празно";
            }
        }

        //Open the add user window and add users if selected
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            addUserWindow addUser = new addUserWindow(username);
            if (addUser.ShowDialog() == true)
            {
                WebClient webClient = new WebClient();
                string updateUrl = mainServerUrl + "addUserToProject.php";
                NameValueCollection updateValues = new NameValueCollection();
                updateValues["username"] = addUser.selectedUser;
                updateValues["project"] = theProjectName;
                byte[] response = webClient.UploadValues(updateUrl, "POST", updateValues);
                NavigationService.Navigate(new projectSettings(theProjectName));
            }
            else
            {

            }
        }
    }
}
