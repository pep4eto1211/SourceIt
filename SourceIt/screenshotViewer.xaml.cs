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
    /// Window for viewing the store item screenshot
    /// </summary>
    public partial class screenshotViewer : Window
    {
        public screenshotViewer(ImageSource screenshot, string itemName)
        {
            InitializeComponent();
            titleLabel.Content += " " + itemName;
            currentScreenshotImage.Source = screenshot;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
