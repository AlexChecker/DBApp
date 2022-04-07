using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DBApp
{
    public partial class Filtering : Window
    {
        private SQL utils;
        private string TableName;
        private bool filled = false;
        public DataTable result;
        public bool finitaLaComedia = false;
        public Filtering(SQL utils,string Table_Name)
        {
            InitializeComponent();
            this.utils = utils;
            TableName = Table_Name;
        }

        private void Columns_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!filled)
            {
                DataTable dt =
                    utils.StraightQuery(
                        @$"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableName}' order by COLUMN_NAME ASC");
                for (int i = 0; i < dt.DefaultView.Count; i++)
                    Columns.Items.Add(dt.DefaultView[i][0]);
                filled = true;
            }
        }

        private void Columns_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string column_name = (string)Columns.Items[Columns.SelectedIndex];
            DataTable dt = utils.StraightQuery($@"select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{TableName}' order by COLUMN_NAME ASC");
            string columnType = (string) dt.DefaultView[Columns.SelectedIndex ][0];
            switch (columnType)
            {
                case "varchar":
                    IncludeString.Visibility = Visibility.Visible;
                    ExcludeString.Visibility = Visibility.Visible;
                    NumberGreater.Visibility = Visibility.Collapsed;
                    NumberSmaller.Visibility = Visibility.Collapsed;
                    break;
                case "int":
                    
                    IncludeString.Visibility = Visibility.Collapsed;
                    ExcludeString.Visibility = Visibility.Collapsed;
                    NumberGreater.Visibility = Visibility.Visible;
                    NumberSmaller.Visibility = Visibility.Visible;
                    break;
                default:
                    IncludeString.Visibility = Visibility.Collapsed;
                    ExcludeString.Visibility = Visibility.Collapsed;
                    NumberGreater.Visibility = Visibility.Collapsed;
                    NumberSmaller.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void ApplyFilter_OnClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Columns.SelectedIndex.ToString());
            string sorting = "";
            if (Columns.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите колонку, по которой будет фильтроваться таблица!");
                return;
            }
            else
            {
                if ((bool) SortAscending.IsChecked) sorting = "ASC";
                else if ((bool) SortDescending.IsChecked) sorting = "DESC";
                if ((bool) IncludeString.IsChecked && StringFilterBox.Text!="")
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} like '%{StringFilterBox.Text}%' {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else if ((bool) ExcludeString.IsChecked && StringFilterBox.Text != "")
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} not like '%{StringFilterBox.Text}%' {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else if ((bool) NumberGreater.IsChecked && int.TryParse(NumberFilterBox.Text, out int a)&&a>0)
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} > {NumberFilterBox.Text} {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else if ((bool) NumberSmaller.IsChecked && int.TryParse(NumberFilterBox.Text, out int b)&&b>0)
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} < {NumberFilterBox.Text} {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else if ((bool) NotEqual.IsChecked && int.TryParse(NumberFilterBox.Text, out int c)&&c>0)
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} != {NumberFilterBox.Text} {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else if ((bool) Equal.IsChecked && int.TryParse(NumberFilterBox.Text, out int d)&&d>0)
                {
                    result = utils.StraightQuery($@"select * from {TableName} where {Columns.Items[Columns.SelectedIndex]} is null {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]}  {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }
                else
                {
                    result = utils.StraightQuery($@"select * from {TableName} {(sorting=="ASC"||sorting=="DESC"?$"order by {Columns.Items[Columns.SelectedIndex]} {sorting}":"")}");
                    finitaLaComedia = true;
                    this.Close();
                    return;
                }

            }
        }

        private void IncludeString_OnClick(object sender, RoutedEventArgs e)
        {
            StringFilterBox.Visibility = Visibility.Visible;
            NumberFilterBox.Visibility = Visibility.Collapsed;
        }

        private void NumberGreater_OnClick(object sender, RoutedEventArgs e)
        {
            StringFilterBox.Visibility = Visibility.Collapsed;
            NumberFilterBox.Visibility = Visibility.Visible;
        }
    }
}