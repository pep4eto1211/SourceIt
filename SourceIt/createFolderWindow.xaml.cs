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
    /// Window for creating folders on the server space of the project
    /// </summary>
    public partial class createFolderWindow : Window
    {
        public createFolderWindow()
        {
            InitializeComponent();
        }

        //Folder name property
        public string newFolderName
        {
            get 
            {
                return name;
            }
        }

        private string name = "";

        //Close the window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Set the folder name property to the selected name and close the window
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (folderNameBox.Text != "")
            {
                name = folderNameBox.Text;
                this.DialogResult = true;
                this.Close();
            }
        }
    }
}
