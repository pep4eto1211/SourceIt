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
    /// Window for creating new project
    /// </summary>
    public partial class addProjectWindow : Window
    {
        public addProjectWindow()
        {
            InitializeComponent();
        }

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public int newProjectId = -1;

        //Check if the name is free and create new project record in the databse and store data for the project in the local files of the app
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nameError.Visibility = System.Windows.Visibility.Hidden;
            descriptionError.Visibility = System.Windows.Visibility.Hidden;
            categoryError.Visibility = System.Windows.Visibility.Hidden;

            string name = projectNameBox.Text;
            string description = projectDescription.Text;
            int category = projectCategory.SelectedIndex + 1;
            if (name != "" && description != "" && category != 0)
            {
                if (description.Length < 500)
                {
                    string serverUrl = mainServerUrl + "checkProject.php";
                    WebClient webClient = new WebClient();
                    //Creating collection with the data to be passed to the server
                    NameValueCollection requestVariables = new NameValueCollection();
                    requestVariables["project"] = name;
                    byte[] responseBytes = webClient.UploadValues(serverUrl, "POST", requestVariables);
                    string response = Encoding.UTF8.GetString(responseBytes);
                    if (response == "go")
                    {
                        StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
                        string username = reader.ReadToEnd();
                        reader.Close();
                        string addProjectUrl = mainServerUrl + "addProject.php";
                        WebClient addProjectClient = new WebClient();
                        NameValueCollection addProjectValues = new NameValueCollection();
                        addProjectValues["name"] = name;
                        addProjectValues["cat"] = category.ToString();
                        addProjectValues["desc"] = description;
                        addProjectValues["user"] = username;
                        byte[] addProjectResponseBytes = addProjectClient.UploadValues(addProjectUrl, "POST", addProjectValues);
                        string addProjectResponse = Encoding.UTF8.GetString(addProjectResponseBytes);
                        newProjectId = int.Parse(addProjectResponse);
                        FileStream fs = null;
                        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        folderPath += @"\SourceIt";
                        string projectsFolderPath = folderPath + @"\Projects";
                        string newProjectFilePath = projectsFolderPath + @"\" + name + ".sid";
                        using (fs = File.Create(newProjectFilePath))
                        {
                        }
                        using (StreamWriter sw = new StreamWriter(newProjectFilePath))
                        {
                            sw.Write(addProjectResponse);
                        }
                        this.DialogResult = true;
                        this.Close();
                    }
                    else
                    {
                        nameError.Visibility = System.Windows.Visibility.Visible;
                        nameError.ToolTip = "Името не е свободно";
                    }
                }
                else
                {
                    descriptionError.Visibility = System.Windows.Visibility.Visible;
                    descriptionError.ToolTip = "Описанието трябва да е под 500 символа";
                }
            }
            else
            {
                if (name == "")
                {
                    nameError.Visibility = System.Windows.Visibility.Visible;
                    nameError.ToolTip = "Това не може да е празно";
                }
                if (description == "")
                {
                    descriptionError.Visibility = System.Windows.Visibility.Visible;
                    descriptionError.ToolTip = "Това не може да е празно";
                }
                if (category == 0)
                {
                    categoryError.Visibility = System.Windows.Visibility.Visible;
                    categoryError.ToolTip = "Това не може да е празно";
                }
            }
        }

        public string mainServerUrl = "";

        //Get the main server url
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
        }
    }
}
