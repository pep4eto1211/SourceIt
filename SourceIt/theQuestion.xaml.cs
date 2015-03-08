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
    /// Question user control for the help finder service
    /// </summary>
    public partial class theQuestion : UserControl
    {
        public theQuestion(question currentQuestion)
        {
            InitializeComponent();
            questionData = currentQuestion;
        }

        private question questionData;

        //Show the data about the question
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            questionContent.Text = questionData.content;
            userAvatarLabel.Text = questionData.username[0].ToString() + questionData.username[1].ToString();
            postUsername.Text = questionData.username;
        }

        public event EventHandler openAnswers;
        //Fire events
        private void openAnswersEvent(EventArgs e)
        {
            openAnswers(this, e);
        }

        private void openProjectButton_Click(object sender, RoutedEventArgs e)
        {
            openAnswersEvent(e);
        }
    }
}
