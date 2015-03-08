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
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;
using System.IO.Compression;

namespace SourceIt
{
    /// <summary>
    /// The store page of the item, asociated with this project
    /// </summary>
    public partial class projectStore : Page
    {
        public projectStore(string theProjectName)
        {
            InitializeComponent();
            currentProject = theProjectName;
        }

        string currentProject = "";
        private string username = "";

        BackgroundWorker initialWork = new BackgroundWorker();

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            allPostsPanel.Children.Clear();
            initialWork.DoWork += initialWork_DoWork;
            initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            initialWork.RunWorkerAsync();
        }

        //Download the asociated store item
        private void downloadItem(string itemName)
        {
            string selectedDestination = "";
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                loader.Visibility = System.Windows.Visibility.Visible;
                selectedDestination = folderDialog.SelectedPath;
                string currentTempFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\Temp\";
                if (!Directory.Exists(currentTempFolder))
                {
                    Directory.CreateDirectory(currentTempFolder);
                }
                WebClient client = new WebClient();
                string statsUrl = mainServerUrl + "newDownload.php";
                NameValueCollection name = new NameValueCollection();
                name["name"] = itemName;
                byte[] response = client.UploadValues(statsUrl, "POST", name);
                client.DownloadFile(mainServerUrl + "Store/" + itemName + "/" + itemName + ".sii", currentTempFolder + itemName + ".sii");
                ZipFile.ExtractToDirectory(currentTempFolder + itemName + ".sii", selectedDestination);
                File.Delete(currentTempFolder + itemName + ".sii");
                loader.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        //Show the data for the item
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isOnStore)
            {
                itemNameLabel.Text = storeItemName;
                itemDescriptionLabel.Text = storeItemDescription;
                BitmapImage iconImage = new BitmapImage();
                iconImage.BeginInit();
                iconImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                iconImage.UriSource = new Uri(mainServerUrl + "Store/" + storeItemName + "/screenshot.png");
                iconImage.CacheOption = BitmapCacheOption.None;
                iconImage.EndInit();
                itemScreenshot.Source = iconImage;
                downloadsLabel.Text = "Сваляния: " + storeItemDownloads;
                allPostsPanel.Children.Add(storeDetailsGrid);
            }
            else
            {
                TextBlock noNotifications = new TextBlock();
                noNotifications.Text = "Проектът не е качен в магазина";
                noNotifications.FontFamily = new FontFamily("Segoe UI Light");
                noNotifications.FontSize = 36;
                Color moreForeground = new Color();
                moreForeground.B = 30;
                moreForeground.R = 30;
                moreForeground.G = 30;
                moreForeground.A = 255;
                Thickness margin = new Thickness(0, 100, 0, 0);
                noNotifications.Margin = margin;
                noNotifications.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                noNotifications.Foreground = new SolidColorBrush(moreForeground);
                noNotifications.TextTrimming = TextTrimming.CharacterEllipsis;
                allPostsPanel.Children.Add(noNotifications);
                allPostsPanel.Children.Add(storeUploadButton);

            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        private string mainServerUrl = "";
        bool isOnStore = false;
        private string storeItemName = "";
        private string storeItemDescription = "";
        private string storeItemDownloads = "";

        //Load the data for the item
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            StreamReader usernameReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            username = usernameReader.ReadToEnd();
            reader.Close();
            WebClient webClient = new WebClient();
            string url = mainServerUrl + "isOnStore.php";
            NameValueCollection names = new NameValueCollection();
            names["project"] = currentProject;
            byte[] resposne = webClient.UploadValues(url, "POST", names);
            if (Encoding.UTF8.GetString(resposne) == "1")
            {
                isOnStore = true;
                WebClient storeClient = new WebClient();
                string onStoreUrl = mainServerUrl + "getStoreItemId.php";
                byte[] idResponse = storeClient.UploadValues(onStoreUrl, "POST", names);
                storeItemName = Encoding.UTF8.GetString(idResponse);
                string descUrl = mainServerUrl + "getStoreDescription.php";
                NameValueCollection entryName = new NameValueCollection();
                entryName["name"] = storeItemName;
                byte[] descriptionResponse = storeClient.UploadValues(descUrl, "POST", entryName);
                storeItemDescription = Encoding.UTF8.GetString(descriptionResponse);
                byte[] downloadsResponse = storeClient.UploadValues(mainServerUrl + "storeItemDownloads.php", "POST", entryName);
                storeItemDownloads = Encoding.UTF8.GetString(downloadsResponse);
            }
            else
            {
                isOnStore = false;
            }
        }

        //Open the upload to store window
        private void storeUploadButton_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            string descriptionUrl = mainServerUrl + "getProjectDescription.php";
            NameValueCollection projectNameValues = new NameValueCollection();
            projectNameValues["project"] = currentProject;
            byte[] responseBytes = webClient.UploadValues(descriptionUrl, "POST", projectNameValues);
            string description = Encoding.UTF8.GetString(responseBytes);
            string getCategoryUrl = mainServerUrl + "getProjectCategory.php";
            byte[] projectCategoryResponse = webClient.UploadValues(getCategoryUrl, "POST", projectNameValues);
            int projectCategoryIndex = int.Parse(Encoding.UTF8.GetString(projectCategoryResponse));
            uploadToStore storeUpload = new uploadToStore(currentProject, description, projectCategoryIndex);
            bool? storeUploadResult = storeUpload.ShowDialog();
            if (storeUploadResult == true)
            {
                NavigationService.Navigate(new projectStore(currentProject));
            }
        }

        //Open the screenshot in big window
        private void itemScreenshot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            screenshotViewer view = new screenshotViewer(itemScreenshot.Source, storeItemName);
            view.ShowDialog();
        }

        //Call the download function
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            downloadItem(storeItemName);
        }

        //Remove this item form the store
        private void deleteFromStore(string itemName)
        {
             WebClient client = new WebClient();
             string deleteUrl = mainServerUrl + "removeFromStore.php";
             NameValueCollection itemNameValue = new NameValueCollection();
             itemNameValue["name"] = itemName;
             byte[] response = client.UploadValues(deleteUrl, "POST", itemNameValue);
        }

        BackgroundWorker storeRemoveWork = new BackgroundWorker();

        //Start the item removing
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да премахнете този елемент от магазина?");
            bool? result = conf.ShowDialog();
            if (result == true)
            {
                storeRemoveWork.DoWork += storeRemoveWork_DoWork;
                storeRemoveWork.RunWorkerCompleted += storeRemoveWork_RunWorkerCompleted;
                loader.Visibility = System.Windows.Visibility.Visible;
                storeRemoveWork.RunWorkerAsync(); 
            }
        }

        //Relod the page
        void storeRemoveWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            NavigationService.Navigate(new projectStore(currentProject));
        }

        //Call the delete item function
        void storeRemoveWork_DoWork(object sender, DoWorkEventArgs e)
        {
            deleteFromStore(storeItemName);
        }

        //Open the settings window for the current item
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            storeItemSettings settings = new storeItemSettings(storeItemName);
            settings.ShowDialog();
            NavigationService.Navigate(new projectStore(currentProject));
        }
    }
}
