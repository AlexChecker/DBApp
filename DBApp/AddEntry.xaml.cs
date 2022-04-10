using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using Xceed.Wpf.Toolkit;
using MessageBox = System.Windows.MessageBox;

namespace DBApp
{
    public partial class AddEntry : Window
    {
        private SQL utils;
        private string TableName;
        private DataTable Columns;
        private DataTable Types;
        public List<FrameworkElement> textboxes = new List<FrameworkElement>();
        public bool isUpdating = false;
        public AddEntry(SQL utils,string TableName)
        {
            InitializeComponent();
            this.utils = utils;
            this.TableName = TableName;
            Columns = utils.StraightQuery($@"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableName}' order by COLUMN_NAME ASC");
            Types = utils.StraightQuery($@"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableName}' order by COLUMN_NAME ASC");
            for (int i = 0; i < Columns.DefaultView.Count; i++)
            {
                //Проверка на необходимость уникальности поля
                if ((Columns.DefaultView[i][0] as String).Contains("ID_")) continue;
//                DataTable unique = utils.StraightQuery(@$"SELECT CONSTRAINT_TYPE
//FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc 
//    inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE cu 
//        on cu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME 
//where 
//    tc.TABLE_NAME = '{TableName}'
//    and cu.COLUMN_NAME = '{Columns.DefaultView[i][0]}'");

                    WatermarkTextBox text = new WatermarkTextBox();
                                        switch (Columns.DefaultView[i][0] as String)
                                        {
                                            case "ID_Appeal":
                                                text.Watermark = "ID обращения";
                                                break;
                                            case "Appeal_Number":
                                                text.Watermark = "Номер обращения";
                                                break;
                                            case "Appeal_Date_Time":
                                                text.Watermark = "Дата и время подачи обращения";
                                                break;
                                            case "Appeal_Description":
                                                text.Watermark = "Описание обращения";
                                                break;
                                            case "Citizen_ID":
                                                text.Watermark = "ID гражданина";
                                                break;
                                            case "Status_ID":
                                                text.Watermark = "ID статуса";
                                                break;
                                            case "Employee_ID":
                                                text.Watermark = "ID сотрудника";
                                                break;
                                            case "ID_Citizen":
                                                text.Watermark = "ID гражданина";
                                                break;
                                            case "Passport_Series_Citizen":
                                                text.Watermark = "Серия паспорта гражданина";
                                                break;
                                            case "Passport_Number_Citizen":
                                                text.Watermark = "Номер паспорта гражданина";
                                                break;
                                            case "Birth_Day_Citizen":
                                                text.Watermark = "Дата рождения гражданина";
                                                break;
                                            case "Date_Of_Issue":
                                                text.Watermark = "Дата выдачи паспорта";
                                                break;
                                            case "Division_Code_Citizen":
                                                text.Watermark = "Код подразделения";
                                                break;
                                            case "Phone_Number_Citizen":
                                                text.Watermark = "Номер телефона";
                                                break;
                                            case "Issued_By_Citizen":
                                                text.Watermark = "Паспорт выдан";
                                                break;
                                            case "Registration_Adress_Citizen":
                                                text.Watermark = "Адрес регистрации гражданина";
                                                break;
                                            case "First_Name_Citizen":
                                                text.Watermark = "Имя гражданина";
                                                break;
                                            case "Second_Name_Citizen":
                                                text.Watermark = "Фамилия гражданина";
                                                break;
                                            case "Middle_Name_Citizen":
                                                text.Watermark = "Отчество гражданина";
                                                break;
                                            case "Residential_Adress_Citizen":
                                                text.Watermark = "Адрес проживания";
                                                break;
                                            case "Email_Adress_Citizen":
                                                text.Watermark = "Адрес электронной почты";
                                                break;
                                            case "Citizen_Login":
                                                text.Watermark = "Логин гражданина";
                                                break;
                                            case "Citizen_Password":
                                                text.Watermark = "Пароль гражданина";
                                                break;
                                            case "ID_Department":
                                                text.Watermark = "ID отдела";
                                                break;
                                            case "Name_Department":
                                                text.Watermark = "Название отдела";
                                                break;
                                            case "ID_Status":
                                                text.Watermark = "ID статуса";
                                                break;
                                            case "Name_Status":
                                                text.Watermark = "Название статуса";
                                                break;
                                            case "ID_Post":
                                                text.Watermark = "ID Должности";
                                                break;
                                            case "Name_Post":
                                                text.Watermark = "Название должности";
                                                break;
                                            case "ID_Rank":
                                                text.Watermark = "ID звание";
                                                break;
                                            case "Name_Rank":
                                                text.Watermark = "Название звания";
                                                break;
                                            case "ID_Work_Schedule":
                                                text.Watermark = "ID Раписания работы";
                                                break;
                                            case "Work_Schedule_Description":
                                                text.Watermark = "Описание расписания работы";
                                                break;
                                            case "ID_Section":
                                                text.Watermark = "ID статьи";
                                                break;
                                            case "Section_Name":
                                                text.Watermark = "Номер статьи";
                                                break;
                                            case "Section_Description":
                                                text.Watermark = "Описание статьи";
                                                break;
                                            case "ID_Service_Weapon_Type":
                                                text.Watermark = "ID типа табельного оружия";
                                                break;
                                            case "Service_Weapon_Type_Name":
                                                text.Watermark = "Название типа табельного оружия";
                                                break;
                                            case "ID_Employee":
                                                text.Watermark = "ID сотрудника";
                                                break;
                                            case "Employee_Service_Number":
                                                text.Watermark = "Табельный номер сотрудника";
                                                break;
                                            case "Employee_First_Name":
                                                text.Watermark = "Имя сотрудника";
                                                break;
                                            case "Employee_Second_Name":
                                                text.Watermark = "Фамилия сотрудника";
                                                break;
                                            case "Employee_Middle_Name":
                                                text.Watermark = "Отчество сотрудника";
                                                break;
                                            case "Employee_Personal_File_Number":
                                                text.Watermark = "Номер личного дела";
                                                break;
                                            case "Employee_Date_Of_Admission":
                                                text.Watermark = "Дата приёма на работу";
                                                break;
                                            case "Employee_Login":
                                                text.Watermark = "Логин сотрудника";
                                                break;
                                            case "Employee_Password":
                                                text.Watermark = "Пароль сотрудника";
                                                break;
                                            case "Department_ID":
                                                text.Watermark = "ID отдела";
                                                break;
                                            case "Post_ID":
                                                text.Watermark = "ID должности";
                                                break;
                                            case "Rank_ID":
                                                text.Watermark = "ID звания";
                                                break;
                                            case "Work_Schedule_ID":
                                                text.Watermark = "ID расписания работы";
                                                break;
                                            case "ID_Service_Weapon_Number":
                                                text.Watermark = "ID Номера табельного оружия";
                                                break;
                                            case "Service_Number":
                                                text.Watermark = "Табельный номер";
                                                break;
                                            case "ID_Case":
                                                text.Watermark = "ID дела";
                                                break;
                                            case "Case_Number":
                                                text.Watermark = "Номер дела";
                                                break;
                                            case "Appeal_ID":
                                                text.Watermark = "ID обращения";
                                                break;
                                            case "ID_Investigation_Report":
                                                text.Watermark = "ID отчёта о расследовании";
                                                break;
                                            case "Investigation_Report_Number":
                                                text.Watermark = "Номер отчёта";
                                                break;
                                            case "Investigation_Report_Facts":
                                                text.Watermark = "Выявленные факты";
                                                break;
                                            case "Investigation_Beginning_Date":
                                                text.Watermark = "Дата начала расследования";
                                                break;
                                            case "Investigation_Ending_Date":
                                                text.Watermark = "Дата окончания расследования";
                                                break;
                                            case "Case_ID":
                                                text.Watermark = "ID дела";
                                                break;
                                            case "ID_Composition":
                                                text.Watermark = "ID состава обращения";
                                                break;
                                            case "Section_ID":
                                                text.Watermark = "ID дела";
                                                break;
                                            case "ID_Posession":
                                                text.Watermark = "ID владения табельным оружием";
                                                break;
                                            case "Service_Weapon_Type_ID":
                                                text.Watermark = "ID типа табельного оружия";
                                                break;
                                        }
                    //text.Watermark = (string) Types.DefaultView[i][0]+" "+Columns.DefaultView[i][0];
                    text.Name = (string) Columns.DefaultView[i][0];
                    //text.Margin = new Thickness(0,yoffset,0,0);
                    text.Width = 200;
                    text.Height = 30;
                    Grid.Children.Add(text);
                    textboxes.Add(text);
            }
            
        }

        private void Accept_OnClick(object sender, RoutedEventArgs e)
        {
            string query = $@"insert into {TableName} (";
            try
            {
                int o = 0;
                for (int i = 0; i < Types.DefaultView.Count; i++ )
                {                DataTable unique = utils.StraightQuery(@$"SELECT CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc 
    inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE cu 
        on cu.CONSTRAINT_NAME = tc.CONSTRAINT_NAME 
where 
    tc.TABLE_NAME = '{TableName}'
    and cu.COLUMN_NAME = '{Columns.DefaultView[i][0]}'");
                    string uq = "";
                    try
                    {
                        uq =unique.DefaultView[0][0].ToString();
                    }
                    catch (Exception exception)
                    {
                        uq = "null";
                    }
                    if ((Columns.DefaultView[i][0] as String).Contains("ID_"))
                    {
                        continue;
                    }
                    switch (Types.DefaultView[i][0] as String)
                    {
                        case "int":
  

                            if (int.TryParse((textboxes[o] as WatermarkTextBox).Text, out int a))
                            {
                                if (uq == "UNIQUE")
                                {
                                    bool repeat = false;
                                    try
                                    {
                                        unique = utils.StraightQuery($@"select {Columns.DefaultView[i][0]} from {TableName} where {Columns.DefaultView[i][0]}={(textboxes[o] as WatermarkTextBox).Text}");
                                    if (unique.DefaultView[0][0] is not DBNull)
                                    {
                                        MessageBox.Show($"Поле {(textboxes[o] as WatermarkTextBox).Watermark} не уникально в базе данных. А должно.");
                                        return;
                                        
                                    }
                                    }
                                    catch (Exception exception)
                                    {

                                    }

                                }
                                query += Columns.DefaultView[i][0] as String;
                            }
                            else
                            {
                                MessageBox.Show($"Неправильный формат в поле {(textboxes[o] as WatermarkTextBox).Watermark}");
                                return;
                            }
                            break;
                        case "date":
                        case "datetime":
                            if (DateTime.TryParse((textboxes[o] as WatermarkTextBox).Text, out DateTime b))
                            {
                                
                                query += Columns.DefaultView[i][0] as String;
                            }
                            else
                            {
                                MessageBox.Show($"Неправильный формат в поле {(textboxes[o] as WatermarkTextBox).Name}");
                                return;
                            }
                            break;
                        case "varchar":
                            if (uq == "UNIQUE")
                            {
                                try
                                {
                                unique = utils.StraightQuery($@"select {Columns.DefaultView[i][0]} from {TableName} where {Columns.DefaultView[i][0]}='{(textboxes[o] as WatermarkTextBox).Text}'");
                                if (unique.DefaultView[0][0] is not DBNull)
                                {
                                    MessageBox.Show($"Поле {(textboxes[o] as WatermarkTextBox).Watermark} не уникально в базе данных. А должно.");
                                    return;
                                        
                                }
                                }
                                catch (Exception exception)
                                {

                                }

                            }
                            query += Columns.DefaultView[i][0] as String;
                            break;
                    }

                    o++;
                    if (i < Columns.DefaultView.Count - 1) query += " , ";
                    else query += ") values (";
                }

                o = 0;
                for (int i = 0; i < Columns.DefaultView.Count; i++)
                {
                    if ((Columns.DefaultView[i][0] as String).Contains("ID_"))
                    {
                        continue;
                    }
                    switch (Types.DefaultView[i][0] as String)
                    {
                        case "int":

                                query += (textboxes[o] as WatermarkTextBox).Text;

                            break;
                        case "date":
                        case "datetime":
                        case "varchar":
                            query += $@"'{(textboxes[o] as WatermarkTextBox).Text}'";
                                break;
                    }
                    o++;
                    if (i < Columns.DefaultView.Count - 1) query += " , ";
                    else query += ")";
                }

                //MessageBox.Show(query);
                utils.StraightQuery(query);
                this.Close();
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}