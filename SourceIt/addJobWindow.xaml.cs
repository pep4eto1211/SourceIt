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
    /// Window for adding new job offer
    /// </summary>
    public partial class addJobWindow : Window
    {
        public addJobWindow(string username)
        {
            InitializeComponent();
            user = username;
        }

        private string user = "";

        //Close the window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string mainServerUrl = "";

        //Upload the job offer and close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = newQuestionContentBox.Text;
            WebClient client = new WebClient();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string uploadUrl = mainServerUrl + "makeOffer.php";
            NameValueCollection uploadData = new NameValueCollection();
            uploadData["content"] = content;
            uploadData["user"] = user;
            byte[] response = client.UploadValues(uploadUrl, "POST", uploadData);
            this.DialogResult = true;
            this.Close();
        }
    }
}
