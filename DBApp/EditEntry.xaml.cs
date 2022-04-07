using System.Windows;

namespace DBApp
{
    public partial class EditEntry : Window
    {
        private SQL utils;
        private string TableName;
        private int id;
        public EditEntry(SQL utils,string tableName,int id)
        {
            InitializeComponent();
            this.utils = utils;
            this.TableName = tableName;
            this.id = id;
        }

        private void Apply_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            return;
        }
    }
}