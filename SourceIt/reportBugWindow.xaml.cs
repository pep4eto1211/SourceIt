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

namespace SourceIt
{
    /// <summary>
    /// Window for reporting bug and problems
    /// </summary>
    public partial class reportBugWindow : Window
    {
        public reportBugWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private string mainServerUrl = "";

        //Send the bug report
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loader.Visibility = System.Windows.Visibility.Visible;
            StreamReader reader = new StreamReader(@"serverAddress.sid");
            mainServerUrl = reader.ReadToEnd();
            reader.Close();
            WebClient client = new WebClient();
            NameValueCollection errorDetails = new NameValueCollection();
            errorDetails["message"] = errorDescription.Text;
            errorDetails["source"] = "User report";
            errorDetails["code"] = "No code provided";
            errorDetails["file"] = "No file provided";
            string reportUrl = mainServerUrl + "reportError.php";
            client.UploadValues(reportUrl, "POST", errorDetails);
            this.Close();
        }
    }
}
