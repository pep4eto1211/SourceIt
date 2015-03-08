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
using System.Windows.Threading;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace SourceIt
{
    /// <summary>
    /// The main window of the app
    /// </summary>
    public partial class MainWindow : Window
    {
        //Is logged user variable
        public bool isOnline = false;
        public string username = "";
        public bool isFirstTime = false;
        public bool isConnected = false;
        //Background worker to keep the UI responsive while loading the app in the beginning
        BackgroundWorker initialWork = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Check of there is some change in the list with the projects
        public bool checkForProjectsChanges()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath += @"\SourceIt";
            string projectsFolderPath = folderPath + @"\Projects";
            if (!Directory.Exists(projectsFolderPath))
            {
                Directory.CreateDirectory(projectsFolderPath);
            }
            DirectoryInfo info = new DirectoryInfo(projectsFolderPath);
            FileInfo[] allProjects = info.GetFiles();
            int[] projectIds = new int[500];
            List<int> projectIdsQ = new List<int>();
            int arrayIndex = 0;
            string allProjectsLocal = "";
            foreach (var singleFile in allProjects)
            {
                StreamReader singleFileReader = singleFile.OpenText();
                string readedId = singleFileReader.ReadToEnd();
                singleFileReader.Close();
                projectIdsQ.Add(int.Parse(readedId));
                
            }
            Array.Sort(projectIds);
            projectIdsQ.Sort();
            foreach (int singleId in projectIdsQ)
            {
                allProjectsLocal += singleId + ",";
            }
            if (allProjectsLocal.Length>0)
            {
                allProjectsLocal = allProjectsLocal.Remove(allProjectsLocal.Length - 1);
            }
            string userIdUrl = mainServerUrl + "getUserId.php";
            WebClient userIdClient = new WebClient();
            NameValueCollection userIDCollection = new NameValueCollection();
            userIDCollection["user"] = username;
            byte[] responseIdBytes = userIdClient.UploadValues(userIdUrl, "POST", userIDCollection);
            string theUserId = Encoding.UTF8.GetString(responseIdBytes);
            string getProjectsFromServerUrl = mainServerUrl + "returnAllProjects.php";
            WebClient allProjectsClient = new WebClient();
            NameValueCollection allProjectsRequestValues = new NameValueCollection();
            allProjectsRequestValues["id"] = theUserId;
            byte[] responseProjectBytes = allProjectsClient.UploadValues(getProjectsFromServerUrl, "POST", allProjectsRequestValues);
            string allProjectsReturned = Encoding.UTF8.GetString(responseProjectBytes);
            if (allProjectsReturned.Length>0)
            {
                allProjectsReturned = allProjectsReturned.Remove(allProjectsReturned.Length-1);
            }
            if (allProjectsLocal != allProjectsReturned)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Get all projects
        public string getProjects()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderPath += @"\SourceIt";
            string projectsFolderPath = folderPath + @"\Projects";
            if (!Directory.Exists(projectsFolderPath))
            {
                Directory.CreateDirectory(projectsFolderPath);
            }
            DirectoryInfo info = new DirectoryInfo(projectsFolderPath);
            FileInfo[] allProjects = info.GetFiles();
            string allProjectsLocal = "";
            foreach (var singleFile in allProjects)
            {
                allProjectsLocal += singleFile.Name + ",";
            }
            if (allProjectsLocal.Length > 0)
            {
                allProjectsLocal = allProjectsLocal.Remove(allProjectsLocal.Length - 1);
            }
            return allProjectsLocal;
        }

        //Get all projects on the server
        public string getProjectsOnline()
        {
            string userIdUrl = mainServerUrl + "getUserId.php";
            WebClient userIdClient = new WebClient();
            NameValueCollection userIDCollection = new NameValueCollection();
            userIDCollection["user"] = username;
            byte[] responseIdBytes = userIdClient.UploadValues(userIdUrl, "POST", userIDCollection);
            string theUserId = Encoding.UTF8.GetString(responseIdBytes);
            string getProjectsFromServerUrl = mainServerUrl + "returnAllProjects.php";
            WebClient allProjectsClient = new WebClient();
            NameValueCollection allProjectsRequestValues = new NameValueCollection();
            allProjectsRequestValues["id"] = theUserId;
            byte[] responseProjectBytes = allProjectsClient.UploadValues(getProjectsFromServerUrl, "POST", allProjectsRequestValues);
            string allProjectsReturned = Encoding.UTF8.GetString(responseProjectBytes);
            if (allProjectsReturned.Length > 0)
            {
                allProjectsReturned = allProjectsReturned.Remove(allProjectsReturned.Length - 1);
            }
            string[] allProjectIds = allProjectsReturned.Split(',');
            string returnString = "";
            foreach (var singleId in allProjectIds)
            {
                WebClient webClient = new WebClient();
                string getNameUrl = mainServerUrl + "getProjectName.php";
                NameValueCollection idValues = new NameValueCollection();
                idValues["projectId"] = singleId;
                byte[] response = webClient.UploadValues(getNameUrl, "POST", idValues);
                returnString += Encoding.UTF8.GetString(response) + "," + singleId + ",";
            }
            if (returnString.Length>0)
            {
                returnString = returnString.Remove(returnString.Length - 1);
            }
            return returnString;
        }

        string[] allProjectsArray = new string[500];
        //Create the loading window
        InitialLoading load;
        //Background worker first part
        List<Notification> allNotifications = new List<Notification>();
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //Check if application folder exists in My Documents
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderPath += @"\SourceIt";
                string isUsedPath = folderPath + @"\isUsed.sid";
                string projectsFolderPath = folderPath + @"\Projects";
                //Create application folder if not exits and a file wich indicates will a tutorial will be shown
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    FileStream fs = null;
                    if (!File.Exists(isUsedPath))
                    {
                        using (fs = File.Create(isUsedPath))
                        {
                        }
                        using (StreamWriter sw = new StreamWriter(isUsedPath))
                        {
                            sw.Write("no");
                        }
                        //Show tutorial
                        isFirstTime = true;
                    }
                    Directory.CreateDirectory(projectsFolderPath);
                }
                else
                {
                    //Reads the username from the file
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid"))
                    {
                        StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
                        string readed = reader.ReadToEnd();
                        reader.Close();
                        reader.Dispose();
                        if (readed != "")
                        {
                            username = readed;
                        }
                    }
                    else
                    {
                        //Create username file if it does not exists
                        FileStream userFile = null;
                        using (userFile = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid"))
                        {
                        }
                        using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid"))
                        {
                            sw.Write("");
                        }
                    }
                }
            }
            catch (Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
            }
        }

        //Reload all projects
        public void reloadProjects()
        {
            projectsList.Children.Clear();
            if (!checkForProjectsChanges())
            {
                string allProjectsString = getProjects();
                allProjectsArray = allProjectsString.Split(',');
                foreach (var singleProject in allProjectsArray)
                {
                    string nameForFunction = "";
                    if (singleProject.Length > 0)
                    {
                        nameForFunction = singleProject.Remove(singleProject.Length - 4);
                    }
                    projectsList.Children.Add(projectListEntry(nameForFunction));
                }
            }
        }

        //Returns a button control for the list with the projects
        public Button projectListEntry(string projectName)
        {
            Button toReturn = new Button();
            toReturn.Content = projectName;
            toReturn.FontSize = 26;
            toReturn.Cursor = Cursors.Hand;
            toReturn.FontFamily = new FontFamily("Segoe UI Light");
            Thickness padding = new Thickness(0, 10, 0, 10);
            toReturn.Padding = padding;
            Thickness border = new Thickness(1, 0, 1, 1);
            toReturn.BorderThickness = border;
            toReturn.Style = (Style)Application.Current.Resources["ProjectListEntryStyle"];
            ContextMenu newMenu = new System.Windows.Controls.ContextMenu();
            MenuItem deleteProject = new MenuItem();
            deleteProject.Header = "Изтриване на проект";
            deleteProject.Click += (object sender, RoutedEventArgs e) =>
            {
                confirmWindow confirmDelete = new confirmWindow("Сигурни ли сте, че искате да изтриете този проект?");
                hider.Visibility = System.Windows.Visibility.Visible;
                DoubleAnimation dialogAnimation = new DoubleAnimation();
                dialogAnimation.From = 0;
                dialogAnimation.To = 1;
                dialogAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                confirmDelete.BeginAnimation(Window.OpacityProperty, dialogAnimation);
                if (confirmDelete.ShowDialog() == true)
                {
                    hider.Visibility = System.Windows.Visibility.Hidden;
                    WebClient webClent = new WebClient();
                    string deleteServerUrl = mainServerUrl + "deleteProject.php";
                    NameValueCollection deleteProjectValies = new NameValueCollection();
                    deleteProjectValies["project"] = projectName;
                    deleteProjectValies["user"] = username;
                    byte[] deleteProjectResponse = webClent.UploadValues(deleteServerUrl, "POST", deleteProjectValies);
                    string serverResponse = Encoding.UTF8.GetString(deleteProjectResponse);
                    if (serverResponse == "ok")
                    {
                        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        folderPath += @"\SourceIt";
                        string projectsFolderPath = folderPath + @"\Projects";
                        File.Delete(projectsFolderPath + @"\" + projectName + ".sid");
                        reloadProjects();
                        StartupPage thePage = new StartupPage(username);
                        thePage.projectDeleted += pp_projectDeleted;
                        thePage.modalDialogShowed += pp_modalDialogShowed;
                        thePage.modalDialogHidden += pp_modalDialogHidden;
                        //thePage.confirmDialogShowed += pageToLoad_confirmDialogShowed;
                        mainFrame.Navigate(thePage);
                    }
                    else
                    {

                    }
                }
                else
                {
                    hider.Visibility = System.Windows.Visibility.Hidden;
                }
            };
            newMenu.Items.Add(deleteProject);
            toReturn.ContextMenu = newMenu;
            toReturn.Click += (object sender, RoutedEventArgs e) =>
            {
                projectPage pp = new projectPage(projectName);
                pp.projectDeleted += pp_projectDeleted;
                pp.modalDialogHidden += pp_modalDialogHidden;
                pp.modalDialogShowed += pp_modalDialogShowed;
                mainFrame.Navigate(pp);
            };
            return toReturn;
        }

        //Show semi-transperent rectangle
        void pp_modalDialogShowed(object sender, EventArgs e)
        {
            hider.Visibility = System.Windows.Visibility.Visible;
        }

        //Show the rectangle
        void pp_modalDialogHidden(object sender, EventArgs e)
        {
            hider.Visibility = System.Windows.Visibility.Hidden;
        }

        //Call the reload projects function
        void pp_projectDeleted(object sender, EventArgs e)
        {
            reloadProjects();
        }

        //Background worker part II
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isFirstTime)
            {
                isConnected = true;
                offlineMessage.Visibility = System.Windows.Visibility.Hidden;
                //If there is no logged user
                load.Hide();
                hider.Visibility = System.Windows.Visibility.Visible;
                //Show the login window
                LoginWindow log = new LoginWindow();
                bool? result = log.ShowDialog();
                //If the user log in into a profile
                if (result == true)
                {
                    isOnline = true;
                    try
                    {
                        StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
                        username = reader.ReadToEnd();
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                    }
                    if (!checkForProjectsChanges())
                    {
                        try
                        {
                            string allProjectsString = getProjects();
                            allProjectsArray = allProjectsString.Split(',');
                            foreach (var singleProject in allProjectsArray)
                            {
                                string nameForFunction = "";
                                if (singleProject.Length > 0)
                                {
                                    nameForFunction = singleProject.Remove(singleProject.Length - 4);
                                }
                                projectsList.Children.Add(projectListEntry(nameForFunction));
                            }
                        }
                        catch (Exception)
                        {
                            errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                        }
                    }
                    else
                    {
                        try
                        {
                            string onlineProjects = getProjectsOnline();
                            string[] onlineProjectsArray = onlineProjects.Split(',');
                            string tempName = "";
                            string tempId1 = "";
                            int index = 1;
                            foreach (var singleItem in onlineProjectsArray)
                            {
                                switch (index)
                                {
                                    case 1:
                                        tempName = singleItem;
                                        index++;
                                        break;
                                    case 2:
                                        tempId1 = singleItem;
                                        index = 1;
                                        FileStream fs = null;
                                        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                        folderPath += @"\SourceIt";
                                        string projectsFolderPath = folderPath + @"\Projects";
                                        string newProjectFilePath = projectsFolderPath + @"\" + tempName + ".sid";
                                        using (fs = File.Create(newProjectFilePath))
                                        {
                                        }
                                        using (StreamWriter sw = new StreamWriter(newProjectFilePath))
                                        {
                                            sw.Write(tempId1);
                                        }
                                        break;
                                }
                            }
                            reloadProjects();
                        }
                        catch (Exception)
                        {
                            errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                        }
                    }
                    usernameLabel.Content = username;
                    string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                    statusIcon.Source = new BitmapImage(new Uri(imagePath));
                    onlineStatusLabel.Content = "Онлайн";
                    hider.Visibility = System.Windows.Visibility.Hidden;
                }
                else
                {
                    needLogin nel = new needLogin();
                    bool? closeIt = nel.ShowDialog();
                    if (closeIt == false)
                    {
                        Application.Current.Shutdown();
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                //If this is not the first time the user uses the app
                hider.Visibility = System.Windows.Visibility.Hidden;
                if (username != "")
                {
                    //If the user is already logged in
                    if (isConnected)
                    {
                        //If there is connection to the server change status to online
                        usernameLabel.Content = username;
                        string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                        statusIcon.Source = new BitmapImage(new Uri(imagePath));
                        onlineStatusLabel.Content = "Онлайн";
                        if (!checkForProjectsChanges())
                        {
                            try
                            {
                                string allProjectsString = getProjects();
                                allProjectsArray = allProjectsString.Split(',');
                                foreach (var singleProject in allProjectsArray)
                                {
                                    string nameForFunction = "";
                                    if (singleProject.Length > 0)
                                    {
                                        nameForFunction = singleProject.Remove(singleProject.Length - 4);
                                    }
                                    projectsList.Children.Add(projectListEntry(nameForFunction));
                                }
                            }
                            catch (Exception)
                            {
                                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                            }
                        }
                        else
                        {
                            try
                            {
                                string onlineProjects = getProjectsOnline();
                                string[] onlineProjectsArray = onlineProjects.Split(',');
                                string tempName = "";
                                string tempId1 = "";
                                int index = 1;
                                foreach (var singleItem in onlineProjectsArray)
                                {
                                    switch (index)
                                    {
                                        case 1:
                                            tempName = singleItem;
                                            index++;
                                            break;
                                        case 2:
                                            tempId1 = singleItem;
                                            index = 1;
                                            FileStream fs = null;
                                            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                            folderPath += @"\SourceIt";
                                            string projectsFolderPath = folderPath + @"\Projects";
                                            string newProjectFilePath = projectsFolderPath + @"\" + tempName + ".sid";
                                            using (fs = File.Create(newProjectFilePath))
                                            {
                                            }
                                            using (StreamWriter sw = new StreamWriter(newProjectFilePath))
                                            {
                                                sw.Write(tempId1);
                                            }
                                            break;
                                    }
                                }
                                reloadProjects();
                            }
                            catch (Exception)
                            {
                                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                            }
                        }
                        WebClient webClient = new WebClient();
                        string getNotificationsUrl = mainServerUrl + "getNotifications.php";
                        NameValueCollection getNotificationsValues = new NameValueCollection();
                        getNotificationsValues["username"] = username;
                        byte[] response = webClient.UploadValues(getNotificationsUrl, "POST", getNotificationsValues);
                        string notificationsRaw = Encoding.UTF8.GetString(response);
                        if (notificationsRaw.Length > 0)
                        {
                            notificationsRaw = notificationsRaw.Remove(notificationsRaw.Length - 1);
                        }
                        string[] notificationsArray = notificationsRaw.Split(',');
                        string tempProject = "";
                        string tempContent = "";
                        string tempId = "";
                        int currentIndex = 1;
                        foreach (var singleNotification in notificationsArray)
                        {
                            switch (currentIndex)
                            {
                                case 1:
                                    tempContent = singleNotification;
                                    currentIndex++;
                                    break;
                                case 2:
                                    tempProject = singleNotification;
                                    currentIndex++;
                                    break;
                                case 3:
                                    tempId = singleNotification;
                                     currentIndex = 1;
                                    allNotifications.Add(new Notification(tempProject, tempContent, tempId));
                                    break;
                            }
                        }
                        if (allNotifications.Count > 0)
                        {
                            if (allNotifications.Count <= 3)
                            {
                                foreach (var oneNotification in allNotifications)
                                {
                                    TextBlock theNotification = new TextBlock();
                                    theNotification.Text = oneNotification.content + " on project: " + oneNotification.project;
                                    theNotification.FontFamily = new FontFamily("Segoe UI Light");
                                    theNotification.MaxHeight = 24;
                                    theNotification.FontSize = 18;
                                    Color foreground = new Color();
                                    foreground.B = 30;
                                    foreground.R = 30;
                                    foreground.G = 30;
                                    foreground.A = 255;
                                    Thickness margin = new Thickness(5, 0, 0, 0);
                                    theNotification.Margin = margin;
                                    theNotification.Foreground = new SolidColorBrush(foreground);
                                    theNotification.TextTrimming = TextTrimming.CharacterEllipsis;
                                    theNotification.ToolTip = oneNotification.content + " по проект: " + oneNotification.project;
                                    notificationsPanel.Children.Add(theNotification);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < 2; i++)
                                {
                                    TextBlock theNotification = new TextBlock();
                                    theNotification.Text = allNotifications[i].content + " по проект: " + allNotifications[i].project;
                                    theNotification.FontFamily = new FontFamily("Segoe UI Light");
                                    theNotification.MaxHeight = 24;
                                    theNotification.FontSize = 18;
                                    Color foreground = new Color();
                                    foreground.B = 30;
                                    foreground.R = 30;
                                    foreground.G = 30;
                                    foreground.A = 255;
                                    Thickness margin = new Thickness(5, 0, 0, 0);
                                    theNotification.Margin = margin;
                                    theNotification.Foreground = new SolidColorBrush(foreground);
                                    theNotification.TextTrimming = TextTrimming.CharacterEllipsis;
                                    theNotification.ToolTip = allNotifications[i].content + " по проект: " + allNotifications[i].project; 
                                    notificationsPanel.Children.Add(theNotification);
                                }
                                TextBlock moreNotifications = new TextBlock();
                                moreNotifications.Text = (allNotifications.Count-2).ToString() + " повече известия";
                                moreNotifications.FontFamily = new FontFamily("Segoe UI Light");
                                moreNotifications.MaxHeight = 24;
                                moreNotifications.FontSize = 18;
                                Color moreForeground = new Color();
                                moreForeground.B = 30;
                                moreForeground.R = 30;
                                moreForeground.G = 30;
                                moreForeground.A = 255;
                                Thickness moreMargin = new Thickness(5, 0, 0, 0);
                                moreNotifications.Margin = moreMargin;
                                moreNotifications.Foreground = new SolidColorBrush(moreForeground);
                                moreNotifications.TextTrimming = TextTrimming.CharacterEllipsis;
                                notificationsPanel.Children.Add(moreNotifications);
                            }
                            
                        }
                        else
                        {
                            TextBlock noNotifications = new TextBlock();
                            noNotifications.Text = "Няма нови известия";
                            noNotifications.FontFamily = new FontFamily("Segoe UI Light");
                            noNotifications.MaxHeight = 24;
                            noNotifications.FontSize = 18;
                            Color moreForeground = new Color();
                            moreForeground.B = 30;
                            moreForeground.R = 30;
                            moreForeground.G = 30;
                            moreForeground.A = 255;
                            Thickness margin = new Thickness(5, 0, 0, 0);
                            noNotifications.Margin = margin;
                            noNotifications.Foreground = new SolidColorBrush(moreForeground);
                            noNotifications.TextTrimming = TextTrimming.CharacterEllipsis;
                            notificationsPanel.Children.Add(noNotifications);
                        }
                    }
                    else
                    {
                        //If there is no connection just show the username
                        usernameLabel.Content = username;
                        string allProjectsString = getProjects();
                        allProjectsArray = allProjectsString.Split(',');
                        foreach (var singleProject in allProjectsArray)
                        {
                            string nameForFunction = "";
                            if (singleProject.Length > 0)
                            {
                                nameForFunction = singleProject.Remove(singleProject.Length - 4);
                            }
                            projectsList.Children.Add(projectListEntry(nameForFunction));
                        }
                    }
                }
                else
                {
                    //If the user is not logged in
                    if (isConnected)
                    {
                        //If there is connection to the server
                        load.Hide();
                        hider.Visibility = System.Windows.Visibility.Visible;
                        //Show the login window
                        LoginWindow log = new LoginWindow();
                        bool? result = log.ShowDialog();
                        //If the user log in into a profile
                        if (result == true)
                        {
                            try
                            {
                                isOnline = true;
                                //Read the username
                                StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
                                username = reader.ReadToEnd();
                                reader.Close();
                                if (!checkForProjectsChanges())
                                {
                                    string allProjectsString = getProjects();
                                    allProjectsArray = allProjectsString.Split(',');
                                    foreach (var singleProject in allProjectsArray)
                                    {
                                        string nameForFunction = "";
                                        if (singleProject.Length > 0)
                                        {
                                            nameForFunction = singleProject.Remove(singleProject.Length - 4);
                                        }
                                        projectsList.Children.Add(projectListEntry(nameForFunction));
                                    }
                                }
                                else
                                {
                                    string onlineProjects = getProjectsOnline();
                                    string[] onlineProjectsArray = onlineProjects.Split(',');
                                    string tempName = "";
                                    string tempId1 = "";
                                    int index = 1;
                                    foreach (var singleItem in onlineProjectsArray)
                                    {
                                        switch (index)
                                        {
                                            case 1:
                                                tempName = singleItem;
                                                index++;
                                                break;
                                            case 2:
                                                tempId1 = singleItem;
                                                index = 1;
                                                FileStream fs = null;
                                                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                                folderPath += @"\SourceIt";
                                                string projectsFolderPath = folderPath + @"\Projects";
                                                string newProjectFilePath = projectsFolderPath + @"\" + tempName + ".sid";
                                                using (fs = File.Create(newProjectFilePath))
                                                {
                                                }
                                                using (StreamWriter sw = new StreamWriter(newProjectFilePath))
                                                {
                                                    sw.Write(tempId1);
                                                }
                                                break;
                                        }
                                    }
                                    reloadProjects();
                                }
                                //And change the status to online
                                usernameLabel.Content = username;
                                string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                                statusIcon.Source = new BitmapImage(new Uri(imagePath));
                                onlineStatusLabel.Content = "Онлайн";
                                hider.Visibility = System.Windows.Visibility.Hidden;
                            }
                            catch (Exception)
                            {
                                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                            }
                        }
                        else
                        {
                            //If the user refuses to log in, it can't use the app and I am showing him window that is informing him about this
                            needLogin nel = new needLogin();
                            bool? closeIt = nel.ShowDialog();
                            if (closeIt == false)
                            {
                                Application.Current.Shutdown();
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        //If there is no connection
                        load.Hide();
                        hider.Visibility = System.Windows.Visibility.Visible;
                        //SHow window to inform the user about the lack of connection
                        noUserNoCon nocon = new noUserNoCon();
                        bool? theres = nocon.ShowDialog();
                        if (theres == false)
                        {
                            //If user decides to quit the app
                            Application.Current.Shutdown();
                        }
                        else
                        {
                            //Connection is restored
                            isConnected = true;
                            offlineMessage.Visibility = System.Windows.Visibility.Hidden;
                            //If there is no logged user
                            load.Hide();
                            hider.Visibility = System.Windows.Visibility.Visible;
                            //Show the login window
                            LoginWindow log = new LoginWindow();
                            bool? result = log.ShowDialog();
                            //If the user log in into a profile
                            //The same stuff as above
                            if (result == true)
                            {
                                try
                                {
                                    isOnline = true;
                                    StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
                                    username = reader.ReadToEnd();
                                    reader.Close();
                                    if (!checkForProjectsChanges())
                                    {
                                        string allProjectsString = getProjects();
                                        allProjectsArray = allProjectsString.Split(',');
                                        foreach (var singleProject in allProjectsArray)
                                        {
                                            string nameForFunction = "";
                                            if (singleProject.Length > 0)
                                            {
                                                nameForFunction = singleProject.Remove(singleProject.Length - 4);
                                            }
                                            projectsList.Children.Add(projectListEntry(nameForFunction));
                                        }
                                    }
                                    else
                                    {
                                        string onlineProjects = getProjectsOnline();
                                        string[] onlineProjectsArray = onlineProjects.Split(',');
                                        string tempName = "";
                                        string tempId1 = "";
                                        int index = 1;
                                        foreach (var singleItem in onlineProjectsArray)
                                        {
                                            switch (index)
                                            {
                                                case 1:
                                                    tempName = singleItem;
                                                    index++;
                                                    break;
                                                case 2:
                                                    tempId1 = singleItem;
                                                    index = 1;
                                                    FileStream fs = null;
                                                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                                    folderPath += @"\SourceIt";
                                                    string projectsFolderPath = folderPath + @"\Projects";
                                                    string newProjectFilePath = projectsFolderPath + @"\" + tempName + ".sid";
                                                    using (fs = File.Create(newProjectFilePath))
                                                    {
                                                    }
                                                    using (StreamWriter sw = new StreamWriter(newProjectFilePath))
                                                    {
                                                        sw.Write(tempId1);
                                                    }
                                                    break;
                                            }
                                        }
                                        reloadProjects();
                                    }
                                    usernameLabel.Content = username;
                                    string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                                    statusIcon.Source = new BitmapImage(new Uri(imagePath));
                                    onlineStatusLabel.Content = "Онлайн";
                                    hider.Visibility = System.Windows.Visibility.Hidden;
                                }
                                catch (Exception)
                                {
                                    errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                                }
                            }
                            else
                            {
                                needLogin nel = new needLogin();
                                bool? closeIt = nel.ShowDialog();
                                if (closeIt == false)
                                {
                                    Application.Current.Shutdown();
                                }
                                else
                                {

                                }
                            }
                        }
                    }
                }
            }
            //Load the dashboard into the frame
            StartupPage thePage = new StartupPage(username);
            thePage.projectDeleted += pp_projectDeleted;
            thePage.modalDialogShowed += pp_modalDialogShowed;
            thePage.modalDialogHidden += pp_modalDialogHidden;
            mainFrame.Navigate(thePage);
            initialWork.CancelAsync();
            load.Hide();
        }

        //Show the rectangle again
        void pageToLoad_confirmDialogShowed(object sender, EventArgs e)
        {
            hider.Visibility = System.Windows.Visibility.Visible;
        }
        //App close
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Close button
            WindowStyle = WindowStyle.SingleBorderWindow;
            Application.Current.Shutdown();
        }
        //Window drag
        private void titleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Window dragging
            if (e.ChangedButton == MouseButton.Left)
            {
                Application.Current.MainWindow.DragMove();
            }
        }
        //Minimise
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Minimise app
            WindowStyle = WindowStyle.SingleBorderWindow;
            this.WindowState = System.Windows.WindowState.Minimized;
        }
        //Show status menu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Show online/offline menu
            //For next update
            /*
            ContextMenu onlineStatus = this.FindResource("onlineStatusMenu") as ContextMenu;
            onlineStatus.PlacementTarget = sender as Button;
            onlineStatus.IsOpen = true; */
        }
        //Change status to online
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (isOnline)
            {
                //If there is connection to the server go online
                string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                statusIcon.Source = new BitmapImage(new Uri(imagePath));
                onlineStatusLabel.Content = "Онлайн";
            }
        }
        //Change status to offline
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Change the status to offline
            string imagePath = String.Format(@"pack://application:,,,/Images/disconnected.png");
            statusIcon.Source = new BitmapImage(new Uri(imagePath));
            onlineStatusLabel.Content = "Офлайн";
        }

        //The server url
        public string mainServerUrl = "";
        //Do all kinds of initial work
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //SHow semi-transperent rectangle over the window
            hider.Visibility = System.Windows.Visibility.Visible;
            //Read the server url
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            //Check   for connection
            try
            {
                //Show loading window if it takes too long
                load = new InitialLoading();
                load.Show();
                //Set up the background worker to do all the stuff above
                initialWork.DoWork += initialWork_DoWork;
                initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
                initialWork.WorkerSupportsCancellation = true;
                //Run the background worker
                initialWork.RunWorkerAsync();
                //Check the connection status- if it trows exception- no connection for you m8
                WebClient checkCon = new WebClient();
                string url = mainServerUrl + "checkConnection.php";
                string response = checkCon.DownloadString(url);
                if (response == "OK")
                {
                    //Connection OK
                    isConnected = true;
                }
            }
            catch (System.Net.WebException)
            {
                //No connection to the server
                isConnected = false;
                offlineMessage.Visibility = System.Windows.Visibility.Visible;
            }
        }
        //Run tryReconnect()
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //The button that shows if there is no connection and it tris again
            tryReconnect();
        }
        //Try connect to the server again
        void tryReconnect()
        {
            //The reconnection function itself
            try
            {
                //See if there is conection
                WebClient checkCon = new WebClient();
                string url = mainServerUrl + "checkConnection.php";
                string response = checkCon.DownloadString(url);
                if (response == "OK")
                {
                    //C onnection restored
                    isConnected = true;
                    offlineMessage.Visibility = System.Windows.Visibility.Hidden;
                    string imagePath = String.Format(@"pack://application:,,,/Images/connected.png");
                    statusIcon.Source = new BitmapImage(new Uri(imagePath));
                    onlineStatusLabel.Content = "Онлайн";
                }
            }
            catch (System.Net.WebException)
            {
                //No connection for you
                isConnected = false;
            }
        }
        //Add new project
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            hider.Visibility = System.Windows.Visibility.Visible;
            addProjectWindow addPr = new addProjectWindow();
            bool? resultFromProject = addPr.ShowDialog();
            hider.Visibility = System.Windows.Visibility.Hidden;
            if (resultFromProject == true)
            {
                int projectId = addPr.newProjectId;
                if (projectId != -1)
                {
                    //Project creation OK
                    if (!checkForProjectsChanges())
                    {
                        string allProjectsString = getProjects();
                        allProjectsArray = allProjectsString.Split(',');
                        projectsList.Children.Clear();
                        foreach (var singleProject in allProjectsArray)
                        {
                            string nameForFunction = "";
                            if (singleProject.Length > 0)
                            {
                                nameForFunction = singleProject.Remove(singleProject.Length - 4);
                            }
                            projectsList.Children.Add(projectListEntry(nameForFunction));
                        }
                    }
                }
                else
                {
                    //Project creation failed
                }
            }
        }

        //Deal with the windows animations
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            if (WindowStyle != WindowStyle.None)
            {
                Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, (DispatcherOperationCallback)delegate(object unused)
                {
                    WindowStyle = WindowStyle.None;
                    return null;
                }
                , null);
            }
        }

        //This is replaced in this version
        private void notificationsPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new notificationsPage(username));
        }

        //Open the help finder service
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new helpFinder(username));
        }

        //Open the jobs manager service
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new jobsManager(username));
        }

        //Open the store service
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new store(username));
        }

        //Open the app settings
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new settings(username));
        }

        //Open all notifications
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new notificationsPage(username));
        }

        //Open the messaging service
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new messagesPage(username));
        }
    }
}
