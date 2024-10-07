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

namespace F24Week6WpfControls
{
    /// <summary>
    /// Interaction logic for UserInteractionControls.xaml
    /// </summary>
    public partial class UserInteractionControls : Window
    {
        public UserInteractionControls()
        {
            InitializeComponent();
        }

        private void btnReadCheckboxes_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "";

            if (chkToronto.IsChecked == true)
                lblOutput.Content += chkToronto.Content + "\n";

            if (chkVancouver.IsChecked == true)
                lblOutput.Content += chkVancouver.Content + "\n";

            if (chkCalgary.IsChecked == true)
                lblOutput.Content += chkCalgary.Content + "\n";

            if(chkHalifax.IsChecked == true)
                lblOutput.Content += chkHalifax.Content + "\n";
        }
    }
}
