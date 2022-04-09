using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace DBApp
{
    public partial class Auth : Window
    {
        string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
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
        public static string Base64Encode(string plainText) {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string encoded)
        {
            var enc =System.Convert.FromBase64String(encoded);
            return System.Text.Encoding.UTF8.GetString(enc);
        }

        private void Auth_OnLoaded(object sender, RoutedEventArgs e)
        {
            RegistryKey lkm = Registry.CurrentUser;
            string[] keys = lkm.GetSubKeyNames();
            bool freshInstall = true;
            foreach (var str in keys)
            {
                if (str == "MVDAPP")
                {
                    freshInstall = false;
                    break;
                }
            }

            if (freshInstall)
            {
                RegistryKey appkey = lkm.CreateSubKey("MVDAPP");
                ActivationWindow activate = new ActivationWindow();
                activate.ShowDialog();
                if (Base64Decode(Base64Decode(Base64Decode(activate.activator))) ==
                    $"Trial key for user {username} for 30 days")
                {
                    appkey.SetValue(Base64Encode("activationKey"), activate.activator);
                    appkey.SetValue(Base64Encode("ExpiringDate"), Base64Encode(DateTime.Now.AddDays(30).ToString()));
                }
                else if (Base64Decode(Base64Decode(Base64Decode(activate.activator))) ==
                         $"License key for user {username}")
                {
                    appkey.SetValue(Base64Encode("activationKey"), activate.activator);
                    appkey.SetValue(Base64Encode("ExpiringDate"), Base64Encode("Everlasting key"));
                }
                else
                {
                    MessageBox.Show("Неверный лицензионный ключ!");
                    
                    lkm.DeleteSubKey("MVDAPP");
                    this.Close();
                }
            }
            else
            {
                RegistryKey appkey = lkm.OpenSubKey("MVDAPP", true);
                if (appkey.GetValue(Base64Encode("activationKey")).ToString() ==
                    Base64Encode(Base64Encode(Base64Encode($"Trial key for user {username} for 30 days"))))
                {
                    if (appkey.GetValue(Base64Encode("ExpiringDate")).ToString() == "Everlasting key")
                    {
                        MessageBox.Show("Обнаружена попытка подделки лицензионного ключа! Программа будет закрыта и данные о лицензии будут стёрты.");
                        appkey.DeleteValue(Base64Encode("activationKey"));
                        appkey.DeleteValue(Base64Encode("ExpiringDate"));
                        appkey.Close();
                        lkm.DeleteSubKey("MVDAPP");
                        this.Close();
                        return;
                    }

                    else if (DateTime.TryParse(appkey.GetValue(Base64Encode("ExpiringDate")).ToString(),
                        out DateTime date) && DateTime.Now > date)
                    {
                        MessageBox.Show(
                            "Период пробной лицензии истёк! Программа будет закрыта для очищения данных реестра!");
                        appkey.DeleteValue(Base64Encode("activationKey"));
                        appkey.DeleteValue(Base64Encode("ExpiringDate"));
                        appkey.Close();
                        lkm.DeleteSubKey("MVDAPP");
                        this.Close();
                        return;
                    }
                    else if (DateTime.TryParse(appkey.GetValue(Base64Encode("ExpiringDate")).ToString(),
                        out DateTime date2))
                    {
                        MessageBox.Show(
                            "Лицензионный ключ повреждён. Программа будет закрыта для очистки повреждённых данных.");
                        appkey.DeleteValue(Base64Encode("activationKey"));
                        appkey.DeleteValue(Base64Encode("ExpiringDate"));
                        appkey.Close();
                        lkm.DeleteSubKey("MVDAPP");
                        this.Close();
                        return;
                    }
                }
                else if (appkey.GetValue(Base64Encode("activationKey")).ToString() ==
                         Base64Encode(Base64Encode(Base64Encode($"License key for user {username}"))))
                {
                    if (appkey.GetValue( Base64Encode("ExpiringDate")).ToString() != Base64Encode("Everlasting key"))
                    {
                        MessageBox.Show(
                            "Обнаружена попытка подделки лицензионного ключа! Зачем вам это? Программа будет закрыта и данные о лицензии будут стёрты.");
                        appkey.DeleteValue(Base64Encode("activationKey"));
                        appkey.DeleteValue(Base64Encode("ExpiringDate"));
                        appkey.Close();
                        lkm.DeleteSubKey("MVDAPP");
                        this.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Лицензионный ключ повреждён. Программа будет закрыта для очистки повреждённых данных.");
                    appkey.DeleteValue(Base64Encode("activationKey"));
                    appkey.DeleteValue(Base64Encode("ExpiringDate"));
                    appkey.Close();
                    lkm.DeleteSubKey("MVDAPP");
                    this.Close();
                    return;
                }
            }
        
    
        }
    }
}