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

namespace SourceIt
{
    /// <summary>
    /// The messaging service
    /// </summary>
    public partial class messagesPage : Page
    {
        public messagesPage(string currentUser)
        {
            InitializeComponent();
            username = currentUser;
        }

        private string username = "";
        private string mainServerUrl = "";

        BackgroundWorker loadWork = new BackgroundWorker();

        List<message> allMessages = new List<message>();

        //Go back to the startup page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartupPage(username));
        }

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            loadWork.DoWork += loadWork_DoWork;
            loadWork.RunWorkerCompleted += loadWork_RunWorkerCompleted;
            loadWork.RunWorkerAsync();
        }

        //Populate the stack panel with all messages
        void loadWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            allMessagesPanel.Children.Clear();
            foreach (var singleMessage in allMessages)
            {
                messageBox box = new messageBox(singleMessage);
                box.deleteMessage += (object senderr, EventArgs ee) =>
                {
                    confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да изтриете това съобщение?");
                    if (conf.ShowDialog() == true)
                    {
                        WebClient client = new WebClient();
                        string deleteUrl = mainServerUrl + "deleteMessage.php";
                        NameValueCollection idValue = new NameValueCollection();
                        idValue["id"] = singleMessage.id;
                        byte[] response = client.UploadValues(deleteUrl, "POST", idValue);
                        NavigationService.Navigate(new messagesPage(username));
                    }
                };
                box.sendResponse += (object senderr, EventArgs ee) =>
                {
                    WebClient client = new WebClient();
                    NameValueCollection receiverValue = new NameValueCollection();
                    receiverValue["user"] = singleMessage.from;
                    string url = mainServerUrl + "getUserId.php";
                    string receiver = Encoding.UTF8.GetString(client.UploadValues(url, "POST", receiverValue));
                    newMessageWindow newMessage = new newMessageWindow(username, receiver);
                    if (newMessage.ShowDialog() == true)
                    {
                        NavigationService.Navigate(new messagesPage(username));
                    }
                };
                allMessagesPanel.Children.Add(box);
            }
            if (allMessages.Count == 0)
            {
                allMessagesPanel.Children.Add(emptyLabel);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        //Load the data for all the messages
        void loadWork_DoWork(object sender, DoWorkEventArgs e)
        {
            allMessages.Clear();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            string idsUrl = mainServerUrl + "getAllMessages.php";
            NameValueCollection userValue = new NameValueCollection();
            userValue["user"] = username;
            byte[] response = client.UploadValues(idsUrl, "POST", userValue);
            string raw = Encoding.UTF8.GetString(response);
            if (raw.Length > 0)
            {
                raw = raw.Remove(raw.Length - 1);
            }
            string[] rawArray = raw.Split(',');

            foreach (string singleId in rawArray)
            {
                message singleMessage = new message(singleId);
                singleMessage.messageInit();
                allMessages.Add(singleMessage);
            }
            if (raw == "")
            {
                allMessages.RemoveAt(0);
            }
        }

        //Open the new message window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            newMessageWindow newMessage = new newMessageWindow(username, "");
            if (newMessage.ShowDialog() == true)
            {
                NavigationService.Navigate(new messagesPage(username));
            }
        }
    }
}
