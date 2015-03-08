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
    /// Page for setting deadline for the project
    /// </summary>
    public partial class setDeadlinePage : Page
    {
        public setDeadlinePage(string project)
        {
            InitializeComponent();
            currentProject = project;
        }

        private string currentProject = "";

        //Go back to the dashboard
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new projectDashboard(currentProject));
        }

        BackgroundWorker initialLoading = new BackgroundWorker();

        //Start the initial worker
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            initialLoading.DoWork += initialLoading_DoWork;
            initialLoading.RunWorkerCompleted += initialLoading_RunWorkerCompleted;
            initialLoading.RunWorkerAsync();
        }

        private string mainServerUrl = "";

        //Show the current deadline
        void initialLoading_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            currentDeadlineBox.Text = currentDeadline;
            hider.Visibility = System.Windows.Visibility.Hidden;
        }

        string currentDeadline = "";

        //Load the current deadline
        void initialLoading_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            string getDeadlineUrl = mainServerUrl + "getDeadline.php";
            WebClient webClient = new WebClient();
            NameValueCollection getDeadlineValues = new NameValueCollection();
            getDeadlineValues["project"] = currentProject;
            byte[] response = webClient.UploadValues(getDeadlineUrl, "POST", getDeadlineValues);
            string returnedDeadline = Encoding.UTF8.GetString(response);
            if (returnedDeadline == "0")
            {
                currentDeadline = "Краен срок все още не е зададен";
            }
            else
            {
                currentDeadline = returnedDeadline;
            }
        }

        BackgroundWorker setDeadlineWorker = new BackgroundWorker();
        DateTime? selectedDate;
        string selectedDay = "";
        string selectedMonth = "";
        string selectedYear = "";

        //Start the background worker for the current deadline
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (deadlineBox.SelectedDate != null)
            {
                setDeadlineWorker.DoWork += setDeadlineWorker_DoWork;
                setDeadlineWorker.RunWorkerCompleted += setDeadlineWorker_RunWorkerCompleted;
                setDeadlineWorker.RunWorkerAsync();
                selectedDate = deadlineBox.SelectedDate;
                selectedDay = selectedDate.Value.Day.ToString();
                selectedMonth = selectedDate.Value.Month.ToString();
                selectedYear = selectedDate.Value.Year.ToString();
            }
            else
            {
                
            }
        }

        public event EventHandler deadlineChanged;

        //Fire the deadline changed event
        private void deadlineChangedEvent(EventArgs e)
        {
            deadlineChanged(this, e);
        }

        //Go back to the dashboard and call the deadline changed function
        void setDeadlineWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show(responseString);
            deadlineChangedEvent(e);
            NavigationService.Navigate(new projectDashboard(currentProject));
        }

        //private string responseString = "";

        //Set the new deadline
        void setDeadlineWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient webClient = new WebClient();
            string setDeadlineUrl = mainServerUrl + "setDeadline.php";
            string dateToPass = selectedDay + "." + selectedMonth + "." + selectedYear;
            NameValueCollection setDeadlineValues = new NameValueCollection();
            setDeadlineValues["deadline"] = dateToPass;
            setDeadlineValues["project"] = currentProject;
            byte[] response = webClient.UploadValues(setDeadlineUrl, "POST", setDeadlineValues);
            //responseString = Encoding.UTF8.GetString(response); 
        }

        //Go back to the dasboard
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new projectDashboard(currentProject));
        }

        BackgroundWorker resetDeadlineWorker = new BackgroundWorker();

        //Start the reset deadline background worker
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resetDeadlineWorker.DoWork += resetDeadlineWorker_DoWork;
            resetDeadlineWorker.RunWorkerCompleted += resetDeadlineWorker_RunWorkerCompleted;
            resetDeadlineWorker.RunWorkerAsync();
        }

        //Go back to the dasboard and fire the deadline changed event
        void resetDeadlineWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show(responseString);
            deadlineChangedEvent(e);
            NavigationService.Navigate(new projectDashboard(currentProject));
        }

        //Reset the current deadline
        void resetDeadlineWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient webClient = new WebClient();
            string setDeadlineUrl = mainServerUrl + "setDeadline.php";
            NameValueCollection setDeadlineValues = new NameValueCollection();
            setDeadlineValues["deadline"] = "0";
            setDeadlineValues["project"] = currentProject;
            byte[] response = webClient.UploadValues(setDeadlineUrl, "POST", setDeadlineValues);
        }
    }
}
