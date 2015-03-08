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
    /// Single post control for the project dashboard 
    /// </summary>
    public partial class singleProjectPost : UserControl
    {
        public singleProjectPost(Post singlePostData, string currentUser)
        {
            InitializeComponent();
            currentPostData = singlePostData;
            globalUser = currentUser;
        }

        string globalUser = "";
        public int postId = -1;
        Post currentPostData;

        //Show the post data
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (globalUser == currentPostData.user)
            {
                deletePostButton.Visibility = System.Windows.Visibility.Visible;
            }
            postTextBox.Text = currentPostData.content;
            postUsername.Text = currentPostData.user;
            postTitleLabel.Text = currentPostData.user + " каза:";
            postUsername.ToolTip = currentPostData.user;
            userAvatarLabel.Text = currentPostData.user.Remove(2);
        }

        public event EventHandler deletePostPressed;

        //Fire events
        private void deletePostPressedEvent(EventArgs e)
        {
            deletePostPressed(this, e);
        }

        private void deletePostButton_Click(object sender, RoutedEventArgs e)
        {
            deletePostPressedEvent(e);
        }
    }
}
