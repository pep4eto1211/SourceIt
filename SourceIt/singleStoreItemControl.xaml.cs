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
    /// User control for single item at the store
    /// </summary>
    public partial class singleStoreItemControl : UserControl
    {
        public singleStoreItemControl(storeItem item)
        {
            InitializeComponent();
            currentItem = item;
        }

        storeItem currentItem;
        private string mainServerUrl = "";

        //Show the data for the item
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
            iconImage.UriSource = new Uri(mainServerUrl + "Store/" + currentItem.name + "/icon.png");
            iconImage.CacheOption = BitmapCacheOption.None;
            iconImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            iconImage.EndInit();
            itemIcon.Source = iconImage;
        }

        public event EventHandler downloadItem;
        public event EventHandler viewItemInfo;

        //Fire events
        private void downloadItemEvent(EventArgs e)
        {
            downloadItem(this, e);
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
    }
}
