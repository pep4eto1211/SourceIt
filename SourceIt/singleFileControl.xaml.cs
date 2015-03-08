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
    /// File control for the server file wxplorer
    /// </summary>
    public partial class singleFileControl : UserControl
    {
        public singleFileControl(string name)
        {
            InitializeComponent();
            fileName = name;
        }

        private string fileName = "";

        public string fileNameString
        {
            get
            {
                return fileName;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fileNameLabel.Text = fileName;
            this.ToolTip = fileName;
        }
    }
}
