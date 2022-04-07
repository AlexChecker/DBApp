using System;
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
        
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Tables_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!filled)
            {
                DataTable dt = utils.StraightQuery($@"select name from SYSOBJECTS where xtype='U' order by name ASC");
            for (int i = 0; i < dt.DefaultView.Count; i++)
                {
                    Tables.Items.Add(dt.DefaultView[i][0]);
                }

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
                            string table_name = (string) Tables.Items[Tables.SelectedIndex];
                            DataTable dt = utils.StraightQuery($@"select * from [dbo].[{table_name}]");
                            Table.AutoGenerateColumns = true;
                            Table.ItemsSource = dt.DefaultView;
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
                Filtering filtering = new Filtering(utils, (string) Tables.Items[Tables.SelectedIndex]);
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
            AddEntry ad = new AddEntry(utils,(string) Tables.Items[Tables.SelectedIndex]);
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
                utils.StraightQuery($@"delete from {(string) Tables.Items[Tables.SelectedIndex]} where {(string)Table.Columns[0].Header}={id}");
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
            EditEntry edit = new EditEntry(utils,(string) Tables.Items[Tables.SelectedIndex],Table.SelectedIndex+1);
            edit.Editable.Text = cellvalue;
            edit.ShowDialog();
            DataTable names = utils.StraightQuery($@"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{Tables.Items[Tables.SelectedIndex]}'");
            MessageBox.Show(names.DefaultView[Table.CurrentColumn.DisplayIndex][0].ToString());
            //return;
            string check =(utils.StraightQuery(
                    $@"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{Tables.Items[Tables.SelectedIndex]}' and COLUMN_NAME='{names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}' order by COLUMN_NAME ASC")
                as DataTable).DefaultView[0][0].ToString();
            switch (check)
            {
                case "int":
                    if (int.TryParse(edit.Editable.Text, out int a) && a > 0)
                    {
                        utils.StraightQuery($"update {Tables.Items[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}={edit.Editable.Text} where {names.DefaultView[0][0]}={Table.SelectedIndex+1}");
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
                        utils.StraightQuery($"update {Tables.Items[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}='{edit.Editable.Text}' where {names.DefaultView[0][0]}={Table.SelectedIndex+1}");
                    }
                    else
                    {
                        MessageBox.Show("Неверный формат!");
                        return;
                    }
                    break;
                case "varchar":
                    DataTable lengths = utils.StraightQuery($@"select CHARACTER_MAXIMUM_LENGTH from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{Tables.Items[Tables.SelectedIndex]}' and COLUMN_NAME='{names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}'");
                    if ((int) lengths.DefaultView[0][0] > edit.Editable.Text.Length)
                    {
                        utils.StraightQuery(
                            $"update {Tables.Items[Tables.SelectedIndex]} set {names.DefaultView[Table.CurrentColumn.DisplayIndex][0]}='{edit.Editable.Text}' where {names.DefaultView[0][0]}={Table.SelectedIndex + 1}");

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