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
    /// Future functionality
    /// </summary>
    public partial class wellcome : Window
    {

        public bool userChoice = true;

        public wellcome()
        {
            InitializeComponent();
            tutorialFrame.Navigate(new firstTutorial());
        }

        public readonly static string EndWizardSignal = "END_WIZARD";
        public string username = "";

        private void tutorialFrame_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            if (EndWizardSignal.Equals(e.Content))
            {
                e.Cancel = true;
                this.DialogResult = e.ExtraData as bool?;
                this.Close();
            }
        }

    }
}
