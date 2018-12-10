using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess.Sql;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class SqlCase : SqlBase, ICase
    {
              
        public int NewCase(CaseM c1)
        {
            string sqlString = "INSERT INTO  [dbo].[Case] (CaseName, StartDate, NegotiatedPrice, Service_ID, " +
                              "RespEmp_ID, Client_ID) VALUES " +
                              "(@CaseName, @StartDate, @NegotiatedPrice, @Service_ID, @Client_ID, @RespEmp_ID)";


            _command.CommandText = sqlString;
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@CaseName", c1.Name));
            _command.Parameters.Add(new SqlParameter("@StartDate", c1.StartDate));
            _command.Parameters.Add(new SqlParameter("@NegotiatedPrice", c1.NegPrice));

            _command.Parameters.Add(new SqlParameter("@Service_ID", c1.SubjectId));
            _command.Parameters.Add(new SqlParameter("@Client_ID", c1.ClientId));
            _command.Parameters.Add(new SqlParameter("@RespEmp_ID", c1.RespEmpId));


            return ExecuteNonQuery();
        }
        public List<CaseM> GetCases()
        {
            List<CaseM> cases = new List<CaseM>();

            _command.CommandText = "SELECT c.*, e.FirstName AS eFName, e.LastName AS eLName, cl.FirstName AS cFName, cl.LastName AS cLName, " +
                                   "sb.[Name] AS subjectName, sb.TimeEstimate, sb.HoursEstimate FROM[Case] c JOIN Employee e ON c.RespEmp_ID = e.ID" +
                                   " JOIN Client cl ON c.Client_ID = cl.ID JOIN[Subject] sb ON c.Subject_ID = sb.ID WHERE c.TotalPrice IS NULL";
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CaseM c1 = new CaseM();
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
                    c1.EndDate = c1.StartDate + TimeSpan.FromDays(Convert.ToInt32(reader["TimeEstimate"]));
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
                    c1.Subject = reader["SubjectName"] != DBNull.Value ? reader["SubjectName"].ToString() : string.Empty;

                    c1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
                    c1.Client = $"{(reader["cFName"] != DBNull.Value ? reader["cFName"].ToString() : string.Empty)} " +
                                $"{(reader["cLName"] != DBNull.Value ? reader["cLName"].ToString() : string.Empty)}";

                    c1.RespEmployee = $"{(reader["eFName"] != DBNull.Value ? reader["eFName"].ToString() : string.Empty)} " +
                                      $"{(reader["eLName"] != DBNull.Value ? reader["eLName"].ToString() : string.Empty)}";

                    cases.Add(c1);
                }

            }
            _connection.Close();
            return cases;
        }


        public int UpdateCase(CaseM c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET NegotiatedPrice = @negPrice, RespEmp_ID = @respEmpId" +
                               "WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@negPrice", c1.NegPrice));
            _command.Parameters.Add(new SqlParameter("@respEmpId", c1.RespEmpId));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));
            return ExecuteNonQuery();
        }

        public int CloseCase(CaseM c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET TotalPrice = @totalPrice, EndDate = @endDate WHERE ID = @id";
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@totalPrice", c1.TotalPrice));
            _command.Parameters.Add(new SqlParameter("@endDate", c1.EndDate));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));
            return ExecuteNonQuery();
        }

        public int DeleteCase(int id)
        {
            _command.CommandText = $"DELETE FROM [dbo].[Case] WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery();
        }
    }
}
