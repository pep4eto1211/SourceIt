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
    /// Notification control
    /// </summary>
    public partial class singleNotification : UserControl
    {
        public singleNotification(Notification singleNotification)
        {
            InitializeComponent();
            currentNotification = singleNotification;
        }

        Notification currentNotification;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            notificationContentBox.Text = currentNotification.content;
            notificationTitleLabel.Text = "Известие за проект: " + currentNotification.project;
        }

        public event EventHandler deleteNotificationPressed;

        private void deleteNotificationPressedEvent(EventArgs e)
        {
            deleteNotificationPressed(this, e);
        }

        private void deletePostButton_Click(object sender, RoutedEventArgs e)
        {
            deleteNotificationPressedEvent(e);
        }
    }
}
