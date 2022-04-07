using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DBApp
{
    /// <summary>
    /// Логика взаимодействия для MainInterfaceEmployee.xaml
    /// </summary>
    public partial class MainInterfaceEmployee : Window
    {
        public MainWindow mw;
        private DataSet dataset = new DataSet();
        public SQL utils;
        public SQL.User user;
        private AppealDialog diagap = new AppealDialog(); 
        private bool isexit = true;
        public MainInterfaceEmployee()
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
            filltables();
            //Appeals.Columns[1].Header = "Номер обращения";
            //Appeals.Columns[2].Header = "Описание обращения";
        }



        void filltables()
        {
            dataset.Tables.Clear();
            dataset.Tables.Add(utils.StraightQuery($@"select Appeal_Number, Appeal_Description, Section_Name, Name_Status from dbo.Appeal
left join Appeal_Composition on Appeal_ID = ID_Appeal
left join dbo.section on Section_ID = ID_Section
left join dbo.Status on Status_ID=ID_Status
where Employee_ID ={user.id}"));
            Appeals.AutoGenerateColumns = true;
            dataset.Tables[0].Columns[0].ColumnName = "Номер обращения";
            dataset.Tables[0].Columns[1].ColumnName = "Описание обращения";
            dataset.Tables[0].Columns[2].ColumnName = "Статья";
            dataset.Tables[0].Columns[3].ColumnName = "Статус обращения";
            Appeals.ItemsSource=dataset.Tables[0].DefaultView;
            dataset.Tables.Add(utils.StraightQuery($@"select Service_Weapon_Type_Name, Service_Number from dbo.Service_Weapon_Type
left join dbo.Service_Weapon_Posession on Service_Weapon_Type_ID = ID_Service_Weapon_Type
left join dbo.Service_Weapon_Number on Service_Weapon_Posession.Employee_ID = Service_Weapon_Number.Employee_ID
where Service_Weapon_Posession.Employee_ID = {user.id}"));
            dataset.Tables[1].Columns[0].ColumnName = "Тип табельного оружия";
            dataset.Tables[1].Columns[1].ColumnName = "Номер табельного оружия";
            ServiceWeapon.AutoGenerateColumns = true;
            ServiceWeapon.ItemsSource = dataset.Tables[1].DefaultView;
            dataset.Tables.Add(utils.StraightQuery($@"select Name_Department, Name_Post, Name_Rank from dbo.Employee
left join Department on Department_ID=ID_Department
left join Post on Post_ID=ID_Post
left join dbo.[Rank] on Rank_ID=ID_Rank
where ID_Employee = {user.id}"));
            dataset.Tables[2].Columns[0].ColumnName = "Отдел";
            dataset.Tables[2].Columns[1].ColumnName = "Должность";
            dataset.Tables[2].Columns[2].ColumnName = "Звание";
            Department_Post_Run.ItemsSource = dataset.Tables[2].DefaultView;
            dataset.Tables.Add(utils.StraightQuery($@"select Case_Number, Investigation_Report_Number,Investigation_Beginning_Date,Investigation_Ending_Date, Investigation_Report_Facts from Appeal
left join [Case] on Appeal_ID=ID_Appeal
left join Investigation_Report on Case_ID=ID_Case
where Employee_ID ={user.id} "));
            dataset.Tables[3].Columns[0].ColumnName = "Номер дела";
            dataset.Tables[3].Columns[1].ColumnName = "Номер акта о расследованиии";
            dataset.Tables[3].Columns[2].ColumnName = "Дата начала расследования";
            dataset.Tables[3].Columns[3].ColumnName = "Дата окончания расследования";
            dataset.Tables[3].Columns[4].ColumnName = "Выявленные факты";
            Investigations.ItemsSource = dataset.Tables[3].DefaultView;
            (Investigations.Columns[2] as DataGridTextColumn).Binding.StringFormat = "dd MM yyyy";
            (Investigations.Columns[3] as DataGridTextColumn).Binding.StringFormat = "dd MM yyyy";
        }


        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AppealDialog diagap = new AppealDialog();
            diagap.utils = utils;
            diagap.user = user;
            diagap.Appeal_Number.Text = Convert.ToString(dataset.Tables[0].DefaultView[Appeals.SelectedIndex][0]);
            diagap.Appeal_Description.Text = Convert.ToString(dataset.Tables[0].DefaultView[Appeals.SelectedIndex][1]);
            diagap.ShowDialog();
            filltables();

        }

        private void LogOff_OnClick(object sender, RoutedEventArgs e)
        {
            mw.Show();
            isexit = false;
            this.Close();
        }

        private void DataGridCell_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {
            AppealDialog redactF = new AppealDialog();
            redactF.utils = utils;
            redactF.user = user;
            redactF.IsFacts = true;
            redactF.Appeal_Number.Text = Convert.ToString( dataset.Tables[3].DefaultView[Investigations.SelectedIndex][1]);
            redactF.Appeal_Description.Text = Convert.ToString( dataset.Tables[3].DefaultView[Investigations.SelectedIndex][4]);
            redactF.Section.Visibility = Visibility.Hidden;
            redactF.Status.Visibility = Visibility.Hidden;
            redactF.Section.IsEnabled = false;
            redactF.Status.IsEnabled = false;
            redactF.Appeal_Description.IsReadOnly = false;
            redactF.ShowDialog();
            filltables();
            
        }
    }
}
