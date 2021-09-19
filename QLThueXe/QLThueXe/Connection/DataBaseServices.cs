using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace QLThueXe.Connection
{
    public  class DataBaseServices 
    {
        public string conStr = @"Server=192.168.50.102;Port=5432;User Id=postgres;Password=24122021;Database=MyDB";
        public  string SchemaName = "public";

        public DataTable ExcuteQuery(string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        public int ExcuteNonquery(string querry)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(querry);

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                try
                {

                    cmd.Connection = conn;
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    return cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return -1;
                   
                }
            }

        }
    }
}
