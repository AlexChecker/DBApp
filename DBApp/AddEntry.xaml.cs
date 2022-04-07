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
                    text.Watermark = (string) Types.DefaultView[i][0]+" "+Columns.DefaultView[i][0];
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
                                MessageBox.Show($"Неправильный формат в поле {(textboxes[o] as WatermarkTextBox).Name}");
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