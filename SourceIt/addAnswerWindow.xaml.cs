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
    /// Window for answering a question in the help finder
    /// </summary>
    public partial class addAnswerWindow : Window
    {
        public addAnswerWindow(string username, string requestId)
        {
            InitializeComponent();
            //Get username and the help request id
            currentUser = username;
            request = requestId;
        }

        private string currentUser = "";
        private string request = "";

        //Close the window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string mainServerUrl = "";

        //Upload the answer and close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = newQuestionContentBox.Text;
            WebClient client = new WebClient();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string uploadUrl = mainServerUrl + "makeAnswer.php";
            NameValueCollection uploadData = new NameValueCollection();
            uploadData["content"] = content;
            uploadData["question"] = request;
            uploadData["user"] = currentUser;
            byte[] response = client.UploadValues(uploadUrl, "POST", uploadData);
            this.DialogResult = true;
            this.Close();
        }
    }
}
