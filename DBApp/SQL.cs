using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace DBApp
{
    public class SQL
    {

        public struct User
        {
            public User(string name,string secondName,string middleName,int id,bool isEmployee)
            {
                this.name = name;
                this.secondName = secondName;
                this.middleName = middleName;
                this.isEmployee = isEmployee;
                this.id = id;
            }

            public string name;
            public string middleName;
            public string secondName;
            public bool isEmployee;
            public int id;

        }
        public SqlConnection connection;
        public string Catalog = "MVD";
        public void DBConnect()
        {
            string connString = @"Data Source=.\ALEXSERVER;Initial Catalog="+Catalog+";Integrated Security=True";
            connection = new SqlConnection(connString);
        }
        public bool DBConnect(string Login,string Password)
        {
            try
            {
                string connString = @"Data Source=.\ALEXSERVER;Initial Catalog=" + Catalog +
                                    $";Persist Security Info=True;User ID={Login};Password={Password}";
                connection = new SqlConnection(connString);
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка!");
                return false;
            }
        }

        public void queryAsync(string query, Action<DataTable> act)
        {
            Thread th = new Thread(() =>
            {
                try
                {
                    while (connection.State == ConnectionState.Open)
                    {
                        //utils.connection.
                        Application.Current.Dispatcher.Invoke(() =>
                            {
                                PleaseWaitDialog pw = new PleaseWaitDialog(connection);
                                pw.ShowDialog();
                            }
                        );
                    }
                    var dt = StraightQuery(query);
                    act.Invoke(dt);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(connection.State.ToString());
                    MessageBox.Show(ee.Message);
                }
            });
            th.Start();
        }
        public DataTable StraightQuery(string query)
        {
            DataTable result = new DataTable();
            connection.Open();
            //var t = connection.OpenAsync()
            SqlCommand cmd = new SqlCommand(query, connection);
            result.Load(cmd.ExecuteReader());
            connection.Close();
            return result;
        }

        public DataTable Query(string table,List<string> fields,string corrections)
        {
            DataTable result = new DataTable();
            string query = "select ";

            for (int i = 0; i < fields.Count; i++)
            {
                if (i == fields.Count - 1)
                {
                    query += fields[i] + " ";
                }
                else
                {
                    query += fields[i] + ", ";
                }
            }
            query += $" from dbo.{table} where "+corrections;
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            result.Load(cmd.ExecuteReader());
            connection.Close();
            return result;
        }
        public DataTable Query(string table,List<string> fields)
        {
            DataTable result = new DataTable();
            string query = "select ";
            foreach (string str  in fields)
            {
                query += str+" ";
            }

            query += $" from dbo.{table} where ";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            result.Load(cmd.ExecuteReader());
            connection.Close();
            return result;
        }
        public User? Log_In(string username,string password)
        {
            try
            {

                connection.Open();
                string query = $"select Employee_First_Name, Employee_Second_Name, Employee_Middle_Name, ID_Employee from dbo.Employee where Employee_Login='{username}' and Employee_Password='{password}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    //int result = reader.GetInt32(0);
                    //result
                    
                     User us =new User(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetInt32(3),true);
                     connection.Close();
                     return us;
                     //return reader.GetString(0)+" "+reader.GetString(1)+" "+reader.GetString(2);
                     //return Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            try
            {
                string query = $"select First_Name_Citizen, Second_Name_Citizen, Middle_Name_Citizen, ID_Citizen from dbo.Citizen where Citizen_Login='{username}' and Citizen_Password='{password}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    //int result = reader.GetInt32(0);
                    //result
                    User us =new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), false);
                    connection.Close();
                    return us;
                    //return Convert.ToString(result);
                }
            }
            catch
            {
                connection.Close();
                return null ;
            }
        }

        //public string Sample()
        //{
        //    connection.Open();
        //    try
        //    {
        //        string query = $"select ID_Employee from dbo.Employee where Employee_Login='{username}' and Employee_Password='{password}'";
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        using (DbDataReader reader = cmd.ExecuteReader())
        //        {
        //            reader.Read();
        //            int result = reader.GetInt32(0);
        //            return Convert.ToString(result); 
        //        }
        //    connection.Close();
        //    }
        //    catch (Exception ex)
        //    { return "NO data!"; }
        //
        //}
    }
}
