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
using System.Windows.Forms;
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
    /// Window for downloading a project from the server location to the local machine
    /// </summary>
    public partial class downloadFilesWindow : Window
    {
        public downloadFilesWindow(string currentProject)
        {
            InitializeComponent();
            projectName = currentProject;
            TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Normal;
        }

        private string projectName = "";
        private string projectFolderPath = "";

        //Open a folder select dialog and select the download destination folder
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                folderNameBox.Text = folderDialog.SelectedPath;
                projectFolderPath = folderDialog.SelectedPath;
            }
        }

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //If the project have local folder fill it in the field
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            projectNameBox.Text = projectName;
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath += @"\SourceIt";
            folderPath += @"\Local Projects";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if (File.Exists(folderPath + @"\" + projectName + ".sid"))
            {
                StreamReader reader = new StreamReader(folderPath + @"\" + projectName + ".sid");
                string readed = reader.ReadToEnd();
                reader.Close();
                folderNameBox.Text = readed;
                projectFolderPath = readed;
            }
        }

        //Define the background worker
        BackgroundWorker fileDownload = new BackgroundWorker();
        private string mainServerUrl = "";

        //Minimize the window
        private void minimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        //Make the window topmost when it is active
        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.Topmost = true;
            }
        }

        string currentFileUpload = "";

        //Get list of all files on the server and download them one by one, and preserve the directory structure
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            logBox.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + "File download started.";
            if (projectFolderPath != "")
            {
                 fileDownload.DoWork += (object senderr, DoWorkEventArgs ee) =>
                 {
                     StreamReader reader = new StreamReader(@"serverAddress.sid");
                     mainServerUrl = reader.ReadToEnd();
                     reader.Close();
                     string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                     folderPath += @"\SourceIt";
                     folderPath += @"\Local Projects";
                     FileStream fs = null;
                     if (!File.Exists(folderPath + @"\" + projectName + ".sid"))
                     {
                         using (fs = File.Create(folderPath + @"\" + projectName + ".sid"))
                         {
                         }
                         using (StreamWriter sw = new StreamWriter(folderPath + @"\" + projectName + ".sid"))
                         {
                             sw.Write(projectFolderPath);
                         }
                     }
                     else
                     {
                         using (StreamWriter sw = new StreamWriter(folderPath + @"\" + projectName + ".sid"))
                         {
                             sw.Write(projectFolderPath);
                         }
                     }
                     WebClient webClient = new WebClient();
                     List<string> allProjectFilesList = new List<string>();
                     string downloadFilesUrl = mainServerUrl + "downloadProject.php";
                     NameValueCollection projectNameValue = new NameValueCollection();
                     projectNameValue["project"] = projectName;
                     byte[] downloadResponse = webClient.UploadValues(downloadFilesUrl, "POST", projectNameValue);
                     string rawResponse = Encoding.UTF8.GetString(downloadResponse);
                     if (rawResponse.Length > 0)
                     {
                         rawResponse.Remove(rawResponse.Length - 1);
                         allProjectFilesList = rawResponse.Split(',').ToList<string>();
                     }
                     else
                     {
                         allProjectFilesList = rawResponse.Split(',').ToList<string>();
                         allProjectFilesList.RemoveAt(0);
                     }

                     int allFiles = allProjectFilesList.Count;
                     int currentCount = 0;

                     foreach (string singleFile in allProjectFilesList)
                     {
                         currentCount++;
                         string finalName = singleFile.Substring(singleFile.LastIndexOf("/")+1);
                         string finalDir = singleFile.Remove(singleFile.LastIndexOf("/"));
                         finalDir = finalDir.Substring(finalDir.IndexOf("/")+1);
                         if (!Directory.Exists(projectFolderPath + finalDir))
                         {
                             Directory.CreateDirectory(projectFolderPath + "/" + finalDir);
                         }
                         webClient.DownloadFile(mainServerUrl + singleFile, projectFolderPath + "/" + finalDir + finalName);
                         double percents = (double)currentCount / allFiles;
                         percents = percents * 100;
                         fileDownload.ReportProgress((int)percents);
                         currentFileUpload = singleFile;
                     }
                 };
                 fileDownload.RunWorkerCompleted += (object senderr, RunWorkerCompletedEventArgs ee) =>
                 {
                     uploadProgress.Value = 100;
                     TaskbarItemInfo.ProgressValue = 1.0;
                     TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.None;
                     logBox.Text += Environment.NewLine + Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + "All files are downloaded successfully.";
                     logBox.ScrollToEnd();
                 };
                 fileDownload.ProgressChanged += (object senderr, ProgressChangedEventArgs ee) =>
                 {
                     uploadProgress.Value = ee.ProgressPercentage;
                     TaskbarItemInfo.ProgressValue = (double)ee.ProgressPercentage / 100;
                     logBox.Text += Environment.NewLine + Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + currentFileUpload + " downloaded successfully.";
                     logBox.ScrollToEnd();
                 };
                 fileDownload.WorkerReportsProgress = true;
                 fileDownload.RunWorkerAsync();
            }
            else
            {
                logBox.Text += Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "/ " + "Folder path is unavailable.";
            }
        }

    }
}
