using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    internal class DBConnection
    {


        private static DBConnection instance;
        public static DBConnection Instance
        {
            get { if (instance == null) instance = new DBConnection(); return DBConnection.instance; }
            private set => DBConnection.instance = value;
        }

        static string connectionSTR = "Data Source=localhost;Initial Catalog=QLSV;User ID=sa;Password=123456";

        public static void DangNhap(string user, string pass)
        {
            connectionSTR = "Data Source=localhost;Initial Catalog=QLSV;User ID="+user+";Password=" + pass;
        }  

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();

                return data;
            }
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();

                return data;
            }
        }
        public void Use_PROC(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }
               command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {

            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();

                return data;
            }
        }


        public void updatestring(string user,string pass)
        {
            connectionSTR = "Data Source=localhost;Initial Catalog=QLSV;User ID="+ user+";Password=" + pass;
        }








        public SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=QLSV;Integrated Security=True");
        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Thuc thi that bai\n" + exc);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable FormLoad(string sqlStr)
        {
            DataTable dataSet = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dataSet);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataSet;
        }
        public object GetItem(string sqlStr)
        {
            object result = new object();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlStr, conn);
                result = command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
