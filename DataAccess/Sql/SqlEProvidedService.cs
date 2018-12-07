using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    internal class SqlEProvidedService : IProvidedService
    {

        private SqlConnection _connection;
        private SqlCommand _command;
        public SqlEProvidedService()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());

        }
        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }
        private int ExecuteNonQuery()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            _connection.Close();
            return rows;
        }
        public int NewProvidedService(ProvidedServiceM s1)
        {
            string sqlString = "INSERT INTO ProvidedService (Employee_ID, Case_ID, Date, Hours, Km, Comment) VALUES " +
                               "((SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName)," +
                               " @Case_ID, @Date, @Hours, @Km, @Comment)";

            _command.CommandText = sqlString;

            string[] names = s1.EmployeeName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Case_ID", s1.CaseID));
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@Comment", s1.Comment));
            _command.Parameters.Add(new SqlParameter("@fName", names[0]));
            _command.Parameters.Add(new SqlParameter("@lName", names[1]));
            return ExecuteNonQuery();
        }

        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            _command.CommandText = "SELECT p.*, e.FirstName AS eFName, e.LastName AS eLName " +
                                   "FROM ProvidedService p " +
                                   "JOIN Employee e ON p.Employee_ID = e.ID " +
                                   "JOIN[Case] c ON p.Case_ID = c.ID";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@caseId", caseId));
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProvidedServiceM s1 = new ProvidedServiceM();

                    s1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    s1.CaseID = reader["Case_ID"] != DBNull.Value ? Convert.ToInt32(reader["Case_ID"]) : default(int);

                    s1.EmployeeName = $"{(reader["EmployeefName"] != DBNull.Value ? reader["EmployeefName"].ToString() : string.Empty)} " +
                                      $"{(reader["EmployeelName"] != DBNull.Value ? reader["EmployeelName"].ToString() : string.Empty)}";
                    s1.Date = reader["Date"] != DBNull.Value ? Convert.ToDateTime(reader["Date"]) : DateTime.MinValue;
                    s1.Hours = reader["Hours"] != DBNull.Value ? Convert.ToInt32(reader["Hours"]) : default(int);
                    s1.Km = reader["Km"] != DBNull.Value ? Convert.ToInt32(reader["Km"]) : default(int);
                    s1.Comment = reader["Comment"] != DBNull.Value ? reader["Comment"].ToString() : String.Empty;
                    services.Add(s1);
                }

            }
            _connection.Close();
            return services;

        }

        public int UpdateProvidedService(ProvidedServiceM s1)
        {
            _command.CommandText = "UPDATE [dbo].[ProvidedService] SET Date = @Date, Hours = @Hours, Km = @Km WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@id", s1.Id));

            return ExecuteNonQuery();
        }

        public int DeleteProvidedService(int id)
        {
            _command.CommandText = $"DELETE FROM ProvidedService WHERE ID = @Id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("Id", id));
            return ExecuteNonQuery();
        }
        public List<decimal> GetUnitPrices()
        {
            _command.CommandText = "SELECT Rate FROM UnitRate";
            List<decimal> prices = new List<decimal>();

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    prices.Add(Convert.ToDecimal(reader["Rate"]));
                }
            }
            _connection.Close();
            return prices;
        }
    }
}
