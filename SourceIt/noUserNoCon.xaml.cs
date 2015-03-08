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
using System.Net;
using System.IO;

namespace SourceIt
{
    /// <summary>
    /// Window wich tells you that right now there is no hope for you to use the app
    /// </summary>
    public partial class noUserNoCon : Window
    {
        public noUserNoCon()
        {
            InitializeComponent();
        }

        public string mainServerUrl = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //User decides to close the app
            this.DialogResult = false;
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            //Give it one more shot
            tryReconnect();
        }

        //The 'one more shot'
        void tryReconnect()
        {
            try
            {
                WebClient checkCon = new WebClient();
                string url = mainServerUrl + "checkConnection.php";
                string response = checkCon.DownloadString(url);
                if (response == "OK")
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }
            catch (System.Net.WebException)
            {
               
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Read the server url
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
        }

    }
}
