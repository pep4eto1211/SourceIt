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

namespace SourceIt
{
    /// <summary>
    /// App settings page
    /// </summary>
    public partial class settings : Page
    {
        public settings(string currentUser)
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

        //Log out of the profile
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderPath += @"\SourceIt\";
                Directory.Delete(folderPath, true);
                System.Windows.Forms.Application.Restart();
                Application.Current.Shutdown();
            }
            catch(Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
            }
        }

        BackgroundWorker initialWorker = new BackgroundWorker();
        private string mainServerUrl = "";

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            initialWorker.DoWork += initialWorker_DoWork;
            initialWorker.RunWorkerCompleted += initialWorker_RunWorkerCompleted;
            initialWorker.RunWorkerAsync();
        }

        //Show the server and the username
        private void initialWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mainServerBox.Text = mainServerUrl;
            usernameBox.Text = username;
        }

        //Load the server and the username
        private void initialWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            StreamReader reader1 = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SourceIt\username.sid");
            string readed = reader1.ReadToEnd();
            reader1.Close();
            if (readed != "")
            {
                username = readed;
            }
        }

        //Change the server address
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mainServerBox.Text != "")
                {
                    using (StreamWriter sw = new StreamWriter(@"serverAddress.sid"))
                    {
                        sw.Write(mainServerBox.Text);
                    }
                }
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderPath += @"\SourceIt\";
                Directory.Delete(folderPath, true);
                System.Windows.Forms.Application.Restart();
                Application.Current.Shutdown();
            }
            catch(Exception)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
            }
        }

        //Open the report bug window
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            reportBugWindow rep = new reportBugWindow();
            rep.ShowDialog();
        }
    }
}
