using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace DBApp
{
    public partial class MainInterfaceCitizen : Window
    {
        
        public MainWindow mw;
        private DataSet dataset = new DataSet();
        public SQL utils;
        public SQL.User user;
        private AppealDialog diagap = new AppealDialog(); 
        private bool isexit = true;
        public MainInterfaceCitizen()
        {
            InitializeComponent();
        }
        
        protected override void OnClosed(EventArgs e)
        {
            if (isexit)
            {
                base.OnClosed(e);

                Application.Current.Shutdown();
            }
        }
        public void init()
        {
            dataset.Tables.Clear();
            dataset.Tables.Add(utils.StraightQuery($@"select Appeal_Number, Appeal_Description, Section_Name, Name_Status from dbo.Appeal
left join Appeal_Composition on Appeal_ID = ID_Appeal
left join dbo.section on Section_ID = ID_Section
left join dbo.Status on Status_ID=ID_Status
where Citizen_ID ={user.id}"));
            Appeals.AutoGenerateColumns = true;
            dataset.Tables[0].Columns[0].ColumnName = "Номер обращения";
            dataset.Tables[0].Columns[1].ColumnName = "Описание обращения";
            dataset.Tables[0].Columns[2].ColumnName = "Статья";
            dataset.Tables[0].Columns[3].ColumnName = "Статус обращения";
            Appeals.ItemsSource=dataset.Tables[0].DefaultView;
        }

        private void LogOff_OnClick(object sender, RoutedEventArgs e)
        {
            mw.Show();
            isexit = false;
            this.Close();
        }

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Appeal_Edit_Or_Create AEOC = new Appeal_Edit_Or_Create();
            AEOC.utils = utils;
            AEOC.user = user;
            AEOC.Appeal_Number.Text=Convert.ToString(dataset.Tables[0].DefaultView[Appeals.SelectedIndex][0]);
            AEOC.Appeal_Description.Text = Convert.ToString(dataset.Tables[0].DefaultView[Appeals.SelectedIndex][1]);
            AEOC.isEditing = true;
            AEOC.ShowDialog();
            init();
            
        }

        private void NewAppeal_OnClick(object sender, RoutedEventArgs e)
        {
            Appeal_Edit_Or_Create AEOC = new Appeal_Edit_Or_Create();
            AEOC.utils = utils;
            AEOC.user = user;
            AEOC.ShowDialog();
            init();
        }
    }
}