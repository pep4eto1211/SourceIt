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

namespace SourceIt
{
    /// <summary>
    /// Window used for confirmation of various actions in the app
    /// </summary>
    public partial class confirmWindow : Window
    {

        public string theText = "";

        public confirmWindow(string dialogText)
        {
            InitializeComponent();
            //Fills up the text of the dialog
            theText = dialogText;
        }

        //Yes answer
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        //No answer
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        //Show the text
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            confirmationText.Text = theText;
        }
    }
}
