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
    /// Window for adding question to the help finder
    /// </summary>
    public partial class addQuestionWindow : Window
    {
        public addQuestionWindow(string username, string project)
        {
            InitializeComponent();
            currentUser = username;
            projectName = project;
        }

        private string currentUser = "";
        private string projectName = "";

        //Close the window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string mainServerUrl = "";

        //Get the server url, upload the question and close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = newQuestionContentBox.Text;
            WebClient client = new WebClient();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string uploadUrl = mainServerUrl + "makeQuestion.php";
            NameValueCollection uploadData = new NameValueCollection();
            string projectId = "-1";
            if (projectName != "")
            {
                string getProjectIdUrl = mainServerUrl + "getProjectId.php";
                NameValueCollection projectNameValue = new NameValueCollection();
                projectNameValue["name"] = projectName;
                byte[] projectIdResponse = client.UploadValues(getProjectIdUrl, "POST", projectNameValue);
                projectId = Encoding.UTF8.GetString(projectIdResponse);
            }
            uploadData["content"] = content;
            uploadData["project"] = projectId;
            uploadData["user"] = currentUser;
            byte[] response = client.UploadValues(uploadUrl, "POST", uploadData);
            if (projectName != "")
            {
                byte[] newPostResponse = client.UploadValues(mainServerUrl + "addHelpPost.php", "POST", uploadData);   
            }
            this.DialogResult = true;
            this.Close();
        }
    }
}
