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
    /// User control for single job offer
    /// </summary>
    public partial class jobControl : UserControl
    {
        public jobControl(singleJob currentJob)
        {
            InitializeComponent();

            job = currentJob;
        }

        singleJob job;

        //Show tha data for the current job offer
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            userAvatarLabel.Text = job.user[0].ToString() + job.user[1].ToString();
            postUsername.Text = job.user;
            offerContent.Text = job.content;
        }

        public event EventHandler sendMessage;

        //Fire the send message event
        private void sendMessageEvent(EventArgs e)
        {
            sendMessage(this, e);
        }

        //Call the function that fires the send message event
        private void openProjectButton_Click(object sender, RoutedEventArgs e)
        {
            sendMessageEvent(e);
        }

    }
}
