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
    /// Window for showing errors
    /// </summary>
    public partial class errorWindow : Window
    {
        public errorWindow(string errorMessage)
        {
            InitializeComponent();
            errorText.Text = errorMessage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
