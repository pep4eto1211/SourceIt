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
using System.Collections.Specialized;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;

namespace SourceIt
{
    /// <summary>
    /// Window for creating new registration
    /// </summary>
    public partial class registerWindow : Window
    {
        public registerWindow()
        {
            InitializeComponent();
        }

        string mainServerUrl = "";

        //Hide all errors
        void resetErrorVisibility()
        {
            userError.Visibility = System.Windows.Visibility.Hidden;
            passError.Visibility = System.Windows.Visibility.Hidden;
            confError.Visibility = System.Windows.Visibility.Hidden;
            emailError.Visibility = System.Windows.Visibility.Hidden;
        }

        //Check email format
        bool isEmailValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //Create md5 hash
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //Compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //Get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //Change it into 2 hexadecimal digits for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            //Return the string
            return strBuilder.ToString();
        }

        //Register
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetErrorVisibility();
            //Check if there are any empty fields
            if (userBox.Text != "" && passBox.Password != "" && confPass.Password != "" && emailBox.Text != "")
            {
                if (passBox.Password == confPass.Password)
                {
                    if (isEmailValid(emailBox.Text))
                    {
                        //Getting server register page url and starting a new webclient
                        string serverUrl = mainServerUrl + "checkUser.php";
                        WebClient webClient = new WebClient();
                        //Creating collection with the data to be passed to the server
                        NameValueCollection requestVariables = new NameValueCollection();
                        requestVariables["user"] = userBox.Text;
                        //Sending request and getting the response
                        byte[] responseBytes = webClient.UploadValues(serverUrl, "POST", requestVariables);
                        string response = Encoding.UTF8.GetString(responseBytes);
                        //Read the request
                        if (response == "ue")
                        {
                            //Username taken error
                            userError.Visibility = System.Windows.Visibility.Visible;
                            userError.ToolTip = "This username is already taken";
                        }
                        else
                        {
                            //Continue with registration and check if e-mail exists
                            string serverUrl1 = mainServerUrl + "checkEmail.php";
                            WebClient webClient1 = new WebClient();
                            //Creating collection with the data to be passed to the server
                            NameValueCollection requestVariables1 = new NameValueCollection();
                            requestVariables["emailr"] = emailBox.Text;
                            //Sending request and getting the response
                            byte[] responseBytes1 = webClient.UploadValues(serverUrl1, "POST", requestVariables);
                            string response1 = Encoding.UTF8.GetString(responseBytes);
                            if (response1 == "et")
                            {
                                emailError.Visibility = System.Windows.Visibility.Visible;
                                emailError.ToolTip = "User with this e-mail already exists";
                            }
                            else
                            {
                                //Everything is OK- go on with the registration
                                string encryptedPass_1 = MD5Hash(passBox.Password);
                                encryptedPass_1 = encryptedPass_1 + "pixel";
                                string encryptedPassword = MD5Hash(encryptedPass_1);
                                //Get the server address
                                string serverURL = mainServerUrl + "register.php";
                                //Creating collection with the data to be passed to the server
                                NameValueCollection therequestVariables = new NameValueCollection();
                                requestVariables1["user"] = userBox.Text;
                                requestVariables1["pass"] = passBox.Password;
                                requestVariables1["email"] = emailBox.Text;
                                requestVariables1["abil"] = "";
                                requestVariables1["int"] = "";
                                //Sending request and getting the response
                                byte[] theresponseBytes = webClient.UploadValues(serverURL, "POST", therequestVariables);
                                string theresponse = Encoding.UTF8.GetString(theresponseBytes);
                                if (theresponse != "")
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
                                            sw.Write(userBox.Text);
                                        }
                                    }
                                    this.DialogResult = true;
                                    this.Close();
                                }
                            }
                            //Close the second webclient
                            webClient1.Dispose();
                        }
                        //Close the webclient
                        webClient.Dispose();
                    }
                    else
                    {
                        emailError.Visibility = System.Windows.Visibility.Visible;
                        emailError.ToolTip = "E-mail format is invalid";
                    }
                }
                else
                {
                    //Passwords do not match error
                    confError.Visibility = System.Windows.Visibility.Visible;
                    confError.ToolTip = "Passwords do not match";
                }
            }
            else
            {
                //Empty fields error handling
                if (userBox.Text == "")
                {
                    userError.Visibility = System.Windows.Visibility.Visible;
                    userError.ToolTip = "This can't be empty";
                }
                if (passBox.Password == "")
                {
                    passError.Visibility = System.Windows.Visibility.Visible;
                    passError.ToolTip = "This can't be empty";
                }
                if (confPass.Password == "")
                {
                    confError.Visibility = System.Windows.Visibility.Visible;
                    confError.ToolTip = "This can't be empty";
                }
                if (emailBox.Text == "")
                {
                    emailError.Visibility = System.Windows.Visibility.Visible;
                    emailError.ToolTip = "This can't be empty";
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
        }

        //Close the window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
