using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Sql
{
    internal abstract class SqlBase
    {

        internal SqlConnection _connection;
        internal SqlCommand _command;
        internal SqlBase()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _command = new SqlCommand();
        }
        internal void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }
        internal int ExecuteNonQuery()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            _connection.Close();
            return rows;
        }
    }
}
