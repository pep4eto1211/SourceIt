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

namespace SourceIt
{
    /// <summary>
    /// Window for writing new message
    /// </summary>
    public partial class newMessageWindow : Window
    {
        public newMessageWindow(string sender, string receiver)
        {
            InitializeComponent();
            to = receiver;
            from = sender;
        }

        private string to = "";
        private string from = "";

        private string mainServerUrl = "";

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Send the message
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (toBox.Text != "" && messageContentBox.Text != "")
            {
                WebClient client = new WebClient();
                string sendUrl = mainServerUrl + "sendMessage.php";
                NameValueCollection messageValues = new NameValueCollection();
                messageValues["content"] = messageContentBox.Text;
                messageValues["from"] = from;
                messageValues["to"] = toBox.Text;
                byte[] response = client.UploadValues(sendUrl, "POST", messageValues);
                this.DialogResult = true;
                this.Close();
            }
        }

        //Check if this is a reply and if it is write the receiver's name in the box
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            string url = mainServerUrl + "getUserName.php";
            NameValueCollection values = new NameValueCollection();
            values["id"] = to;
            to = Encoding.UTF8.GetString(client.UploadValues(url, "POST", values));
            toBox.Text = to;
        }
    }
}
