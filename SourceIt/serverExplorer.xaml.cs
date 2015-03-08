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
using System.Windows.Forms;

namespace SourceIt
{
    /// <summary>
    /// File explorer for the files on the server
    /// </summary>
    public partial class serverExplorer : Window
    {
        public serverExplorer(string currentProjectName)
        {
            InitializeComponent();
            projectName = currentProjectName;
        }

        private string projectName = "";
        private string currentPath = "";
        private string rootPath = "";
        BackgroundWorker work = new BackgroundWorker();
        BackgroundWorker recursiveWorker = new BackgroundWorker();
        BackgroundWorker uploadFilesWorker = new BackgroundWorker();

        //Set the location label and start the initial background worker
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            titleLabel.Content += " " + projectName;
            locationBlock.Text = projectName + "/";
            rootPath = projectName + "/";
            currentPath = rootPath;
            explorerCanvas.Children.Clear();
            work.DoWork += work_DoWork;
            work.RunWorkerCompleted += work_RunWorkerCompleted;
            work.RunWorkerAsync();
        }

        //Show all the files and folders at current location
        void work_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            explorerCanvas.Children.Clear();
            if (foldersList.Count>0)
            {
                explorerCanvas.Children.Add(foldersLabel);
            }
            WrapPanel foldersWrap = new WrapPanel();
            foreach (var folder in foldersList)
            {
                string newFolder = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFolderControl folderControl = new singleFolderControl(newFolder);
                folderControl.ContextMenu = folderMenu(newFolder);
                folderControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                    currentPath += newFolder + "/";
                    if (currentPath != rootPath)
                    {
                        backButton.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        backButton.Visibility = System.Windows.Visibility.Hidden;
                    }
                    locationBlock.Text = currentPath;
                    work.Dispose();
                    recursiveWorker.DoWork += recursiveWorker_DoWork;
                    recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                    recursiveWorker.RunWorkerAsync();
                };
                foldersWrap.Children.Add(folderControl);
            }
            explorerCanvas.Children.Add(foldersWrap);
            if (filesList.Count > 0)
            {
                explorerCanvas.Children.Add(filesLabel);
            }
            WrapPanel filesWrap = new WrapPanel();
            foreach (var file in filesList)
            {
                string newFile = file;
                //newFile = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFileControl fileControl = new singleFileControl(newFile);
                System.Windows.Controls.ContextMenu theFileMenu = fileMenu(newFile);
                fileControl.ContextMenu = theFileMenu;
                fileControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                };
                filesWrap.Children.Add(fileControl);
            }
            explorerCanvas.Children.Add(filesWrap);
            if (filesList.Count == 0 && foldersList.Count == 0)
            {
                explorerCanvas.Children.Add(emptyLabel);
            }
        }

        //Load all the folders and files here
        void recursiveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient webClient = new WebClient();
                foldersList = getAllFolders(currentPath, webClient);
                filesList = getAllFiles(currentPath, webClient);
            }
            catch (Exception)
            {

                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                re.ShowDialog();
            }
        }

        private string mainServerUrl = "";

        //Load the files and the folders
        void work_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(@"serverAddress.sid");
                mainServerUrl = reader.ReadToEnd();
                reader.Close();
                WebClient webClient = new WebClient();
                foldersList = getAllFolders(currentPath, webClient);
                filesList = getAllFiles(currentPath, webClient);
            }
            catch (Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                re.ShowDialog();
            }
        }

        List<string> foldersList = new List<string>();
        List<string> filesList = new List<string>();

        //Get all folders from given location
        private List<string> getAllFolders(string location, WebClient client)
        {
            NameValueCollection values = new NameValueCollection();
            values["path"] = location;
            byte[] response = client.UploadValues(mainServerUrl + "listAllFolders.php", "POST", values);
            string stringResponse = Encoding.UTF8.GetString(response);
            if (stringResponse.Length > 0)
            {
                stringResponse = stringResponse.Remove(stringResponse.Length - 1);
            }
            if (stringResponse.Length == 0)
            {
                List<string> toReturn = stringResponse.Split(',').ToList<string>();
                toReturn.RemoveAt(0);
                return toReturn;
            }
            return stringResponse.Split(',').ToList<string>();
        }

        //Get all files form given location
        private List<string> getAllFiles(string location, WebClient client)
        {
            NameValueCollection values = new NameValueCollection();
            values["path"] = location;
            byte[] response = client.UploadValues(mainServerUrl + "listAllFiles.php", "POST", values);
            string stringResponse = Encoding.UTF8.GetString(response);
            if (stringResponse.Length > 0)
            {
                stringResponse = stringResponse.Remove(stringResponse.Length - 1);
            }
            if (stringResponse.Length == 0)
            {
                List<string> toReturn = stringResponse.Split(',').ToList<string>();
                toReturn.RemoveAt(0);
                return toReturn;
            }
            return stringResponse.Split(',').ToList<string>();
        }

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        //Got to the home location of the project
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            currentPath = rootPath;
            locationBlock.Text = currentPath;
            backButton.Visibility = System.Windows.Visibility.Hidden;
            work.Dispose();
            recursiveWorker.DoWork += recursiveWorker_DoWork;
            recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
            recursiveWorker.RunWorkerAsync();
        }

        //Go back
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            currentPath = currentPath.Remove(currentPath.Length - 1);
            currentPath = currentPath.Remove(currentPath.LastIndexOf('/')+1);
            locationBlock.Text = currentPath;
            if (currentPath == rootPath)
            {
                backButton.Visibility = System.Windows.Visibility.Hidden;
            }
            work.Dispose();
            recursiveWorker.DoWork += recursiveWorker_DoWork;
            recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
            recursiveWorker.RunWorkerAsync();
        }

        List<string> filesForUpload = new List<string>();

        //Uplaod a file to the current location
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.Title = "Изберете файлове";
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filesForUpload = openFile.FileNames.ToList<string>();
                uploadFilesWorker.RunWorkerCompleted += uploadFilesWorker_RunWorkerCompleted;
                uploadFilesWorker.DoWork += uploadFilesWorker_DoWork;
                Loader.Visibility = System.Windows.Visibility.Visible;
                uploadFilesWorker.RunWorkerAsync();
            }
        }

        //Background worker for the file upload
        void uploadFilesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int allFiles = filesForUpload.Count;
            WebClient webClient = new WebClient();
            string uploadFilesUrl = mainServerUrl + "uploadProject.php?project=" + projectName;
            foreach (string singleFile in filesForUpload)
            {
                string subFolders = currentPath;
                if (subFolders == projectName + "/")
                {
                    subFolders = "no";
                }
                else
                {
                    subFolders = subFolders.Substring(projectName.Length);
                }
                byte[] response = webClient.UploadFile(uploadFilesUrl + "&subfolders=" + subFolders, singleFile);
            }
            try
            {
                WebClient webClient1 = new WebClient();
                foldersList = getAllFolders(currentPath, webClient1);
                filesList = getAllFiles(currentPath, webClient1);
            }
            catch (Exception)
            {

                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                re.ShowDialog();
            }
        }

        //The runworker completed function for the fies upload which is reloading the directory
        void uploadFilesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (currentPath != rootPath)
            {
                backButton.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                backButton.Visibility = System.Windows.Visibility.Hidden;
            }
            locationBlock.Text = currentPath;
            work.Dispose();
            recursiveWorker.DoWork += recursiveWorker_DoWork;
            recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
            Loader.Visibility = System.Windows.Visibility.Hidden;
            uploadFilesWorker.Dispose();
            explorerCanvas.Children.Clear();
            if (foldersList.Count > 0)
            {
                explorerCanvas.Children.Add(foldersLabel);
            }
            WrapPanel foldersWrap = new WrapPanel();
            foreach (var folder in foldersList)
            {
                string newFolder = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFolderControl folderControl = new singleFolderControl(newFolder);
                folderControl.ContextMenu = folderMenu(newFolder);
                folderControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                    currentPath += newFolder + "/";
                    if (currentPath != rootPath)
                    {
                        backButton.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        backButton.Visibility = System.Windows.Visibility.Hidden;
                    }
                    locationBlock.Text = currentPath;
                    work.Dispose();
                    recursiveWorker.DoWork += recursiveWorker_DoWork;
                    recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                    recursiveWorker.RunWorkerAsync();
                };
                foldersWrap.Children.Add(folderControl);
            }
            explorerCanvas.Children.Add(foldersWrap);
            if (filesList.Count > 0)
            {
                explorerCanvas.Children.Add(filesLabel);
            }
            WrapPanel filesWrap = new WrapPanel();
            foreach (var file in filesList)
            {
                string newFile = file;
                //newFile = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFileControl fileControl = new singleFileControl(newFile);
                System.Windows.Controls.ContextMenu theFileMenu = fileMenu(newFile);
                fileControl.ContextMenu = theFileMenu;
                fileControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                };
                filesWrap.Children.Add(fileControl);
            }
            explorerCanvas.Children.Add(filesWrap);
            if (filesList.Count == 0 && foldersList.Count == 0)
            {
                explorerCanvas.Children.Add(emptyLabel);
            }
        }

        System.Windows.Controls.ContextMenu folderMenu(string folderName)
        {
            System.Windows.Controls.ContextMenu toReturn = new System.Windows.Controls.ContextMenu();
            System.Windows.Controls.MenuItem openItem = new System.Windows.Controls.MenuItem();
            openItem.Header = "Отвори";
            openItem.Click += (object sender, RoutedEventArgs e) =>
            {
                currentPath += folderName + "/";
                if (currentPath != rootPath)
                {
                    backButton.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    backButton.Visibility = System.Windows.Visibility.Hidden;
                }
                locationBlock.Text = currentPath;
                work.Dispose();
                recursiveWorker.DoWork += recursiveWorker_DoWork;
                recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                recursiveWorker.RunWorkerAsync();
            };
            System.Windows.Controls.MenuItem downloadItem = new System.Windows.Controls.MenuItem();
            downloadItem.Header = "Свали";
            downloadItem.Click += (object sender, RoutedEventArgs e) =>
            {
                string serverFileLocation = currentPath + folderName + "/";
                string requestUrl = mainServerUrl + "downloadFolder.php";
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    loadingMessage.Text = "Сваляне на файлове";
                    Loader.Visibility = System.Windows.Visibility.Visible;
                    WebClient client = new WebClient();
                    NameValueCollection folderValue = new NameValueCollection();
                    folderValue["path"] = serverFileLocation;
                    byte[] response = client.UploadValues(requestUrl, "POST", folderValue);
                    string rawResponse = Encoding.UTF8.GetString(response);
                    if (rawResponse.Length>0)
                    {
                        rawResponse = rawResponse.Remove(rawResponse.Length - 1);
                    }
                    string[] allFiles = rawResponse.Split(',');
                    WebClient webClient = new WebClient();
                    foreach (string singleFile in allFiles)
                    {
                        string finalName = singleFile.Substring(singleFile.LastIndexOf("/") + 1);
                        string finalDir = singleFile.Remove(singleFile.LastIndexOf("/"));
                        finalDir = finalDir.Substring(finalDir.IndexOf("/") + 1);
                        if (!Directory.Exists(dialog.SelectedPath + finalDir))
                        {
                            Directory.CreateDirectory(dialog.SelectedPath + "/" + finalDir);
                        }
                        webClient.DownloadFile(mainServerUrl + singleFile, dialog.SelectedPath + "/" + finalDir + finalName);
                    }
                    loadingMessage.Text = "Качване на файлове";
                    Loader.Visibility = System.Windows.Visibility.Hidden;
                }
            };
            System.Windows.Controls.MenuItem deleteItem = new System.Windows.Controls.MenuItem();
            deleteItem.Header = "Изтрий";
            deleteItem.Click += (object sender, RoutedEventArgs e) =>
            {
                string toDeletePath = currentPath + folderName + "/";
                WebClient client = new WebClient();
                NameValueCollection pathValue = new NameValueCollection();
                pathValue["path"] = toDeletePath;
                byte[] response = client.UploadValues(mainServerUrl + "deleteFolder.php", "POST", pathValue);
                refreshFolder();
            };
            toReturn.Items.Add(openItem);
            toReturn.Items.Add(downloadItem);
            toReturn.Items.Add(deleteItem);
            return toReturn;
        }

        System.Windows.Controls.ContextMenu fileMenu(string fileName)
        {
            System.Windows.Controls.ContextMenu toReturn = new System.Windows.Controls.ContextMenu();
            System.Windows.Controls.MenuItem downloadItem = new System.Windows.Controls.MenuItem();
            downloadItem.Header = "Свали";
            downloadItem.Click += (object sender, RoutedEventArgs e) =>
            {
                string serverFileLocation = mainServerUrl + currentPath + fileName;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Сваляне на файл";
                dialog.FileName = fileName;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    WebClient client = new WebClient();
                    client.DownloadFileAsync(new Uri(serverFileLocation), dialog.FileName);
                }
            };
            System.Windows.Controls.MenuItem deleteItem = new System.Windows.Controls.MenuItem();
            deleteItem.Header = "Изтрий";
            deleteItem.Click += (object sender, RoutedEventArgs e) =>
            {
                WebClient client = new WebClient();
                NameValueCollection pathValue = new NameValueCollection();
                pathValue["path"] = "Projects/" + currentPath + fileName;
                byte[] response = client.UploadValues(mainServerUrl + "deleteFile.php", "POST", pathValue);
                refreshFolder();
            };
            toReturn.Items.Add(downloadItem);
            toReturn.Items.Add(deleteItem);
            return toReturn;
        }

        //Refresh folder function
        private void refreshFolder()
        {
            try
            {
                WebClient webClient1 = new WebClient();
                foldersList = getAllFolders(currentPath, webClient1);
                filesList = getAllFiles(currentPath, webClient1);
            }
            catch (Exception)
            {

                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                re.ShowDialog();
            }

            if (currentPath != rootPath)
            {
                backButton.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                backButton.Visibility = System.Windows.Visibility.Hidden;
            }
            locationBlock.Text = currentPath;
            work.Dispose();
            recursiveWorker.DoWork += recursiveWorker_DoWork;
            recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
            Loader.Visibility = System.Windows.Visibility.Hidden;
            uploadFilesWorker.Dispose();
            explorerCanvas.Children.Clear();
            if (foldersList.Count > 0)
            {
                explorerCanvas.Children.Add(foldersLabel);
            }
            WrapPanel foldersWrap = new WrapPanel();
            foreach (var folder in foldersList)
            {
                string newFolder = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFolderControl folderControl = new singleFolderControl(newFolder);
                folderControl.ContextMenu = folderMenu(newFolder);
                folderControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                    currentPath += newFolder + "/";
                    if (currentPath != rootPath)
                    {
                        backButton.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        backButton.Visibility = System.Windows.Visibility.Hidden;
                    }
                    locationBlock.Text = currentPath;
                    work.Dispose();
                    recursiveWorker.DoWork += recursiveWorker_DoWork;
                    recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                    recursiveWorker.RunWorkerAsync();
                };
                foldersWrap.Children.Add(folderControl);
            }
            explorerCanvas.Children.Add(foldersWrap);
            if (filesList.Count > 0)
            {
                explorerCanvas.Children.Add(filesLabel);
            }
            WrapPanel filesWrap = new WrapPanel();
            foreach (var file in filesList)
            {
                string newFile = file;
                //newFile = folder.Substring(folder.LastIndexOf('/') + 1);
                singleFileControl fileControl = new singleFileControl(newFile);
                System.Windows.Controls.ContextMenu theFileMenu = fileMenu(newFile);
                fileControl.ContextMenu = theFileMenu;
                fileControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                {
                };
                filesWrap.Children.Add(fileControl);
            }
            explorerCanvas.Children.Add(filesWrap);
            if (filesList.Count == 0 && foldersList.Count == 0)
            {
                explorerCanvas.Children.Add(emptyLabel);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
    
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string newFolderName = "";
            createFolderWindow createFolder = new createFolderWindow();
            bool? result = createFolder.ShowDialog();
            if (result == true)
            {
                newFolderName = createFolder.newFolderName;
                WebClient client = new WebClient();
                NameValueCollection pathValue = new NameValueCollection();
                pathValue["path"] = currentPath + newFolderName + "/";
                byte[] response = client.UploadValues(mainServerUrl + "createNewFolder.php", "POST", pathValue);
                if (Encoding.UTF8.GetString(response) == "ok")
                {
                    try
                    {
                        WebClient webClient1 = new WebClient();
                        foldersList = getAllFolders(currentPath, webClient1);
                        filesList = getAllFiles(currentPath, webClient1);
                    }
                    catch (Exception)
                    {

                        errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                        re.ShowDialog();
                    }

                    if (currentPath != rootPath)
                    {
                        backButton.Visibility = System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        backButton.Visibility = System.Windows.Visibility.Hidden;
                    }
                    locationBlock.Text = currentPath;
                    work.Dispose();
                    recursiveWorker.DoWork += recursiveWorker_DoWork;
                    recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                    Loader.Visibility = System.Windows.Visibility.Hidden;
                    uploadFilesWorker.Dispose();
                    explorerCanvas.Children.Clear();
                    if (foldersList.Count > 0)
                    {
                        explorerCanvas.Children.Add(foldersLabel);
                    }
                    WrapPanel foldersWrap = new WrapPanel();
                    foreach (var folder in foldersList)
                    {
                        string newFolder = folder.Substring(folder.LastIndexOf('/') + 1);
                        singleFolderControl folderControl = new singleFolderControl(newFolder);
                        folderControl.ContextMenu = folderMenu(newFolder);
                        folderControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                        {
                            currentPath += newFolder + "/";
                            if (currentPath != rootPath)
                            {
                                backButton.Visibility = System.Windows.Visibility.Visible;
                            }
                            else
                            {
                                backButton.Visibility = System.Windows.Visibility.Hidden;
                            }
                            locationBlock.Text = currentPath;
                            work.Dispose();
                            recursiveWorker.DoWork += recursiveWorker_DoWork;
                            recursiveWorker.RunWorkerCompleted += work_RunWorkerCompleted;
                            recursiveWorker.RunWorkerAsync();
                        };
                        foldersWrap.Children.Add(folderControl);
                    }
                    explorerCanvas.Children.Add(foldersWrap);
                    if (filesList.Count > 0)
                    {
                        explorerCanvas.Children.Add(filesLabel);
                    }
                    WrapPanel filesWrap = new WrapPanel();
                    foreach (var file in filesList)
                    {
                        string newFile = file;
                        //newFile = folder.Substring(folder.LastIndexOf('/') + 1);
                        singleFileControl fileControl = new singleFileControl(newFile);
                        System.Windows.Controls.ContextMenu theFileMenu = fileMenu(newFile);
                        fileControl.ContextMenu = theFileMenu;
                        fileControl.MouseLeftButtonDown += (object senderr, MouseButtonEventArgs ee) =>
                        {
                        };
                        filesWrap.Children.Add(fileControl);
                    }
                    explorerCanvas.Children.Add(filesWrap);
                    if (filesList.Count == 0 && foldersList.Count == 0)
                    {
                        explorerCanvas.Children.Add(emptyLabel);
                    }
                }
                else
                {

                }
            }
        }
    }
}
