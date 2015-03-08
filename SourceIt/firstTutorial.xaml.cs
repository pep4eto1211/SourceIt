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

namespace SourceIt
{
    /// <summary>
    /// Future functionality
    /// </summary>
    public partial class firstTutorial : Page
    {
        public firstTutorial()
        {
            InitializeComponent();
        }

        public bool userChoice = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userChoice = false;
            Window.GetWindow(this).Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new secondTutorial());
        }
    }
}
