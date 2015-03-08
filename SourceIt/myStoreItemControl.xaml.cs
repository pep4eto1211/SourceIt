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

namespace SourceIt
{
    /// <summary>
    /// User control for store item uploaded by you
    /// </summary>
    public partial class myStoreItemControl : UserControl
    {
        public myStoreItemControl(storeItem item)
        {
            InitializeComponent();
            currentItem = item;
        }

        storeItem currentItem;
        private string mainServerUrl = "";

        //show all the data for the store item
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            itemNameLabel.Text = currentItem.name;
            itemNameLabel.ToolTip = currentItem.name;
            itemDescriptionLabel.Text = currentItem.description;
            itemDescriptionLabel.ToolTip = currentItem.description;
            BitmapImage iconImage = new BitmapImage();
            iconImage.BeginInit();
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            NameValueCollection entryName = new NameValueCollection();
            entryName["name"] = currentItem.name;
            byte[] downloadsResponse = client.UploadValues(mainServerUrl + "storeItemDownloads.php", "POST", entryName);
            downloadsLabel.Text += " " + Encoding.UTF8.GetString(downloadsResponse);
            iconImage.UriSource = new Uri(mainServerUrl + "Store/" + currentItem.name + "/icon.png");
            iconImage.CacheOption = BitmapCacheOption.None;
            iconImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            iconImage.EndInit();
            itemIcon.Source = iconImage;
        }

        public event EventHandler downloadItem;
        public event EventHandler viewItemInfo;
        public event EventHandler deleteMyItem;
        public event EventHandler editItemInfo;

        //Fire events
        private void editItemInfoEvent(EventArgs e)
        {
            editItemInfo(this, e);
        }

        private void downloadItemEvent(EventArgs e)
        {
            downloadItem(this, e);
        }

        private void deleteMyItemEvent(EventArgs e)
        {
            deleteMyItem(this, e);
        }

        private void viewItemInfoEvent(EventArgs e)
        {
            viewItemInfo(this, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            downloadItemEvent(e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewItemInfoEvent(e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            deleteMyItemEvent(e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            editItemInfoEvent(e);
        }
    }
}
