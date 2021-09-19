using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace QLThueXe.Connection
{
    public interface IDataBaseServices
    {
        DataTable ExecuteQuery(string query, CommandType commandType = CommandType.Text, params NpgsqlParameter[] parameters);
        int ExecuteNonQuery(string query, CommandType commandType = CommandType.Text, params NpgsqlParameter[] parameters);
        int ExecuteNonQueryNoPara(string query, CommandType commandType = CommandType.Text);
        object ExecuteScalar(string query, CommandType commandType = CommandType.Text, params NpgsqlParameter[] parameters);
    }
}
