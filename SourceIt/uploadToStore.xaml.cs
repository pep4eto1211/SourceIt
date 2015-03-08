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
    /// Window for uploading new item to the store
    /// </summary>
    public partial class uploadToStore : Window
    {
        public uploadToStore(string projectName, string projectDescription, int categoryIndex)
        {
            InitializeComponent();
            name = projectName;
            description = projectDescription;
            category = categoryIndex;
            currentProject = projectName;
        }

        private string name = "";
        private string description = "";
        private int category = -1;
        private string currentProject = "";

        private string[] uploadFiles;
        private string screenshot = "";
        private string icon = "";

        BackgroundWorker uploadWork = new BackgroundWorker();

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Start the upload background worker
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loader.Visibility = System.Windows.Visibility.Visible;
            description = projectDescription.Text;
            name = projectNameBox.Text;
            category = projectCategory.SelectedIndex;
            if (projectDescription.Text != "" && projectNameBox.Text != "" && projectCategory.SelectedIndex != -1 && selectedFilesBox.Text != "" && selectedScreenshotBox.Text != "" && selectedIconBox.Text != "")
            {
                uploadWork.DoWork += uploadWork_DoWork;
                uploadWork.RunWorkerCompleted += uploadWork_RunWorkerCompleted;
                uploadWork.RunWorkerAsync();
            }
            else
            {
                loader.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private string mainServerUrl = "";
        private string tempDir = "";
        private string archDir = "";

        //Finish the uploading
        void uploadWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ZipFile.CreateFromDirectory(tempDir, archDir);
            Directory.Delete(tempDir, true);
            WebClient client = new WebClient();
            StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            string owner = reader.ReadToEnd();
            reader.Close();
            if (currentProject == "")
            {
                currentProject = "no";
            }
            byte[] response = client.UploadFile(mainServerUrl + "uploadToStore.php?name=" + projectNameBox.Text + "&description=" + projectDescription.Text + "&category=" + projectCategory.SelectedIndex.ToString() + "&owner=" + owner + "&project=" + currentProject, archDir);
            WebClient iconClient = new WebClient();
            byte[] iconResponse = iconClient.UploadFile(mainServerUrl + "uploadStoreIcon.php?name=" + projectNameBox.Text, selectedIconBox.Text);
            WebClient screenClient = new WebClient();
            byte[] screenResponse = screenClient.UploadFile(mainServerUrl + "uploadStoreScreen.php?name=" + projectNameBox.Text, selectedScreenshotBox.Text);
            File.Delete(archDir);
            this.DialogResult = true;
            this.Close();
        }

        //Start the uploading
        void uploadWork_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
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
        }

        //Open file dialog for an screenshot
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Title = "Изберете скрийншот";
            dialog.Filter = "PNG Files|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                screenshot = dialog.FileName;
                selectedScreenshotBox.Text = dialog.FileName;
            }
        }

        //Open file dialog for an icon
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Title = "Изберете икона";
            dialog.Filter = "PNG Files|*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                icon = dialog.FileName;
                selectedIconBox.Text = dialog.FileName;
            }
        }

        //Open files dialog for the item files
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "Изберете файловете за качване";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uploadFiles = dialog.FileNames;
                selectedFilesBox.Text = dialog.FileName;
            }
        }

        //Show data if available
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            projectNameBox.Text = name;
            projectDescription.Text = description;
            if (category != -1)
            {
                projectCategory.SelectedIndex = category;
            }
        }
    }
}
