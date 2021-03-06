﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess.Model;
using DataAccess.Repositories;
using System.Data;

namespace DataAccess
{
    internal class SqlAccess : IDataAccess
    {
        private SqlConnection connection;
        private SqlCommand command = new SqlCommand();

        private void PrepareSql(string sqlString)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            connection.Open();
            command.Connection = connection;
            command.CommandText = sqlString;
        }

        
        private int ExecuteSql(string sqlString)
        {
            PrepareSql(sqlString);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }

        public int NewCase(CaseRepo c1)
        {
            string sqlString = "INSERT INTO  [dbo].[Case] (CaseName, StartDate, NegotiatedPrice, Service_ID, " +
                               "RespEmp_ID, Client_ID) VALUES " +
                               "(@CaseName, @StartDate, @NegotiatedPrice, @Service_ID, @RespEmp_ID, @Client_ID)";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@CaseName", c1.Name));
            command.Parameters.Add(new SqlParameter("@StartDate", c1.StartDate));
            command.Parameters.Add(new SqlParameter("@NegotiatedPrice", c1.NegPrice));
            command.Parameters.Add(new SqlParameter("@Service_ID", c1.Service));
            command.Parameters.Add(new SqlParameter("@RespEmp_ID", c1.RespEmployee));
            command.Parameters.Add(new SqlParameter("@Client_ID", c1.Client));

            return ExecuteSql(sqlString);
        }
       

        public int NewService(ServiceRepo s1)
        {
            string sqlString = "INSERT INTO ProvidedService (Employee_ID, Case_ID, Date, Hours, Km, Comment) VALUES " +
                                                        "((SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName)," +
                               " @Case_ID, @Date, @Hours, @Km, @Comment)";
            string[] names = s1.EmployeeName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@Case_ID", s1.CaseID));
            command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            command.Parameters.Add(new SqlParameter("@Comment", s1.Comment));
            command.Parameters.Add(new SqlParameter("@fName", names[0]));
            command.Parameters.Add(new SqlParameter("@lName", names[1]));
            return ExecuteSql(sqlString);

        }

        public CaseRepo GetCase(int id)
        {
            string sqlString = "SELECT*FROM ViewCases WHERE ID = @id";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@id", id));
            PrepareSql(sqlString);
            CaseRepo c1 = new CaseModel();
            SqlDataReader reader = null;
            reader = command.ExecuteReader();

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

        public List<CaseRepo> GetCases()
        {
            List<CaseRepo> cases = new List<CaseRepo>();

            string sqlString = "SELECT* FROM ViewCases";
            PrepareSql(sqlString);
            SqlDataReader reader = null;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CaseModel c1 = new CaseModel();
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

        public List<ServiceRepo> GetProvidedServices(int caseId)
        {
            List < ServiceRepo> services = new List<ServiceRepo>();
            string sqlString = "SELECT * FROM ViewProvidedServices where Case_ID = @caseId";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@caseId", caseId));
            PrepareSql(sqlString);
            SqlDataReader reader = null;
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ServiceModel s1 = new ServiceModel();

                    s1.ID = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
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

      
        public int UpdateCase(CaseRepo c1)
        {
            string sqlString = "UPDATE [dbo].[Case] SET NegotiatedPrice = @negPrice, RespEmp_ID = " +
                               "(SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName)" +
                               "WHERE ID = @id";
            command.Parameters.Clear();

            string[] names = c1.RespEmployee.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            command.Parameters.Add(new SqlParameter("@negPrice", c1.NegPrice));
            command.Parameters.Add(new SqlParameter("@fName", names[0]));
            command.Parameters.Add(new SqlParameter("@lName", names[1]));
            command.Parameters.Add(new SqlParameter("@id", c1.Id));

            return ExecuteSql(sqlString);

        }

        public decimal GetPrice(int id)
        {
            command.CommandText = "CalculatePrice";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@price", System.Data.SqlDbType.Decimal));
            command.Parameters.Add(new SqlParameter("@id", id));
            
            command.Parameters["@price"].Direction = ParameterDirection.Output;

            ExecuteSql(command.CommandText);
            
            decimal price = Convert.ToDecimal(command.Parameters["@price"].Value);

            command = new SqlCommand();
            return price;
        }
        public int CloseCase(CaseRepo c1)
        {
            string sqlString = "UPDATE [dbo].[Case] SET TotalPrice = @totalPrice, EndDate = @endDate WHERE ID = @id";
            command.Parameters.Clear();

            command.Parameters.Add(new SqlParameter("@totalPrice", c1.TotalPrice));
            command.Parameters.Add(new SqlParameter("@endDate", c1.EndDate));
            command.Parameters.Add(new SqlParameter("@id", c1.Id));

            return ExecuteSql(sqlString);
        }
        public int UpdateService(ServiceRepo s1)
        {
            string sqlString = "UPDATE [dbo].[ProvidedService] SET Date = @Date, Hours = @Hours, Km = @Km, Comment = @comment WHERE ID = @id";

            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            command.Parameters.Add(new SqlParameter("@id", s1.ID));
            command.Parameters.Add(new SqlParameter("@comment", s1.Comment));
            return ExecuteSql(sqlString);

        }

        public int DeleteCase(int id)
        {
            string sqlString = $"DELETE FROM [dbo].[Case] WHERE ID = @id";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@id", id));
            return ExecuteSql(sqlString);
        }

        public int DeleteService(int id)
        {
            string sqlString = $"DELETE FROM ProvidedService WHERE ID = @Id";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("Id", id));
            return ExecuteSql(sqlString);
        }

        public List<string> GetLawyers()
        {
            List<string> lawyers = new List<string>();
            string sqlString = "SELECT FirstName, LastName FROM Employee WHERE Position = 'Advokat'";
         
            PrepareSql(sqlString);
            SqlDataReader reader = null;
            reader = command.ExecuteReader();
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

        public List<string> GetEmplNames()
        {
            List<string> emplNames = new List<string>();
            string sqlString = "SELECT FirstName, LastName FROM Employee";

            PrepareSql(sqlString);
            SqlDataReader reader = null;
            reader = command.ExecuteReader();
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
    }
}
