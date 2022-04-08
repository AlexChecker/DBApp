using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DBApp
{
    public partial class PleaseWaitDialog : Window
    {
        private SqlConnection utils;
        public PleaseWaitDialog(SqlConnection utils)
        {
            InitializeComponent();
            this.utils = utils;
        }

        private void PleaseWaitDialog_OnLoaded(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                if (utils.State == ConnectionState.Closed)
                {
                    this.Close();
                    return;
                }
            }
        }
    }
}