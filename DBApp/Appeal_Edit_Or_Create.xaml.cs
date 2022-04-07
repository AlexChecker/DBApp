using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DBApp
{
    public partial class Appeal_Edit_Or_Create : Window
    {
        public SQL utils;
        public SQL.User user;
        /// <summary>
        /// Режим работы окна
        /// </summary>
        public bool isEditing = false;
        public Appeal_Edit_Or_Create()
        {
            InitializeComponent();
            
        }

        private bool filled = false;
        public void refreshDepartments()
        {
            if (!filled)
            {
                DataTable dt = utils.StraightQuery($"select Name_Department from Department order by ID_Department ASC");
                for (int i = 0; i < dt.DefaultView.Count; i++)
                {
                    Departments.Items.Add(dt.DefaultView[i][0]);
                }

                filled = true;
            }
            
        }

        private void Accept_OnClick(object sender, RoutedEventArgs e)
        {
            if (Appeal_Description.Text == "")
            {
                MessageBox.Show("Описание обращения не может быть пустым!");
            }

            if (isEditing)
            {
                int number = Convert.ToInt32(Appeal_Number.Text);
                utils.StraightQuery($"update Appeal set Appeal_Description='{Appeal_Description.Text}' where Appeal_Number={number}");
            }
            else
            {
                DataTable table = utils.StraightQuery($"select Appeal_Number from Appeal");
                List<int> Appeal_Numbers = new List<int>();
                for (int i =0;i<table.DefaultView.Count;i++)
                    Appeal_Numbers.Add((int)table.DefaultView[i][0]);
                int num = 0;
                Random rnd = new Random();
                while (true)
                {
                    num = rnd.Next(1000000,9999999);
                    bool norepeat = true;
                    foreach (int n in Appeal_Numbers)
                    {
                        if (num == n) norepeat = false;
                    }

                    if (norepeat) break;
                }

                table = utils.StraightQuery($"select ID_Employee from Employee where Department_ID={Departments.SelectedIndex+1}");
                List<int> Employees = new List<int>();
                for (int i =0;i<table.DefaultView.Count;i++)
                    Employees.Add((int)table.DefaultView[i][0]);
                //int min = int.MaxValue;
                //int max = int.MinValue;
                //for (int i = 0; i < Employees.Count; i++)
                //{
                //    if (Employees[i] > max) max = Employees[i];
                //    if (Employees[i] < min) min = Employees[i];
                //    
                //}
                //max++;

                utils.StraightQuery(
                    $@"insert into [dbo].[Appeal] ([Appeal_Number],[Appeal_Date_Time],[Appeal_Description],[Citizen_ID],[Status_ID],[Employee_ID])
values ({num},'{DateTime.Now}','{Appeal_Description.Text}',{user.id},{3},{Employees[rnd.Next(1,Employees.Count)]})");
                table = utils.StraightQuery($@"select ID_Case from dbo.[Case]");
                Appeal_Numbers.Clear();
                for (int i =0;i<table.DefaultView.Count;i++)
                    Appeal_Numbers.Add((int)table.DefaultView[i][0]);
                while (true)
                {
                    num = rnd.Next(1000000,9999999);
                    bool norepeat = true;
                    foreach (int n in Appeal_Numbers)
                    {
                        if (num == n) norepeat = false;
                    }

                    if (norepeat) break;
                }

                table = utils.StraightQuery($@"select ID_Appeal from dbo.[Appeal]");
                Appeal_Numbers.Clear();
                for (int i =0;i<table.DefaultView.Count;i++)
                    Appeal_Numbers.Add((int)table.DefaultView[i][0]);
                int max = Appeal_Numbers.Max();
                utils.StraightQuery($@"insert into [Case] (Case_Number, Appeal_ID)
values({num},{max})");
                Appeal_Numbers.Clear();
                table = utils.StraightQuery($@"select Investigation_Report_Number from dbo.Investigation_Report");
                for (int i =0;i<table.DefaultView.Count;i++)
                    Appeal_Numbers.Add((int)table.DefaultView[i][0]);
                int numin = 0;
                while (true)
                {
                    numin = rnd.Next(100000000, 999999999);
                    bool norepeat = true;
                    foreach (int n in Appeal_Numbers)
                    {
                        if (numin == n) norepeat = false;
                    }
                    if (norepeat) break;
                }
                Appeal_Numbers.Clear();
                table = utils.StraightQuery($@"select ID_Case from dbo.[Case]");
                for (int i =0;i<table.DefaultView.Count;i++)
                    Appeal_Numbers.Add((int)table.DefaultView[i][0]);
                max = Appeal_Numbers.Max();
                utils.StraightQuery($@"insert into Investigation_Report ([Investigation_Report_Number],[Investigation_Beginning_Date],[Case_ID])
values({numin},'{DateTime.Now}',{max})");


            }

            Close();
        }


        private void Departments_OnMouseEnter(object sender, MouseEventArgs e)
        {
            refreshDepartments();
        }
    }
}