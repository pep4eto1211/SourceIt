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
using System.Windows.Media.Animation;

namespace SourceIt
{
    /// <summary>
    /// Window with all the things you can do with the files of a single project
    /// </summary>
    public partial class filesOperations : Window
    {
        public filesOperations(string currentProjectName)
        {
            InitializeComponent();
            projectName = currentProjectName;
        }

        private string projectName = "";

        //Close the window
        private void closeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Open the window for uploading files to the server
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uploadFilesWindow upload = new uploadFilesWindow(projectName);
            upload.Show();
        }

        //Open the window for downloading files from the server
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            downloadFilesWindow down = new downloadFilesWindow(projectName);
            down.Show();
        }

        //Open the local folder of the project, if set
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath += @"\SourceIt";
            folderPath += @"\Local Projects";
            if (File.Exists(folderPath + @"\" + projectName + ".sid"))
            {
                StreamReader reader = new StreamReader(folderPath + @"\" + projectName + ".sid");
                string readed = reader.ReadToEnd();
                reader.Close();
                if (Directory.Exists(readed))
                {
                    System.Diagnostics.Process.Start(readed);
                    this.Close();
                }
                else
                {
                    File.Delete(folderPath + @"\" + projectName + ".sid");
                    errorWindow err = new errorWindow("Все още не е зададена локална директория за този проект.");
                    err.ShowDialog();
                }
            }
            else
            {
                errorWindow err = new errorWindow("Все още не е зададена локална директория за този проект.");
                err.ShowDialog();
            }
        }

        private string mainServerUrl = "";

        //Check if there is backup of the project on the server and if yes- show a revert button
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string checkBackupUrl = mainServerUrl + "checkBackup.php";
            WebClient client = new WebClient();
            NameValueCollection projectNameValue = new NameValueCollection();
            projectNameValue["name"] = projectName;
            byte[] response = client.UploadValues(checkBackupUrl, "POST", projectNameValue);
            string responseString = Encoding.UTF8.GetString(response);
            if (responseString == "0")
            {
                beckupAvailableBlock.Text = "Не е налична по- ранна версия на проекта.";
            }
            else
            {
                beckupAvailableBlock.Text = "Налична е версия от преди промените, направени на " + responseString;
                undoButton.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Show the explorer for the files on the server
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            serverExplorer explorer = new serverExplorer(projectName);
            explorer.ShowDialog();
        }

        //Revert the project to previous version
        private void undoButton_Click(object sender, RoutedEventArgs e)
        {
            confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да върнете промените?");
            if (conf.ShowDialog() == true)
            {
                WebClient client = new WebClient();
                string undoUrl = mainServerUrl + "undo.php";
                NameValueCollection nameValue = new NameValueCollection();
                nameValue["project"] = projectName;
                byte[] response = client.UploadValues(undoUrl, "POST", nameValue);
                this.Close();
            }
        }
    }
}
