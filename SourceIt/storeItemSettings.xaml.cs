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
using System.IO.Compression;

namespace SourceIt
{
    /// <summary>
    /// Window for setting up single store item
    /// </summary>
    public partial class storeItemSettings : Window
    {
        public storeItemSettings(string itemName)
        {
            InitializeComponent();
            currentItem = itemName;
        }

        private string currentItem = "";
        private string currentDescription = "";
        private int currentCategory = -1;
        private bool screenshotChanged = false;
        private bool iconChanged = false;
        private bool filesChanged = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        BackgroundWorker loadData = new BackgroundWorker();

        //Start the initial background worker
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            projectNameBox.Text = currentItem;
            loadData.DoWork += loadData_DoWork;
            loadData.RunWorkerCompleted += loadData_RunWorkerCompleted;
            loadData.RunWorkerAsync();
        }

        //Show current item info
        void loadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            projectDescription.Text = currentDescription;
            projectCategory.SelectedIndex = currentCategory;
            selectedFilesBox.Text = currentItem;
            selectedIconBox.Text = "Icon";
            selectedScreenshotBox.Text = "Screenshot";
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        private string mainServerUrl = "";

        //Load current item info
        void loadData_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient storeClient = new WebClient();
            string descUrl = mainServerUrl + "getStoreDescription.php";
            NameValueCollection entryName = new NameValueCollection();
            entryName["name"] = currentItem;
            byte[] descriptionResponse = storeClient.UploadValues(descUrl, "POST", entryName);
            currentDescription = Encoding.UTF8.GetString(descriptionResponse);
            byte[] categoryIndexByte = storeClient.UploadValues(mainServerUrl + "storeItemCategory.php", "POST", entryName);
            currentCategory = int.Parse(Encoding.UTF8.GetString(categoryIndexByte));

        }

        BackgroundWorker updateInfoWork = new BackgroundWorker();

        private string selectedDescription = "";
        private string selectedCategory = "";

        //Start the update info background worker
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (projectDescription.Text != "")
            {
                loader.Visibility = System.Windows.Visibility.Visible;
                selectedDescription = projectDescription.Text;
                selectedCategory = projectCategory.SelectedIndex.ToString();
                updateInfoWork.RunWorkerCompleted += updateInfoWork_RunWorkerCompleted;
                updateInfoWork.DoWork += updateInfoWork_DoWork;
                updateInfoWork.RunWorkerAsync();
            }
        }

        private string archDir = "";
        private string tempDir = "";
        private string[] uploadFiles;

        //Update the info about the item
        void updateInfoWork_DoWork(object sender, DoWorkEventArgs e)
        {
            //Update store entry data
            WebClient client = new WebClient();
            string updateInfoUrl = mainServerUrl + "updateStoreInfo.php";
            NameValueCollection newDataValues = new NameValueCollection();
            newDataValues["description"] = selectedDescription;
            newDataValues["category"] = selectedCategory;
            newDataValues["name"] = currentItem;
            byte[] response = client.UploadValues(updateInfoUrl, "POST", newDataValues);
        }

        //Some more info updating here
        void updateInfoWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Create .sii file and upload it to store if new files are chosen
            if (filesChanged)
            {
                archDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\Temp\storeUpload.sii";
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\Temp\StoreUploadFolder\"))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\Temp\StoreUploadFolder\");
                }
                tempDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\Temp\StoreUploadFolder\";
                foreach (var item in uploadFiles)
                {
                    string fileName = item.Substring(item.LastIndexOf(@"\") + 1);
                    File.Copy(item, tempDir + fileName);
                }
                ZipFile.CreateFromDirectory(tempDir, archDir);
                Directory.Delete(tempDir, true);
                WebClient client = new WebClient();
                byte[] response = client.UploadFile(mainServerUrl + "updateToStore.php?name=" + projectNameBox.Text, archDir);
                WebClient iconClient = new WebClient();
                File.Delete(archDir);
            }

            WebClient imageClient = new WebClient();
            //Update store entry files if chosen
            if (iconChanged)
            {
                byte[] responseUpdate = imageClient.UploadFile(mainServerUrl + "updateIcon.php?name=" + currentItem, selectedIconBox.Text);
            }
            if (screenshotChanged)
            {
                byte[] responseUpdate2 = imageClient.UploadFile(mainServerUrl + "updateScreenshot.php?name=" + currentItem, selectedScreenshotBox.Text);
            }
            this.Close();
        }

        //Select new files for the store item
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Изберете файловете за качване";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uploadFiles = dialog.FileNames;
                selectedFilesBox.Text = dialog.FileName;
                filesChanged = true;
            }
        }

        //Select a new icon for the store item
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Title = "Изберете икона";
            dialog.Filter = "PNG Files|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconChanged = true;
                selectedIconBox.Text = dialog.FileName;
            }
        }

        //Select a new screenshot for the store item
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Title = "Изберете скрийншот";
            dialog.Filter = "PNG Files|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                screenshotChanged = true;
                selectedScreenshotBox.Text = dialog.FileName;
            }
        }
    }
}
