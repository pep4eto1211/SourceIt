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
using System.IO.Compression;

namespace SourceIt
{
    /// <summary>
    /// The store service
    /// </summary>
    public partial class store : Page
    {
        public store(string currentUser)
        {
            InitializeComponent();
            username = currentUser;
        }

        private string username = "";

        //Go back to the startup page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartupPage(username));
        }

        //Deal with the serch box placeholder
        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Търсене")
            {
                searchBox.Text = "";
                BrushConverter foregroundBrush = new BrushConverter();
                searchBox.Foreground = (Brush)foregroundBrush.ConvertFrom("#FF303030");
            }
        }
        //Deal with the serch box placeholder once again
        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Търсене";
                BrushConverter foregroundBrush = new BrushConverter();
                searchBox.Foreground = (Brush)foregroundBrush.ConvertFrom("#FFA6A6A6");
            }
        }

        //Remove item from the store
        private void deleteFromStore(string itemName)
        {
            WebClient client = new WebClient();
            string deleteUrl = mainServerUrl + "removeFromStore.php";
            NameValueCollection itemNameValue = new NameValueCollection();
            itemNameValue["name"] = itemName;
            byte[] response = client.UploadValues(deleteUrl, "POST", itemNameValue);
        }

        BackgroundWorker searchWork = new BackgroundWorker();

        //Show the info abut single item
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            itemInfoGrid.Visibility = System.Windows.Visibility.Hidden;
            currentOpen = "";
            if (searchBox.Text != "" && searchBox.Text != "Търсене")
            {
                currentItems.Clear();
                storeItemsPanel.Children.Clear();
                Loader.Visibility = System.Windows.Visibility.Visible;
                searchWork.DoWork += changeTabWork_DoWork;
                searchWork.RunWorkerCompleted += (object sendere, RunWorkerCompletedEventArgs ee) =>
                {
                    storeItemsPanel.Children.Clear();
                    List<storeItem> searchField = new List<storeItem>(currentItems);
                    currentItems.Clear();
                    string searchPattern = searchBox.Text;
                    string[] searchTags = searchPattern.Split(' ');
                    foreach (var singleListItem in searchField)
                    {
                        foreach (var item in searchTags)
                        {
                            if (singleListItem.name.ToLower().Contains(item.ToLower()) || singleListItem.description.ToLower().Contains(item.ToLower()))
                            {
                                if (!currentItems.Contains(singleListItem))
                                {
                                    currentItems.Add(singleListItem);
                                }
                            }
                        }
                    }
                    storeItemsPanel.Children.Add(searchResultsGrid);
                    runWorkerCompletedFunction();
                };
                searchWork.RunWorkerAsync();
            }
            else
            {
                resetSearch();
            }
        }

        //Reset search
        private void resetSearch()
        {
            searchBox.Text = "Търсене";
            changeTabInit();
        }

        //Unselect all tabs
        private void normalizeButtons()
        {
            Thickness border = new Thickness(0, 0, 0, 0);
            newestTab.BorderThickness = border;
            allTab.BorderThickness = border;
            mostDownloadsTab.BorderThickness = border;
            mineTab.BorderThickness = border;
            newestTabLabel.FontSize = 18;
            allTabLabel.FontSize = 18;
            mostDownloadsTabLabel.FontSize = 18;
            mineTabLabel.FontSize = 18;
        }

        //Select tab
        private void changeTab(Button currentTab, Label currentLabel)
        {
            normalizeButtons();
            Thickness border = new Thickness(1, 0, 1, 0);
            currentTab.BorderThickness = border;
            currentLabel.FontSize = 20;
        }

        List<storeItem> currentItems = new List<storeItem>();
        private int selectedTab = 1;
        private string mainServerUrl = "";

        //Load items data
        private void doWorkFunction()
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            string requestUrl = mainServerUrl;
            switch (selectedTab)
            {
                case 1:
                    requestUrl += "getNewestStore.php";
                    break;
                case 2:
                    requestUrl += "getMostDownloadsStore.php";
                    break;
                case 3:
                    requestUrl += "getAllStore.php";
                    break;
                case 4:
                    requestUrl += "getMineStore.php";
                    break;
            }
            if (selectedTab != 4)
            {
                bool isEmpty = false;
                string response = client.DownloadString(requestUrl);
                if (response.Length > 0)
                {
                    response = response.Remove(response.Length - 1);
                }
                else
                {
                    isEmpty = true;
                }
                string[] namesArray = response.Split(',');
                foreach (string singleName in namesArray)
                {
                    storeItem singleItemObject = new storeItem(singleName);
                    singleItemObject.loadData();
                    currentItems.Add(singleItemObject);
                }
                if (isEmpty)
                {
                    currentItems.RemoveAt(0);
                }
            }
            else
            {
                bool isEmpty = false;
                NameValueCollection userValue = new NameValueCollection();
                userValue["user"] = username;
                byte[] response = client.UploadValues(requestUrl, "POST", userValue);
                string rawResponse = Encoding.UTF8.GetString(response);
                if (rawResponse.Length > 0)
                {
                    rawResponse = rawResponse.Remove(rawResponse.Length - 1);
                }
                else
                {
                    isEmpty = true;
                }
                string[] namesArray = rawResponse.Split(',');
                foreach (string singleName in namesArray)
                {
                    storeItem singleItemObject = new storeItem(singleName);
                    singleItemObject.loadData();
                    currentItems.Add(singleItemObject);
                }
                if (isEmpty)
                {
                    currentItems.RemoveAt(0);
                }
            }
        }

        //Download selected item
        private void downloadItem(string itemName)
        {
            string selectedDestination = "";
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Loader.Visibility = System.Windows.Visibility.Visible;
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
                Loader.Visibility = System.Windows.Visibility.Hidden;
            }     
        }

        //Show loaded items
        private void runWorkerCompletedFunction()
        {
            if (selectedTab == 4)
            {
                storeItemsPanel.Children.Add(storeUploadButton);
                foreach (var singleListItem in currentItems)
                {
                    myStoreItemControl appControl = new myStoreItemControl(singleListItem);
                    appControl.downloadItem += (object sender, EventArgs e) =>
                    {
                        downloadItem(singleListItem.name);
                    };
                    appControl.viewItemInfo += (object sender, EventArgs e) =>
                    {
                        currentOpen = singleListItem.name;
                        itemNameLabel.Text = singleListItem.name;
                        itemDescriptionLabel.Text = singleListItem.description;
                        BitmapImage iconImage = new BitmapImage();
                        iconImage.BeginInit();
                        iconImage.UriSource = new Uri(mainServerUrl + "Store/" + singleListItem.name + "/screenshot.png");
                        iconImage.CacheOption = BitmapCacheOption.None;
                        iconImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                        iconImage.EndInit();
                        itemScreenshot.Source = iconImage;
                        itemInfoGrid.Visibility = System.Windows.Visibility.Visible;
                    };
                    appControl.deleteMyItem += (object sender, EventArgs e) =>
                    {
                        confirmWindow conf = new confirmWindow("Сигурни ли сте, че искате да премахнете този елемент от магазина?");
                        bool? result = conf.ShowDialog();
                        if (result == true)
                        {
                            deleteFromStore(singleListItem.name);
                            changeTabInit();
                        }
                    };
                    appControl.editItemInfo += (object sender, EventArgs e) =>
                    {
                        storeItemSettings settings = new storeItemSettings(singleListItem.name);
                        settings.ShowDialog();
                        changeTabInit();
                    };
                    storeItemsPanel.Children.Add(appControl);
                }

                if (currentItems.Count == 0)
                {
                    storeItemsPanel.Children.Add(emptyLabel);
                }
                Loader.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                foreach (var singleListItem in currentItems)
                {
                    singleStoreItemControl appControl = new singleStoreItemControl(singleListItem);
                    appControl.downloadItem += (object sender, EventArgs e) =>
                    {
                        downloadItem(singleListItem.name);
                    };
                    appControl.viewItemInfo += (object sender, EventArgs e) =>
                    {
                        currentOpen = singleListItem.name;
                        itemNameLabel.Text = singleListItem.name;
                        itemDescriptionLabel.Text = singleListItem.description;
                        BitmapImage iconImage = new BitmapImage();
                        iconImage.BeginInit();
                        iconImage.UriSource = new Uri(mainServerUrl + "Store/" + singleListItem.name + "/screenshot.png");
                        iconImage.CacheOption = BitmapCacheOption.None;
                        iconImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                        iconImage.EndInit();
                        itemScreenshot.Source = iconImage;
                        itemInfoGrid.Visibility = System.Windows.Visibility.Visible;
                    };
                    storeItemsPanel.Children.Add(appControl);
                }

                if (currentItems.Count == 0)
                {
                    storeItemsPanel.Children.Add(emptyLabel);
                }
                Loader.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        BackgroundWorker initialWork = new BackgroundWorker();
        BackgroundWorker changeTabWork = new BackgroundWorker();

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            storeItemsPanel.Children.Clear();
            changeTab(newestTab, newestTabLabel);
            selectedTab = 1;
            initialWork.DoWork += initialWork_DoWork;
            initialWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            changeTabWork.DoWork += changeTabWork_DoWork;
            changeTabWork.RunWorkerCompleted += initialWork_RunWorkerCompleted;
            initialWork.RunWorkerAsync();
        }

        //Make request to the proper page and load the items
        void changeTabWork_DoWork(object sender, DoWorkEventArgs e)
        {
            currentItems.Clear();
            WebClient client = new WebClient();
            string requestUrl = mainServerUrl;
            switch (selectedTab)
            {
                case 1:
                    requestUrl += "getNewestStore.php";
                    break;
                case 2:
                    requestUrl += "getMostDownloadsStore.php";
                    break;
                case 3:
                    requestUrl += "getAllStore.php";
                    break;
                case 4:
                    requestUrl += "getMineStore.php";
                    break;
            }
            if (selectedTab != 4)
            {
                bool isEmpty = false;
                string response = client.DownloadString(requestUrl);
                if (response.Length > 0)
                {
                    response = response.Remove(response.Length - 1);
                }
                else
                {
                    isEmpty = true;
                }
                string[] namesArray = response.Split(',');
                foreach (string singleName in namesArray)
                {
                    storeItem singleItemObject = new storeItem(singleName);
                    singleItemObject.loadData();
                    currentItems.Add(singleItemObject);
                }
                if (isEmpty)
                {
                    currentItems.RemoveAt(0);
                }
            }
            else
            {
                bool isEmpty = false;
                NameValueCollection userValue = new NameValueCollection();
                userValue["user"] = username;
                byte[] response = client.UploadValues(requestUrl, "POST", userValue);
                string rawResponse = Encoding.UTF8.GetString(response);
                if (rawResponse.Length > 0)
                {
                    rawResponse = rawResponse.Remove(rawResponse.Length - 1);
                }
                else
                {
                    isEmpty = true;
                }
                string[] namesArray = rawResponse.Split(',');
                foreach (string singleName in namesArray)
                {
                    storeItem singleItemObject = new storeItem(singleName);
                    singleItemObject.loadData();
                    currentItems.Add(singleItemObject);
                }
                if (isEmpty)
                {
                    currentItems.RemoveAt(0);
                }
            }
        }

        //Calling runworker completed function
        void initialWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            runWorkerCompletedFunction();
        }

        //Calling the dowork function
        void initialWork_DoWork(object sender, DoWorkEventArgs e)
        {
            doWorkFunction();
        }

        //Start the change tab background worker
        private void changeTabInit()
        {
            Loader.Visibility = System.Windows.Visibility.Visible;
            storeItemsPanel.Children.Clear();
            currentItems.Clear();
            changeTabWork.RunWorkerAsync();
        }

        //Change tabs
        private void newestTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(newestTab, newestTabLabel);
            selectedTab = 1;
            changeTabInit();
        }

        private void mostDownloadsTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(mostDownloadsTab, mostDownloadsTabLabel);
            selectedTab = 2;
            changeTabInit();
        }

        private void allTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(allTab, allTabLabel);
            selectedTab = 3;
            changeTabInit();
        }

        private void mineTab_Click(object sender, RoutedEventArgs e)
        {
            changeTab(mineTab, mineTabLabel);
            selectedTab = 4;
            changeTabInit();
        }

        private string currentOpen = "";

        //Download selected item
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (currentOpen != "")
            {
                downloadItem(currentOpen);
            }
        }

        //Show info about selected store item
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            itemInfoGrid.Visibility = System.Windows.Visibility.Hidden;
            currentOpen = "";
        }

        //Show the screenshot in big window
        private void itemScreenshot_MouseDown(object sender, MouseButtonEventArgs e)
        {
            screenshotViewer view = new screenshotViewer(itemScreenshot.Source, currentOpen);
            view.ShowDialog();
        }

        //Detect 'Enter' key in the search box
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click_1(sender, new RoutedEventArgs());
            }
        }

        //Reset the search
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            resetSearch();
        }

        //Open the upload to the store window
        private void storeUploadButton_Click(object sender, RoutedEventArgs e)
        {
            uploadToStore storeUpload = new uploadToStore("", "", -1);
            bool? storeUploadResult = storeUpload.ShowDialog();
            if (storeUploadResult == true)
            {
                resetSearch();
            }
        }
    }
}
