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
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Collections;

namespace SourceIt
{
    /// <summary>
    /// Interaction logic for abilities.xaml
    /// </summary>
    /// 
    //This will be part of the future functionality of the platform
    public partial class abilities : Page
    {
        public abilities(string Username, string Password, string Email)
        {
            InitializeComponent();
            username = Username;
            password = Password;
            email = Email;
        }

        string username = "";
        string password = "";
        string email = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Get the server address
            string serverURL = "http://localhost/sourceit/register.php";
            WebClient webClient = new WebClient();
            //Creating collection with the data to be passed to the server
            NameValueCollection requestVariables = new NameValueCollection();
            requestVariables["user"] = username;
            requestVariables["pass"] = password;
            requestVariables["email"] = email;
            requestVariables["abil"] = "";
            requestVariables["int"] = "";
            //Sending request and getting the response
            byte[] responseBytes = webClient.UploadValues(serverURL, "POST", requestVariables);
            string response = Encoding.UTF8.GetString(responseBytes);
            if (response != "")
            {
                //Error
            }
            else
            {
                //OK
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
                        sw.Write(username);
                    }
                }
                this.NavigationService.Navigate(wellcome.EndWizardSignal, true);
            }
        }

    }
}
