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
    /// Window for adding users to a project
    /// </summary>
    public partial class addUserWindow : Window
    {
        public addUserWindow(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private string currentUser = "";
        public string selectedUser = "";

        //Define a new background worker
        BackgroundWorker initialWork = new BackgroundWorker();

        //Start the background worker
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            initialWork.DoWork += initialWork_DoWork;
            initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            initialWork.RunWorkerAsync();
        }

        //Show all users returned from the request
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var singleUser in allUsersList)
            {
                allUseresPanel.Items.Add(singleUser);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        private string mainServerUrl = "";
        List<string> allUsersList = new List<string>();

        //Request all available users from the database
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient webClient = new WebClient();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string url = mainServerUrl + "getAllUsers.php";
            NameValueCollection names = new NameValueCollection();
            names["username"] = currentUser;
            byte[] response = webClient.UploadValues(url, "POST", names);
            string allUsersRaw = Encoding.UTF8.GetString(response);
            if (allUsersRaw.Length > 0)
            {
                allUsersRaw = allUsersRaw.Remove(allUsersRaw.Length - 1);
            }
            allUsersList = allUsersRaw.Split(',').ToList<string>();
            if (allUsersList.Count == 1 && allUsersList[0] == "")
            {
                allUsersList.RemoveAt(0);
            }
        }

        //Show the add user button
        private void allUseresPanel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (allUseresPanel.SelectedItem != null)
            {
                addButton.Visibility = System.Windows.Visibility.Visible;
                selectedUser = allUseresPanel.SelectedItem.ToString();
            }
            else
            {
                addButton.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        //Close the window with true dialog result
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        //Close the window with false dialog result
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
