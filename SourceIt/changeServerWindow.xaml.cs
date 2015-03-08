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
using System.Collections.Specialized;

namespace SourceIt
{
    /// <summary>
    /// Window for changing the main server address
    /// </summary>
    public partial class changeServerWindow : Window
    {
        public changeServerWindow()
        {
            InitializeComponent();
        }

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Change the address, stored in the local file and restart the app
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (serverAddressBox.Text != "")
                {
                    using (StreamWriter sw = new StreamWriter(@"serverAddress.sid"))
                    {
                        sw.Write(serverAddressBox.Text);
                    }
                }
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderPath += @"\SourceIt\";
                Directory.Delete(folderPath, true);
                System.Windows.Forms.Application.Restart();
                Application.Current.Shutdown();
            }
            catch (Exception er)
            {
                errorWindow re = new errorWindow("Настъпи неочаквана грешка!");
                Application.Current.Shutdown();
            }
        }
    }
}
