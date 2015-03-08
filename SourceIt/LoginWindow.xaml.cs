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
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace SourceIt
{
    /// <summary>
    /// IWindow for logging into your account
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        string mainServerUrl = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Sending false dialog result if the user clicks cancel
            this.DialogResult = false;
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            //Login window click
            userError.Visibility = System.Windows.Visibility.Hidden;
            passError.Visibility = System.Windows.Visibility.Hidden;
            string userName = "";
            string password = "";
            //Checking for empty fields
            if (userNameBox.Text != "" && passwordBox.Password != "")
            {
                //If nothing is empty sending a request to check if the data is correct
                string serverUrl = mainServerUrl + "login.php";
                WebClient webClient = new WebClient();
                //Creating collection with the data to be passed to the server
                NameValueCollection requestVariables = new NameValueCollection();
                requestVariables["user"] = userNameBox.Text;
                requestVariables["pass"] = passwordBox.Password;
                byte[] responseBytes = webClient.UploadValues(serverUrl, "POST", requestVariables);
                string response = Encoding.UTF8.GetString(responseBytes);
                if (response == "no")
                {
                    //This means wrong login data
                    userError.Visibility = System.Windows.Visibility.Visible;
                    passError.Visibility = System.Windows.Visibility.Visible;
                    userError.ToolTip = "Грешно име или парола";
                    passError.ToolTip = "Грешно име или парола";
                }
                else if (response == "yes")
                {
                    //Writing the username to the username file
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    folderPath += @"\SourceIt";
                    string usernamePath = folderPath + @"\username.sid";
                    FileStream fs = null;
                    if (!File.Exists(usernamePath))
                    {
                        using (fs = File.Create(usernamePath))
                        {
                        }
                        using (StreamWriter sw = new StreamWriter(usernamePath))
                        {
                            sw.Write(userNameBox.Text);
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(usernamePath))
                        {
                            sw.Write(userNameBox.Text);
                        }
                    }
                    //Sending true dialog result if the user log in successfully
                    this.DialogResult = true;
                    this.Close();
                }
            }
            else
            {
                if (passwordBox.Password == "")
                {
                    passError.Visibility = System.Windows.Visibility.Visible;
                    passError.ToolTip = "Това не може да е празно";
                }
                if (userNameBox.Text == "")
                {
                    userError.Visibility = System.Windows.Visibility.Visible;
                    userError.ToolTip = "Това не може да е празно";
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
        }

        //Open the registration window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            registerWindow regWin = new registerWindow();
            if (regWin.ShowDialog() == true)
            {
                this.DialogResult = true;
                this.Close();
            }
        }

        //Open the change server window
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            changeServerWindow ch = new changeServerWindow();
            ch.ShowDialog();
        }
    }
}
