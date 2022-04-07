using System.Windows;
using System.Windows.Controls;

namespace DBApp
{
    public partial class Auth : Window
    {
        public SQL utils = new SQL();
        public Auth()
        {
            InitializeComponent();
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Show();
            if (AuthType.SelectedIndex == 1)
            {
                Login.Visibility = Visibility.Visible;
                LoginText.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Visible;
                PasswordText.Visibility = Visibility.Visible;
            }
            else
            {
                Login.Visibility = Visibility.Collapsed;
                LoginText.Visibility = Visibility.Collapsed;
                Password.Visibility = Visibility.Collapsed;
                PasswordText.Visibility = Visibility.Collapsed;
            }
        }

        private void LogIn_OnClick(object sender, RoutedEventArgs e)
        {
            if (AuthType.SelectedIndex == 0)
            {
                MainWindow mw = new MainWindow();
                utils.DBConnect();
                mw.utils = utils;
                mw.Show();
                this.Close();
            }
            else
            {
                AdminPanel admin = new AdminPanel();
                bool noErrors =utils.DBConnect(LoginText.Text,Password.Text);
                if (!noErrors)
                {
                    return;
                }

                admin.utils = utils;
                admin.Show();
                this.Close();
            }
        }
    }
}