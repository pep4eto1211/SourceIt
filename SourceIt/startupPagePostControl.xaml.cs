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
    /// User control for a post on the startup page
    /// </summary>
    public partial class startupPagePostControl : UserControl
    {
        public startupPagePostControl(startupPagePost singlePost, string currentUser)
        {
            InitializeComponent();
            currentPostData = singlePost;
            theUser = currentUser;
        }

        public string theUser = "";
        startupPagePost currentPostData;

        //Show post data
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (theUser == currentPostData.user)
            {
                deletePostButton.Visibility = System.Windows.Visibility.Visible;
            }
            postTextBox.Text = currentPostData.content;
            postUsername.Text = currentPostData.user;
            postUsername.ToolTip = currentPostData.user;
            userAvatarLabel.Text = currentPostData.user.Remove(2);
            postProject.Text = "Име на проекта: " + currentPostData.project;
            openProjectButton.Click += openProjectButton_Click;
        }

        public event EventHandler openProjectPressed;
        public event EventHandler deletePostPressed;

        //Fire events
        private void openProjectPressedEvent(EventArgs e)
        {
            openProjectPressed(this, e);
        }

        private void deleteProjectPressedEvent(EventArgs e)
        {
            deletePostPressed(this, e);
        }

        void openProjectButton_Click(object sender, RoutedEventArgs e)
        {
            openProjectPressedEvent(e);
        }

        private void deletePostButton_Click(object sender, RoutedEventArgs e)
        {
            deleteProjectPressedEvent(e);
        }
    }
}
