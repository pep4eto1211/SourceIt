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
    /// Folder  control for the server file explorer
    /// </summary>
    public partial class singleFolderControl : UserControl
    {
        public singleFolderControl(string name)
        {
            folderName = name;
            InitializeComponent();
        }

        private string folderName = "";

        public string folderNameString
        {
            get
            {
                return folderName;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            folderNameLabel.Text = folderName;
            this.ToolTip = folderName;
        }
    }
}
