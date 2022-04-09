using System;
using System.Windows;

namespace DBApp
{
    public partial class ActivationWindow : Window
    {
        string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public string activator = "";
        public ActivationWindow()
        {
            InitializeComponent();
        }
        public static string Base64Encode(string plainText) {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string encoded)
        {
            var enc =System.Convert.FromBase64String(encoded);
            return System.Text.Encoding.UTF8.GetString(enc);
        }

        private void Activate_OnClick(object sender, RoutedEventArgs e)
        {
            activator = Base64Encode(Base64Encode(Base64Encode($"License key for user {username}")));
            this.Close();
        }

        private void Trial_OnClick(object sender, RoutedEventArgs e)
        {
            activator = Base64Encode(Base64Encode(Base64Encode($"Trial key for user {username} for 30 days")));
            this.Close();
        }
    }
}