using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace qly_thuquan.Model
{
    internal class DataProvider
    {
        private static readonly string conStr = "server=127.0.0.1; port=3306; user=root; password=''; database=qlthuquan;";
        private static DataProvider instance = null;
        private DataProvider() { }
        public static DataProvider getInstance()
        {
            if (instance == null) instance = new DataProvider();
            return instance;
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conStr))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    if (parameter != null)
                    {
                        string[] str = query.Split(' ');
                        int i = 0;
                        foreach (string x in str) if (x[0] == '@')
                                command.Parameters.AddWithValue(x, parameter[i++]);
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conStr))
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(query, conn);
                    if (parameter != null)
                    {
                        string[] str = query.Split(' ');
                        int i = 0;
                        foreach (string x in str) if (x[0] == '@')
                                command.Parameters.AddWithValue(x, parameter[i++]);
                    }
                    data = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return data;
        }
    }
}
