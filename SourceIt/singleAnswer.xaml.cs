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
    /// Single answer control for the help finder service
    /// </summary>
    public partial class singleAnswer : UserControl
    {
        public singleAnswer(answer currentAnswer)
        {
            InitializeComponent();
            item = currentAnswer;
        }

        answer item;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            answerContent.Text = item.content;
            postUsername.Text = item.username;
            postUsername.ToolTip = item.username;
            userAvatarLabel.Text = item.username[0].ToString() + item.username[1].ToString();
        }
    }
}
