using System;
using System.Collections.Generic;
using LawHouseLibrary.Models;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    class CaseRead
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        internal CaseRead(SqlConnection connection)
        {
            _command = new SqlCommand();
            _connection = connection;
        }

        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }

        //internal List<CaseM> GetCases()
        //{
        //    List<CaseM> cases = new List<CaseM>();

        //    _command.CommandText = "SELECT c.*, e.FirstName AS eFName, e.LastName AS eLName, cl.FirstName AS cFName, " +
        //                           "cl.LastName AS cLName, sb.[Name] AS subjectName FROM [Case] c "+
        //                           "JOIN Employee e ON  c.RespEmp_ID = e.ID " +
        //                           "JOIN Client cl ON c.Client_ID = cl.ID " +
        //                           "JOIN[Subject] sb ON c.Subject_ID = sb.ID ";
        //    PrepareSql();
        //    SqlDataReader reader = null;
        //    reader = _command.ExecuteReader();

        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            CaseM c1 = new CaseM();
        //            c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
        //            c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
        //            c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
        //            c1.EndDate = c1.StartDate + TimeSpan.FromDays(Convert.ToInt32(reader["TimeEstimate"]));
        //            c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
        //            c1.TotalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
        //            c1.Subject = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : string.Empty;

        //            c1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
        //            c1.Client = $"{(reader["cFName"] != DBNull.Value ? reader["cFName"].ToString() : string.Empty)} " +
        //                        $"{(reader["cLName"] != DBNull.Value ? reader["cLName"].ToString() : string.Empty)}";

        //            c1.RespEmployee = $"{(reader["eFName"] != DBNull.Value ? reader["eFName"].ToString() : string.Empty)} " +
        //                              $"{(reader["eLName"] != DBNull.Value ? reader["eLName"].ToString() : string.Empty)}";

        //            cases.Add(c1);
        //        }

        //    }
        //    _connection.Close();
        //    return cases;
        //}

        internal List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            _command.CommandText = "SELECT p.*, e.FirstName AS eFName, e.LastName AS eLName " +	  
                                   "FROM ProvidedService p "+
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

        //internal List<SubjectM> GetSubjects()
        //{
        //    List<SubjectM> legServices = new List<SubjectM>();
        //    _command.CommandText = "SELECT * FROM Subject";
        //    _command.Parameters.Clear();
        //    PrepareSql();
        //    SqlDataReader reader = null;
        //    reader = _command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            SubjectM ls1 = new SubjectM();

        //            ls1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
        //            ls1.Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty;
        //            ls1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]): default(int);
        //            ls1.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : default(decimal);
        //            ls1.TimeEstimate = reader["TimeEstimate"] != DBNull.Value ? Convert.ToInt32(reader["TimeEstimate"]) : default(int);

                    
        //            legServices.Add(ls1);
        //        }

        //    }
        //    _connection.Close();
        //    return legServices;
        //}

        internal List<EmployeeM> GetLawyers()
        {
            List<EmployeeM> lawyers = new List<EmployeeM>();
            _command.CommandText = "SELECT ID, FirstName, LastName FROM Employee WHERE Position = 'Advokat'";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeM e = new EmployeeM();
                    e.Id = Convert.ToInt32(reader["ID"]);
                    e.FirstName = $"{reader["FirstName"].ToString()}";
                    e.LastName =  $"{reader["LastName"].ToString()}";
                    lawyers.Add(e);
                }

            }
            _connection.Close();
            return lawyers;

        }
        internal List<EmployeeM> GetEmplNames()
        {
            List<EmployeeM> emplNames = new List<EmployeeM>();
            _command.CommandText = "SELECT ID, FirstName, LastName FROM Employee";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeM e = new EmployeeM();
                    e.Id = Convert.ToInt32(reader["ID"]);
                    e.FirstName = $"{reader["FirstName"].ToString()}";
                    e.LastName = $"{reader["LastName"].ToString()}";
                    emplNames.Add(e);
                }

            }
            _connection.Close();
            return emplNames;
        }

        //public ClientM GetClient(string tlf)
        //{
        //    ClientM c = new ClientM();
        //    _command.CommandText = "SELECT * FROM Client WHERE TlfNo = @tlf";
        //    _command.Parameters.Clear();

        //    _command.Parameters.Add(new SqlParameter("@tlf", tlf));
        //    PrepareSql();
        //    SqlDataReader reader = null;
        //    reader = _command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //             c.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
        //            c.CprNo = reader["CprNo"] != DBNull.Value ? reader["CprNo"].ToString() : string.Empty; //Skal denne være string empty?
        //            c.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
        //            c.FirstName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
        //            c.Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
        //            c.PostNo = reader["PostNo"] != DBNull.Value ? Convert.ToInt32(reader["PostNo"]) : default(int);
        //            c.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
        //            c.TlfNo = reader["TlfNo"] != DBNull.Value ? reader["TlfNo"].ToString() : string.Empty; //samme her

        //        }
        //    }
        //    _connection.Close();
        //    return c;
        //}



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
