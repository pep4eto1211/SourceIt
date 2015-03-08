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
    /// User control for showing single message
    /// </summary>
    public partial class messageBox : UserControl
    {
        public messageBox(message currentMessage)
        {
            InitializeComponent();
            boxMessage = currentMessage;
        }

        message boxMessage;

        //Show the message and the sender
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fromLabel.Text = boxMessage.from;
            messageContentBox.Text = boxMessage.content;
        }

        public event EventHandler sendResponse;
        public event EventHandler deleteMessage;

        //Fire the send response event
        private void sendResponseEvent(EventArgs e)
        {
            sendResponse(this, e);
        }

        //Fire the delete message event
        private void deleteMessageEvent(EventArgs e)
        {
            deleteMessage(this, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            deleteMessageEvent(e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sendResponseEvent(e);
        }
    }
}
