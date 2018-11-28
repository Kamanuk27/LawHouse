using System;
using System.Collections.Generic;
using LawHouseLibrary.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataAccess
{
    class SqlRead
    {
        private SqlConnection connection;
        private SqlCommand _command;

        internal SqlRead()
        {
            _command = new SqlCommand();
        }

        private void PrepareSql()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            connection.Open();
            _command.Connection = connection;
        }


        private int ExecuteSql()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }

        internal Case GetCase(int id)
        {
            _command.CommandText = "SELECT*FROM ViewCases WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            PrepareSql();
            Case c1 = new Case();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
                    c1.EndDate = c1.StartDate + TimeSpan.FromDays(Convert.ToInt32(reader["TimeEstimate"]));
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
                    c1.Service = reader["ServiceName"] != DBNull.Value ? reader["ServiceName"].ToString() : string.Empty;

                    c1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
                    c1.Client = $"{(reader["ClientfName"] != DBNull.Value ? reader["ClientfName"].ToString() : string.Empty)} " +
                                $"{(reader["ClientlName"] != DBNull.Value ? reader["ClientlName"].ToString() : string.Empty)}";

                    c1.RespEmployee = $"{(reader["EmployeefName"] != DBNull.Value ? reader["EmployeefName"].ToString() : string.Empty)} " +
                                      $"{(reader["EmployeelName"] != DBNull.Value ? reader["EmployeelName"].ToString() : string.Empty)}";

                }
            }
            connection.Close();
            return c1;
        }

        internal List<Case> GetCases()
        {
            List<Case> cases = new List<Case>();

            _command.CommandText = "SELECT* FROM ViewCases";
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Case c1 = new Case();
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
                    c1.Client = $"{(reader["ClientfName"] != DBNull.Value ? reader["ClientfName"].ToString() : string.Empty)} " +
                                 $"{(reader["ClientlName"] != DBNull.Value ? reader["ClientlName"].ToString() : string.Empty)}";

                    c1.RespEmployee = $"{(reader["EmployeefName"] != DBNull.Value ? reader["EmployeefName"].ToString() : string.Empty)} " +
                                      $"{(reader["EmployeelName"] != DBNull.Value ? reader["EmployeelName"].ToString() : string.Empty)}";

                    cases.Add(c1);
                }

            }
            connection.Close();
            return cases;
        }

        internal List<Service> GetProvidedServices(int caseId)
        {
            List<Service> services = new List<Service>();
            _command.CommandText = "SELECT * FROM ViewProvidedServices where Case_ID = @caseId";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@caseId", caseId));
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Service s1 = new Service();

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
            connection.Close();
            return services;
        }

        internal List<string> GetLawyers()
        {
            List<string> lawyers = new List<string>();
            _command.CommandText = "SELECT FirstName, LastName FROM Employee WHERE Position = 'Advokat'";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string e = $"{reader["FirstName"].ToString()}  {reader["LastName"].ToString()}";
                    lawyers.Add(e);
                }

            }
            connection.Close();
            return lawyers;

        }
        internal List<string> GetEmplNames()
        {
            List<string> emplNames = new List<string>();
            _command.CommandText = "SELECT FirstName, LastName FROM Employee";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string e = $"{reader["FirstName"].ToString()}  {reader["LastName"].ToString()}";
                    emplNames.Add(e);
                }

            }
            connection.Close();
            return emplNames;
        }

        internal decimal GetPrice(int id)
        {
            _command.CommandText = "CalculatePrice";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Decimal));
            _command.Parameters.Add(new SqlParameter("@id", id));

            _command.Parameters["@price"].Direction = ParameterDirection.Output;

            ExecuteSql();

            decimal price = Convert.ToDecimal(_command.Parameters["@price"].Value);

            _command = new SqlCommand();
            return price;
        }
    }
}
