using System;
using System.Collections.Generic;
using LawHouseLibrary.Entities;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    class SqlRead
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        internal SqlRead(SqlConnection connection)
        {
            _command = new SqlCommand();
            _connection = connection;
        }

        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }


        private int ExecuteSql()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            _connection.Close();
            return rows;
        }

        internal CaseE GetCase(int id)
        {
            _command.CommandText = "SELECT*FROM ViewCases WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            PrepareSql();
            CaseE c1 = new CaseE();
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
            _connection.Close();
            return c1;
        }

        internal List<CaseE> GetCases()
        {
            List<CaseE> cases = new List<CaseE>();

            _command.CommandText = "SELECT* FROM ViewCases";
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CaseE c1 = new CaseE();
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
                    c1.Client = $"{(reader["ClientfName"] != DBNull.Value ? reader["ClientfName"].ToString() : string.Empty)} " +
                                 $"{(reader["ClientlName"] != DBNull.Value ? reader["ClientlName"].ToString() : string.Empty)}";

                    c1.RespEmployee = $"{(reader["EmployeefName"] != DBNull.Value ? reader["EmployeefName"].ToString() : string.Empty)} " +
                                      $"{(reader["EmployeelName"] != DBNull.Value ? reader["EmployeelName"].ToString() : string.Empty)}";

                    cases.Add(c1);
                }

            }
            _connection.Close();
            return cases;
        }

        internal List<ServiceE> GetProvidedServices(int caseId)
        {
            List<ServiceE> services = new List<ServiceE>();
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
                    ServiceE s1 = new ServiceE();

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

        internal List<LegalServiceE> GetLegalServices()
        {
            List<LegalServiceE> legServices = new List<LegalServiceE>();
            _command.CommandText = "SELECT * FROM LegalServices";
            _command.Parameters.Clear();
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LegalServiceE ls1 = new LegalServiceE();

                    ls1.ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    ls1.Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty;
                    ls1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]): default(int);
                    ls1.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : default(decimal);
                    ls1.TimeEstimate = reader["TimeEstimate"] != DBNull.Value ? Convert.ToInt32(reader["TimeEstimate"]) : default(int);

                    
                    legServices.Add(ls1);
                }

            }
            _connection.Close();
            return legServices;
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
            _connection.Close();
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
            _connection.Close();
            return emplNames;
        }

        internal List<string> GetClientNames()
        {
            List<string> clientNames = new List<string>();
            _command.CommandText = "SELECT FirstName, LastName FROM Client";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    clientNames.Add($"{reader["FirstName"].ToString()}  {reader["LastName"].ToString()}");
                }

            }
            _connection.Close();
            return clientNames;
        }



        internal List <decimal> GetUnitPrices()
        {
            _command.CommandText = "SELECT Rate FROM UnitRate";
            List <decimal> prices =new List<decimal>();

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
