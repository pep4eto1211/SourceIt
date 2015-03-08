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
    /// Page for showing all notifications
    /// </summary>
    public partial class notificationsPage : Page
    {
        public notificationsPage(string currentUser)
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

        BackgroundWorker initialWorker = new BackgroundWorker();
        private string mainServerUrl = "";

        //Start the initial background worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            initialWorker.DoWork += initialWorker_DoWork;
            initialWorker.RunWorkerCompleted += initialWorker_RunWorkerCompleted;
            initialWorker.RunWorkerAsync();
        }

        //Delete the selected notification
        private void deleteNotification(string id)
        {
            WebClient webClient = new System.Net.WebClient();
            string deleteUrl = mainServerUrl + "deleteNotification.php";
            NameValueCollection deleteValues = new NameValueCollection();
            deleteValues["id"] = id;
            byte[] deleteResponse = webClient.UploadValues(deleteUrl, "POST", deleteValues);
        }

        //Show all notifications
        void initialWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (allNotifications.Count > 0)
            {
                foreach (var oneNotification in allNotifications)
                {
                    singleNotification theNotification = new singleNotification(oneNotification);
                    theNotification.deleteNotificationPressed += (object senderr, EventArgs ee) =>
                    {
                        confirmWindow conf = new confirmWindow("Are you sure you want to delete this notification?");
                        if (conf.ShowDialog() == true)
                        {
                            deleteNotification(oneNotification.id);
                            NavigationService.Navigate(new notificationsPage(username));
                        }
                    };
                    notificationsPanel.Children.Add(theNotification);
                } 
            }
            else
            {
                TextBlock noNotifications = new TextBlock();
                noNotifications.Text = "Няма известия";
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
                notificationsPanel.Children.Add(noNotifications);
            }
            loader.Visibility = System.Windows.Visibility.Hidden;
        }

        List<Notification> allNotifications = new List<Notification>();

        //Load all notifications
        void initialWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient webClient = new WebClient();
            string getNotificationsUrl = mainServerUrl + "getNotifications.php";
            NameValueCollection getNotificationsValues = new NameValueCollection();
            getNotificationsValues["username"] = username;
            byte[] response = webClient.UploadValues(getNotificationsUrl, "POST", getNotificationsValues);
            string notificationsRaw = Encoding.UTF8.GetString(response);
            if (notificationsRaw.Length>0)
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
        }
    }
}
