using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck
{
    public class DataProvider1
    {
        private static DataProvider1 instance; // Ctrl + R + E

        public static DataProvider1 Instance
        {
            get { if (instance == null) instance = new DataProvider1(); return DataProvider1.instance; }
            private set { DataProvider1.instance = value; }
        }

        private DataProvider1() { }

        private string strconn = "Server=localhost; Database=user; User Id=root;Password=kocomatkhau,Character Set=UTF8";

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(strconn))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader ra = command.ExecuteReader();
                if (ra.Read() == true)
                {
                   
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }

                connection.Close();
            }

           
        }




    }
}
