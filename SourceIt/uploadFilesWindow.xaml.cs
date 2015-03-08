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
    /// Window for uploading files of the project to the server
    /// </summary>
    public partial class uploadFilesWindow : Window
    {
        public uploadFilesWindow(string currentProjectName)
        {
            InitializeComponent();
            projectName = currentProjectName;
            TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.Normal;
        }

        private string projectName = "";
        private string projectFolderPath = "";

        //Open a folder select dialog and select a folder for upload
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

        //Check if the project has local folder and show in the box
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
            }
        }

        BackgroundWorker fileUpload = new BackgroundWorker();
        private string mainServerUrl = "";

        //Upload the folder to the server and preserve file structure
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            logBox.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + "File upload started.";
            if (projectFolderPath != "")
            {
                if (Directory.Exists(projectFolderPath))
                {
                    StreamReader reader = new StreamReader(@"serverAddress.sid");
                    mainServerUrl = reader.ReadToEnd();
                    reader.Close();
                    WebClient createBackupClient = new WebClient();
                    string createBackupUrl = mainServerUrl + "createBackup.php";
                    NameValueCollection nameValue = new NameValueCollection();
                    nameValue["project"] = projectName;
                    byte[] backupResponse = createBackupClient.UploadValues(createBackupUrl, "POST", nameValue);
                    string[] uploadFiles = Directory.GetFiles(projectFolderPath, "*.*", SearchOption.AllDirectories);
                    int allFiles = uploadFiles.Length;
                    string currentFileUpload = "";
                    fileUpload.DoWork += (object senderr, DoWorkEventArgs ee) =>
                    {
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
                        string uploadFilesUrl = mainServerUrl + "uploadProject.php?project=" + projectName;
                        int currentFileIndex = 0;
                        foreach (string singleFile in uploadFiles)
                        {
                            currentFileIndex++;
                            string subFolders = singleFile.Remove(0, projectFolderPath.Length);
                            if (subFolders != "")
                            {
                                subFolders = subFolders.Remove(subFolders.LastIndexOf(@"\"));
                            }
                            else
                            {
                                subFolders = "no";
                            }
                            byte[] response = webClient.UploadFile(uploadFilesUrl + "&subfolders=" + subFolders, singleFile);
                            currentFileUpload = singleFile;
                            double percents = (double)currentFileIndex/allFiles;
                            percents = percents * 100;
                           fileUpload.ReportProgress((int)percents);
                        }

                    };
                    fileUpload.RunWorkerCompleted += (object senderr, RunWorkerCompletedEventArgs ee) =>
                    {
                        uploadProgress.Value = 100;
                        TaskbarItemInfo.ProgressValue = 1.0;
                        TaskbarItemInfo.ProgressState = System.Windows.Shell.TaskbarItemProgressState.None;
                        logBox.Text += Environment.NewLine + Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + "All files are uploaded successfully to the server.";
                        logBox.ScrollToEnd();
                    };
                    fileUpload.ProgressChanged += (object senderr, ProgressChangedEventArgs ee) =>
                    {
                        uploadProgress.Value = ee.ProgressPercentage;
                        TaskbarItemInfo.ProgressValue = (double)ee.ProgressPercentage / 100;
                        logBox.Text += Environment.NewLine + Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + currentFileUpload + " uploaded successfully to the server.";
                        logBox.ScrollToEnd();
                    };
                    fileUpload.WorkerReportsProgress = true;
                    fileUpload.RunWorkerAsync();
                }
                else
                {
                    logBox.Text += Environment.NewLine + Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "-> " + "Folder path is unavailable.";
                }
            }
            else
            {
                logBox.Text += Environment.NewLine + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + "/ " + "Folder path is unavailable.";
            }
        }

        //Minimize window
        private void minimizeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        //Make window topmost when it is active
        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.WindowState.Normal)
            {
                this.Topmost = true;
            }
        }
    }
}
