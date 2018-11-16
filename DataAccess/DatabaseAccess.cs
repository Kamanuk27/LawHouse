using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    class DatabaseAccess : IDataAccess
    {
        private SqlConnection connection;
        private SqlCommand command = new SqlCommand();

        // Metoden indeholder connectionstring.
        private string GetConnectionString()
        {
           return ConfigurationManager.ConnectionStrings["Sql"].ToString();
        }

        //Metoden åbner SQL-connection og indeholder command.
        private void PrepareSql(string sqlString)
        {
            connection = new SqlConnection(GetConnectionString());
            connection.Open();
            command.Connection = connection;
            command.CommandText = sqlString;
        }

        //Metoden bruges for ExecuteNonQuery() commands, som Create, Update, Delete.

        private void ExecuteSql(string sqlString)
        {
            PrepareSql(sqlString);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public Case GetCase(int id)
        {
            string sqlString = "SELECT*FORM case ... WHERE   ";
            PrepareSql(sqlString);
            Case c1 = new Case();
            SqlDataReader reader = null;
            reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      c1.ID = reader["ti_id"] != DBNull.Value ? Convert.ToInt32(reader["ti_id"]) : default(int);
                    
                    }
                }
                connection.Close();
                return c1;
            }
        }

        public List<Employee> ReadAllEmployee()
        {

            throw new NotImplementedException();
        }

        public Employee ReadSingleEmployee(string ssn)
        {
            throw new NotImplementedException();
        }
    }
}
