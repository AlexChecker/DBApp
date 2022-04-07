using System;
using System.Data;
using System.Windows;
using System.Windows.Input;

namespace DBApp
{
    public partial class AppealDialog : Window
    {
        public SQL utils;
        public SQL.User user;
        private bool filled = false;
        public bool IsFacts = false;
        public AppealDialog()
        {
            InitializeComponent();
            Status.Items.Add("Открытое");
            Status.Items.Add("Закрыто");
            Status.Items.Add("На рассмотрении");
            Status.SelectedIndex = 0;
        }

        private void Accept_OnClick(object sender, RoutedEventArgs e)
        {
            
            int number = Convert.ToInt32(Appeal_Number.Text);
            if (IsFacts)
            {
                utils.StraightQuery(
                    $@"update Investigation_Report set Investigation_Report_Facts='{Appeal_Description.Text}' where Investigation_Report_Number={number}");
                this.Close();
                return;
            }

            utils.StraightQuery($"update Appeal set Status_ID={Status.SelectedIndex+1} where Appeal_Number={number}");
            if(Status.SelectedIndex==1)
            utils.StraightQuery($@"update Investigation_Report set Investigation_Ending_Date='{DateTime.Now.ToString()}' from Appeal
inner join [Case] on Appeal_ID=ID_Appeal
inner join Investigation_Report on Case_ID=ID_Case
where Employee_ID={user.id} and Appeal_Number={number}");
            else
                utils.StraightQuery($@"update Investigation_Report set Investigation_Ending_Date=null from Appeal
inner join [Case] on Appeal_ID=ID_Appeal
inner join Investigation_Report on Case_ID=ID_Case
where Employee_ID={user.id} and Appeal_Number={number}");
            DataTable dt = utils.StraightQuery($@"select ID_Composition from Appeal_Composition 
inner join Appeal on Appeal_ID=ID_Appeal
where Appeal_Number={number}");
            if (dt.DefaultView.Count == 0)
            {
                //MessageBox.Show("");
                dt = utils.StraightQuery($@"select ID_Appeal from Appeal where Appeal_Number={number}");
                utils.StraightQuery($@"insert into Appeal_Composition (Appeal_ID,Section_ID)
values ({(int)dt.DefaultView[0][0]},{Section.SelectedIndex+1})");
            }
            else
            {
                utils.StraightQuery($@"update Appeal_Composition set Section_ID={Section.SelectedIndex+1} from Appeal
inner join Appeal_Composition on Appeal_ID=ID_Appeal
where Appeal_Number={number}");
                //MessageBox.Show("Состав есть");
            }

            //utils.StraightQuery($@"insert into dbo.Appeal_Composition (Appeal_ID, Section_ID)
//values ({number},{Section.SelectedIndex+1})");
            //int count = (int)utils.StraightQuery($@"select count(ALL ID_Appeal) from Appeal").DefaultView[0][0];
            //utils.StraightQuery($"insert into Appeal_Composition (Appeal_ID, Section_ID)");
            this.Close();
        }

        private void Section_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (!filled)
            {
                DataTable dt = utils.StraightQuery($"select Section_Name from Section order by ID_Section ASC");
                for (int i = 0; i < dt.DefaultView.Count; i++)
                {
                    Section.Items.Add(dt.DefaultView[i][0]);
                }

                filled = true;
            }
        }
    }
}