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
    /// Interaction logic for LoginExample.xaml
    /// </summary>
    public partial class LoginExample : Window
    {
        public LoginExample()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = "abc";
            string password = "abc";

            if (txtUsername.Text == username && txtPassword.Password == password)
            {
                MainWindow win = new MainWindow();
                win.Show();
                Close();
            }
            else
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
