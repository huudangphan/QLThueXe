using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Npgsql;

namespace QLThueXe.Connection
{
    public  class DataBaseServices 
    {
        public static string conStr = @"";

        private static DataBaseServices instance; 

        public static DataBaseServices Instance
        {
            get { if (instance == null) instance = new DataBaseServices(); return DataBaseServices.instance; }
            private set { DataBaseServices.instance = value; }
        }

    
        public string ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

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

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();                
            }
           

            return JsonConvert.SerializeObject(data);
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(query, connection);

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

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                connection.Open();

               NpgsqlCommand command = new NpgsqlCommand(query, connection);

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

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
       
    }
}
