using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DBApp
{
    public partial class AdminPanel : Window
    {
        public SQL utils;
        private bool filled = false;
        private List<string> TableNames = new List<string>();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Tables_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!filled)
            {
                //DataTable dt = utils.StraightQuery($@"select name from SYSOBJECTS where xtype='U' order by name ASC");
              //  utils.queryAsync($@"", (dt) =>
              //  {
              //for (int i = 0; i < dt.DefaultView.Count; i++)
              //    {
              //        TableNames.Add(dt.DefaultView[i][0]);
              //    }
              //  });
              utils.queryAsync($@"select name from SYSOBJECTS where xtype='U' order by name ASC", (dt) =>
              { 
                  Application.Current.Dispatcher.Invoke(() =>
                  {
                      for (int i = 0; i < dt.DefaultView.Count; i++)
                      {
                          if ((string) dt.DefaultView[i][0] != "sysdiagrams")
                          {
                              
                            TableNames.Add((string)dt.DefaultView[i][0]);
                          //Tables.Items.Add(dt.DefaultView[i][0]);
                          switch ((string) dt.DefaultView[i][0])
                          {
                              case "Appeal":
                                  Tables.Items.Add("Обращения");
                                  break;
                              case "Appeal_Composition":
                                  Tables.Items.Add("Состав обращения");

                                  break;
                              case "Case":
                                  Tables.Items.Add("Дело");

                                  break;
                              case "Citizen":
                                  Tables.Items.Add("Граждане");

                                  break;
                              case "Department":
                                  Tables.Items.Add("Отделы");

                                  break;
                              case "Employee":
                                  Tables.Items.Add("Сотрудники");

                                  break;
                              case "Investigation_Report":
                                  Tables.Items.Add("Отчёты о расследованиях");

                                  break;
                              case "Post":
                                  Tables.Items.Add("Должности");

                                  break;
                              case "Rank":
                                  Tables.Items.Add("Звания");

                                  break;
                              case "Section":
                                  Tables.Items.Add("Статьи");

                                  break;
                              case "Service_Weapon_Number":
                                  Tables.Items.Add("Номера табельных оружий");

                                  break;
                              case "Service_Weapon_Posession":
                                  Tables.Items.Add("Владения табельными оружиями");

                                  break;
                              case "Service_Weapon_Type":
                                  Tables.Items.Add("Типы табельных оружий");

                                  break;
                              case "Status":
                                  Tables.Items.Add("Статусы");

                                  break;
                              case "Work_Schedule":
                                  Tables.Items.Add("Расписания работы");

                                  break;
                          }
                          }
                      }
                  });
              });
              //utils.queryAsync($@"", (dt) =>
              //{ 
              //    Application.Current.Dispatcher.Invoke(() =>
              //    {
              //        
              //    });
              //});
                filled = true;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
                base.OnClosed(e);

                Application.Current.Shutdown();
        }
        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }

        void update()
        {
                        if (filled)
                        {
                            //MessageBox.Show(utils.connection.State.ToString());
                            string table_name = (string) TableNames[Tables.SelectedIndex];
                            utils.queryAsync($@"select * from [dbo].[{table_name}]", (dt) =>
                            { 
                                Application.Current.Dispatcher.Invoke(() =>
                                {
                                    foreach (DataColumn column in dt.Columns)
                                    {
                                        switch (column.ColumnName)
                                        {
                                            case "ID_Appeal":
                                                column.ColumnName = "ID обращения";
                                                break;
                                            case "Appeal_Number":
                                                column.ColumnName = "Номер обращения";
                                                break;
                                            case "Appeal_Date_Time":
                                                column.ColumnName = "Дата и время подачи обращения";
                                                break;
                                            case "Appeal_Description":
                                                column.ColumnName = "Описание обращения";
                                                break;
                                            case "Citizen_ID":
                                                column.ColumnName = "ID гражданина";
                                                break;
                                            case "Status_ID":
                                                column.ColumnName = "ID статуса";
                                                break;
                                            case "Employee_ID":
                                                column.ColumnName = "ID сотрудника";
                                                break;
                                            case "ID_Citizen":
                                                column.ColumnName = "ID гражданина";
                                                break;
                                            case "Passport_Series_Citizen":
                                                column.ColumnName = "Серия паспорта гражданина";
                                                break;
                                            case "Passport_Number_Citizen":
                                                column.ColumnName = "Номер паспорта гражданина";
                                                break;
                                            case "Birth_Day_Citizen":
                                                column.ColumnName = "Дата рождения гражданина";
                                                break;
                                            case "Date_Of_Issue":
                                                column.ColumnName = "Дата выдачи паспорта";
                                                break;
                                            case "Division_Code_Citizen":
                                                column.ColumnName = "Код подразделения";
                                                break;
                                            case "Phone_Number_Citizen":
                                                column.ColumnName = "Номер телефона";
                                                break;
                                            case "Issued_By_Citizen":
                                                column.ColumnName = "Паспорт выдан";
                                                break;
                                            case "Registration_Adress_Citizen":
                                                column.ColumnName = "Адрес регистрации гражданина";
                                                break;
                                            case "First_Name_Citizen":
                                                column.ColumnName = "Имя гражданина";
                                                break;
                                            case "Second_Name_Citizen":
                                                column.ColumnName = "Фамилия гражданина";
                                                break;
                                            case "Middle_Name_Citizen":
                                                column.ColumnName = "Отчество гражданина";
                                                break;
                                            case "Residential_Adress_Citizen":
                                                column.ColumnName = "Адрес проживания";
                                                break;
                                            case "Email_Adress_Citizen":
                                                column.ColumnName = "Адрес электронной почты";
                                                break;
                                            case "Citizen_Login":
                                                column.ColumnName = "Логин гражданина";
                                                break;
                                            case "Citizen_Password":
                                                column.ColumnName = "Пароль гражданина";
                                                break;
                                            case "ID_Department":
                                                column.ColumnName = "ID отдела";
                                                break;
                                            case "Name_Department":
                                                column.ColumnName = "Название отдела";
                                                break;
                                            case "ID_Status":
                                                column.ColumnName = "ID статуса";
                                                break;
                                            case "Name_Status":
                                                column.ColumnName = "Название статуса";
                                                break;
                                            case "ID_Post":
                                                column.ColumnName = "ID Должности";
                                                break;
                                            case "Name_Post":
                                                column.ColumnName = "Название должности";
                                                break;
                                            case "ID_Rank":
                                                column.ColumnName = "ID звание";
                                                break;
                                            case "Name_Rank":
                                                column.ColumnName = "Название звания";
                                                break;
                                            case "ID_Work_Schedule":
                                                column.ColumnName = "ID Раписания работы";
                                                break;
                                            case "Work_Schedule_Description":
                                                column.ColumnName = "Описание расписания работы";
                                                break;
                                            case "ID_Section":
                                                column.ColumnName = "ID статьи";
                                                break;
                                            case "Section_Name":
                                                column.ColumnName = "Номер статьи";
                                                break;
                                            case "Section_Description":
                                                column.ColumnName = "Описание статьи";
                                                break;
                                            case "ID_Service_Weapon_Type":
                                                column.ColumnName = "ID типа табельного оружия";
                                                break;
                                            case "Service_Weapon_Type_Name":
                                                column.ColumnName = "Название типа табельного оружия";
                                                break;
                                            case "ID_Employee":
                                                column.ColumnName = "ID сотрудника";
                                                break;
                                            case "Employee_Service_Number":
                                                column.ColumnName = "Табельный номер сотрудника";
                                                break;
                                            case "Employee_First_Name":
                                                column.ColumnName = "Имя сотрудника";
                                                break;
                                            case "Employee_Second_Name":
                                                column.ColumnName = "Фамилия сотрудника";
                                                break;
                                            case "Employee_Middle_Name":
                                                column.ColumnName = "Отчество сотрудника";
                                                break;
                                            case "Employee_Personal_File_Number":
                                                column.ColumnName = "Номер личного дела";
                                                break;
                                            case "Employee_Date_Of_Admission":
                                                column.ColumnName = "Дата приёма на работу";
                                                break;
                                            case "Employee_Login":
                                                column.ColumnName = "Логин сотрудника";
                                                break;
                                            case "Employee_Password":
                                                column.ColumnName = "Пароль сотрудника";
                                                break;
                                            case "Department_ID":
                                                column.ColumnName = "ID отдела";
                                                break;
                                            case "Post_ID":
                                                column.ColumnName = "ID должности";
                                                break;
                                            case "Rank_ID":
                                                column.ColumnName = "ID звания";
                                                break;
                                            case "Work_Schedule_ID":
                                                column.ColumnName = "ID расписания работы";
                                                break;
                                            case "ID_Service_Weapon_Number":
                                                column.ColumnName = "ID Номера табельного оружия";
                                                break;
                                            case "Service_Number":
                                                column.ColumnName = "Табельный номер";
                                                break;
                                            case "ID_Case":
                                                column.ColumnName = "ID дела";
                                                break;
                                            case "Case_Number":
                                                column.ColumnName = "Номер дела";
                                                break;
                                            case "Appeal_ID":
                                                column.ColumnName = "ID обращения";
                                                break;
                                            case "ID_Investigation_Report":
                                                column.ColumnName = "ID отчёта о расследовании";
                                                break;
                                            case "Investigation_Report_Number":
                                                column.ColumnName = "Номер отчёта";
                                                break;
                                            case "Investigation_Report_Facts":
                                                column.ColumnName = "Выявленные факты";
                                                break;
                                            case "Investigation_Beginning_Date":
                                                column.ColumnName = "Дата начала расследования";
                                                break;
                                            case "Investigation_Ending_Date":
                                                column.ColumnName = "Дата окончания расследования";
                                                break;
                                            case "Case_ID":
                                                column.ColumnName = "ID дела";
                                                break;
                                            case "ID_Composition":
                                                column.ColumnName = "ID состава обращения";
                                                break;
                                            case "Section_ID":
                                                column.ColumnName = "ID дела";
                                                break;
                                            case "ID_Posession":
                                                column.ColumnName = "ID владения табельным оружием";
                                                break;
                                            case "Service_Weapon_Type_ID":
                                                column.ColumnName = "ID типа табельного оружия";
                                                break;
                                        }
                                    }
                                    Table.AutoGenerateColumns = true;
                              Table.ItemsSource = dt.DefaultView;
                                });
                            });
                            //DataTable dt = utils.StraightQuery($");
                            
                        }
        }

        private void Tables_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            update();
            //MessageBox.Show((string) Table.Items[Table.SelectedIndex]);

        }

        private void Filter_OnClick(object sender, RoutedEventArgs e)
        {
            if (Tables.SelectedIndex > -1)
            {
                Filtering filtering = new Filtering(utils, (string) TableNames[Tables.SelectedIndex]);
                filtering.ShowDialog();
                if (filtering.finitaLaComedia)
                {
                    Table.AutoGenerateColumns = true;
                    Table.ItemsSource = filtering.result.DefaultView;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите таблицу!");
            }
        }

        private void AddEntry_OnClick(object sender, RoutedEventArgs e)
        {
            AddEntry ad = new AddEntry(utils,(string) TableNames[Tables.SelectedIndex]);
            ad.ShowDialog();
            update();
        }

        private void DeleteEntry_OnClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Table.SelectedIndex.ToString());
            if (Table.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления!");
                return;
            }
            var result = MessageBox.Show("Вы уверены, что хотите удалить данную запись?","Внимание!",MessageBoxButton.OKCancel);
            //MessageBox.Show(result.ToString());
            if (result == MessageBoxResult.OK)
            {
                //MessageBox.Show(((DataRowView) Table.SelectedItems[0]).Row[0].ToString());
                int id = (int) ((DataRowView) Table.SelectedItems[0]).Row[0];
                utils.queryAsync($@"delete from {(string) TableNames[Tables.SelectedIndex]} where {(string)Table.Columns[0].Header}={id}", (dt) =>
                { 

                });
                //utils.StraightQuery($@"");
                update();
            }
        }

        private void Table_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (Table.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите запись для изменения!");
                return;
            }
            DataRowView view = (DataRowView)Table.SelectedItem;
            int index = Table.CurrentCell.Column.DisplayIndex;
            string cellvalue = view.Row.ItemArray[index].ToString();
            EditEntry edit = new EditEntry(utils,(string) TableNames[Tables.SelectedIndex],Table.SelectedIndex+1);
            edit.Editable.Text = cellvalue;
            edit.ShowDialog();
            DataTable names = utils.StraightQuery($@"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableNames[Tables.SelectedIndex]}'");
            MessageBox.Show(names.DefaultView[Table.CurrentColumn.DisplayIndex][0].ToString());
            //return;
            string check =(utils.StraightQuery(
                    $@"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableNames[Tables.SelectedIndex]}' and COLUMN_NAME='{names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}' order by COLUMN_NAME ASC")
                as DataTable).DefaultView[0][0].ToString();
            switch (check)
            {
                case "int":
                    if (int.TryParse(edit.Editable.Text, out int a) && a > 0)
                    {
                        utils.queryAsync($@"update {TableNames[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}={edit.Editable.Text} where {names.DefaultView[0][0]}={Table.SelectedIndex+1}", (dt) =>
                        { 

                        });
                        //utils.StraightQuery($"");
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат!");
                        return;
                    }
                    break;
                case "datetime":
                    case "date":
                    if (DateTime.TryParse(edit.Editable.Text, out DateTime b))
                    {
                        utils.queryAsync($@"update {TableNames[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}='{edit.Editable.Text}' where {names.DefaultView[0][0]}={Table.SelectedIndex+1}", (dt) =>
                        { 

                        });
                        //utils.StraightQuery($"");
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат!");
                        return;
                    }
                    break;
                case "varchar":
                    DataTable lengths = utils.StraightQuery($@"select CHARACTER_MAXIMUM_LENGTH from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableNames[Tables.SelectedIndex]}' and COLUMN_NAME='{names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}'");
                    if ((int) lengths.DefaultView[0][0] > edit.Editable.Text.Length)
                    {
                        utils.queryAsync($@"update {TableNames[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}='{edit.Editable.Text}' where {names.DefaultView[0][0]}={Table.SelectedIndex + 1}", (dt) =>
                        { 

                        });

                    }
                    else
                    {
                        MessageBox.Show("Превышен лимит символов!");
                        return;
                    }

                    break;
            }
            update();
        }


    }
}