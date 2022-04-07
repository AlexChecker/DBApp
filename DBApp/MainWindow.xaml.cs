using System;
using System.Collections.Generic;
using System.Data;
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

namespace DBApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SQL utils;
        public MainWindow()
        {
            InitializeComponent();
            //utils.DBConnect();
        }
        protected override void OnClosed(EventArgs e)
        {
                base.OnClosed(e);

                Application.Current.Shutdown();
            
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string result = utils.Sample(LoginBox.Text, PasswordBox.Text);
            //MessageBox.Show(result);
            SQL.User? user = utils.Log_In(LoginBox.Text, PasswordBox.Text);
            MainInterfaceEmployee Employee_Interface = new MainInterfaceEmployee();
            MainInterfaceCitizen Citizen_Interface = new MainInterfaceCitizen();
            if (!(user is null))
            {
                
                if ((bool) (user?.isEmployee))
                {
                    Employee_Interface.username_label.Content +=
                        user?.name + " " + user?.secondName + " " + user?.middleName;
                    Employee_Interface.utils = this.utils;
                    Employee_Interface.user = (SQL.User) user;
                    Employee_Interface.mw = this;
                    Employee_Interface.Show();
                    Employee_Interface.init();
                    this.Hide();
                }
                else
                {
                    bool result = false;
                    DataTable dt = utils.StraightQuery($@"select Email_Adress_Citizen from Citizen where ID_Citizen={user?.id}");
                    if (dt.DefaultView[0][0] is not DBNull)
                    {
                        TwoFactorAuth tw = new TwoFactorAuth();
                        tw.utils = utils;
                        tw.user = (SQL.User) user;
                        tw.ShowDialog();
                        result = tw.result;
                    }
                    else result = true;

                    if (result)
                    {
                        Citizen_Interface.username_label.Content +=
                            user?.name + " " + user?.secondName + " " + user?.middleName;
                        Citizen_Interface.utils = this.utils;
                        Citizen_Interface.user = (SQL.User) user;
                        Citizen_Interface.mw = this;
                        Citizen_Interface.Show();
                        Citizen_Interface.init();
                        
                        this.Hide();
                    }
                }
            }
            else 
            {
                MessageBox.Show("Пожалуйста, введите верные данные!");            
            }
        }

        private void Register_OnClick(object sender, RoutedEventArgs e)
        {
            RegistrationWindow reg = new RegistrationWindow();
            reg.utils = utils;
            reg.Show();
        }
    }
}
