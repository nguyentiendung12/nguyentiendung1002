using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ck
{
  
        public class DataProvider
        {
            private static DataProvider instance; // Ctrl + R + E

            public static DataProvider Instance
            {
                get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
                private set { DataProvider.instance = value; }
            }

            private DataProvider() { }

            private string strconn = "Server=localhost; Database=cardp; User Id=root;Password=kocomatkhau,Character Set=UTF8";

            public DataTable ExecuteQuery(string query, object[] parameter = null)
            {
                DataTable data = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(strconn))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }

           

           
        }

    }

