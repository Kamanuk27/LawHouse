
using System.Configuration;
using System.Data.SqlClient;

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

       internal int ExecuteNonQuerySqlReturnId()
        {
            //Bruges i create new client. 
            PrepareSql();
            int affectedRows = _command.ExecuteNonQuery(); 

            if (affectedRows == 1)
            {         
                //Rettes - returnerer ikke ID endnu.
                _command.CommandText = "SELECT @@IDENTITY as ID";
                SqlDataReader reader = _command.ExecuteReader(); 
                reader.Read();

                return ((int)reader.GetDecimal(0)); 
            }
            _connection.Close();
            return -1;
        }
    }
}
