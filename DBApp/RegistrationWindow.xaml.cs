using System;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows;

namespace DBApp
{
    public partial class RegistrationWindow : Window
    {
        private bool useEmail = false;
        public SQL utils;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
         
                Email.Visibility = Visibility.Visible;
                Email_Label.Visibility = Visibility.Visible;
                useEmail = true;
        }

        private void Verify_OnUnchecked(object sender, RoutedEventArgs e)
        {
            useEmail = false;
                Email.Visibility=Visibility.Collapsed;
                Email_Label.Visibility = Visibility.Collapsed;        
        }

        private void Accept_OnClick(object sender, RoutedEventArgs e)
        {
            if (Issued_By.Text!=""&& Issue_Date.Text!=""&& First_Name.Text!=""&& Second_Name.Text!=""&& Second_Name.Text!=""&& Passport_Number.Text!=""
                && Passport_Series.Text!=""&& Division_Code.Text!=""&& Phone_Number.Text!=""&& Birth_Day.Text!=""&& Residential_Adress.Text!="" )
            {
                    Regex r = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$");
                    if (r.Matches(Password.Text).Count==0)
                    {
                        MessageBox.Show("Пароль должен содержать строчные и заглавные буквы,спецсимволы и цифры!");
                        return;
                    }

                    Regex rr = new Regex(@"^[a-zA-Z_]{8,16}$");
                    if (rr.Matches(Login.Text).Count==0)
                    {
                        MessageBox.Show("Логин может содержать в себе только латинские буквы и знак подчёркивания.\nЛогин должен быть длиной от 8 до 16 символов");
                        return;
                    }

                    DataTable dt = utils.StraightQuery($@"select Citizen_Login from Citizen");
                    foreach (var str in dt.DefaultView)
                    {
                        if (Login.Text == (string) (str as DataRowView)[0])
                        {
                            MessageBox.Show("Уже существует пользователь с таким логином");
                            return;
                        }
                    }
                if (useEmail )
                {
                    if (Email.Text == "")
                    {
                        MessageBox.Show("Введите почту!");
                        return;
                    }

                    Regex rrr = new Regex(@"^([a-zA-Z0-9]+(?:[._-][a-zA-Z0-9]+)*)@([a-zA-Z0-9]+(?:[.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,})$");
                    if (rrr.Matches(Email.Text).Count == 0)
                    {
                        MessageBox.Show("Неверно введена электронная почта");
                        return;
                    }

                    dt = utils.StraightQuery($@"select Email_Adress_Citizen from Citizen");
                    foreach (var str in dt.DefaultView)
                    {
                        try
                        {
                            if (Email.Text == (string) (str as DataRowView)[0])
                            {
                                MessageBox.Show("Уже существует пользователь с такoй почтой");
                                return;
                            }
                        }
                        catch(Exception ex)
                        {
                            Debug.Print(ex.Message);
                        }
                    }
                    var result =
                        MessageBox.Show(
                            "Вы верно ввели почту? На данный адрес будет отправляться код для входа,\n и если почта не верна, то вы не сможете продолжить регистрацию!",
                            "Внимание!", MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.No || result == MessageBoxResult.None)
                    {
                        return;
                    }

                    TwoFactorAuth tw = new TwoFactorAuth();
                    tw.user = new SQL.User(First_Name.Text, Second_Name.Text, Middle_Name.Text, 0, false);
                    tw.email = Email.Text;
                    tw.utils = utils;
                    tw.registration = true;
                    tw.ShowDialog();
                    if (tw.result)
                    {
                        if (Middle_Name.Text == "")
                        {
                            utils.StraightQuery($@"insert into [dbo].[Citizen] ([Passport_Series_Citizen],[Passport_Number_Citizen],[Birth_Day_Citizen],[Date_Of_Issue],[Division_Code_Citizen],[Issued_By_Citizen],[Registration_Adress_Citizen],[First_Name_Citizen],[Second_Name_Citizen],[Phone_Number_Citizen],[Residential_Adress_Citizen],[Email_Adress_Citizen],[Citizen_Login],[Citizen_Password])
values ('{Passport_Series.Text}','{Passport_Number.Text}','{Birth_Day.Text}','{Issue_Date.Text}','{Division_Code.Text}','{Issued_By.Text}','{Registration_Address.Text}','{First_Name.Text}','{Second_Name.Text}','{Phone_Number.Text}','{Residential_Adress.Text}','{Email.Text}','{Login.Text}','{Password.Text}')");
                            this.Close();
                            return;
                        }
                        else
                        {
                            utils.StraightQuery($@"insert into [dbo].[Citizen] ([Passport_Series_Citizen],[Passport_Number_Citizen],[Birth_Day_Citizen],[Date_Of_Issue],[Division_Code_Citizen],[Issued_By_Citizen],[Registration_Adress_Citizen],[First_Name_Citizen],[Second_Name_Citizen],[Middle_Name_Citizen],[Phone_Number_Citizen],[Residential_Adress_Citizen],[Email_Adress_Citizen],[Citizen_Login],[Citizen_Password])
values ('{Passport_Series.Text}','{Passport_Number.Text}','{Birth_Day.Text}','{Issue_Date.Text}','{Division_Code.Text}','{Issued_By.Text}','{Registration_Address.Text}','{First_Name.Text}','{Second_Name.Text}','{Middle_Name.Text}','{Phone_Number.Text}','{Residential_Adress.Text}','{Email.Text}','{Login.Text}','{Password.Text}')");
                            this.Close();
                            return;
                        }
                    }
                }
                else
                {
                    if (Middle_Name.Text == "")
                    {
                        utils.StraightQuery($@"insert into [dbo].[Citizen] ([Passport_Series_Citizen],[Passport_Number_Citizen],[Birth_Day_Citizen],[Date_Of_Issue],[Division_Code_Citizen],[Issued_By_Citizen],[Registration_Adress_Citizen],[First_Name_Citizen],[Second_Name_Citizen],[Phone_Number_Citizen],[Residential_Adress_Citizen],[Citizen_Login],[Citizen_Password],[Email_Adress_Citizen])
values ('{Passport_Series.Text}','{Passport_Number.Text}','{Birth_Day.Text}','{Issue_Date.Text}','{Division_Code.Text}','{Issued_By.Text}','{Registration_Address.Text}','{First_Name.Text}','{Second_Name.Text}','{Phone_Number.Text}','{Residential_Adress.Text}','{Login.Text}','{Password.Text}',null)");
                        this.Close();
                        return;
                    }
                    else
                    {
                        utils.StraightQuery($@"insert into [dbo].[Citizen] ([Passport_Series_Citizen],[Passport_Number_Citizen],[Birth_Day_Citizen],[Date_Of_Issue],[Division_Code_Citizen],[Issued_By_Citizen],[Registration_Adress_Citizen],[First_Name_Citizen],[Second_Name_Citizen],[Middle_Name_Citizen],[Phone_Number_Citizen],[Residential_Adress_Citizen],[Citizen_Login],[Citizen_Password],[Email_Adress_Citizen])
values ('{Passport_Series.Text}','{Passport_Number.Text}','{Birth_Day.Text}','{Issue_Date.Text}','{Division_Code.Text}','{Issued_By.Text}','{Registration_Address.Text}','{First_Name.Text}','{Second_Name.Text}','{Middle_Name.Text}','{Phone_Number.Text}','{Residential_Adress.Text}','{Login.Text}','{Password.Text}',null)");
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("В системе уже есть пользователь с такими паспортными данными");
                return;
            }
        }
    }
}