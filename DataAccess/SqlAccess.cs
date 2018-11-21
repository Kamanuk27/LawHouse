using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess.Model;
using DataAccess.Repositories;

namespace DataAccess
{
    class DatabaseAccess : IDataAccess
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

        public CaseRepo GetCase(int id)
        {
            string sqlString = "SELECT*FROM [dbo].[Case] WHERE ID = @id";
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
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]).Date : DateTime.Now.Date;
                    c1.EndDate = reader["EndDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndDate"]).Date : DateTime.MinValue.Date;
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
                    c1.Service = reader["Service_ID"] != DBNull.Value ? reader["Service_ID"].ToString() : string.Empty;
                    c1.Client = reader["Client_ID"] != DBNull.Value ? reader["Client_ID"].ToString() : string.Empty;
                    c1.RespEmployee = reader["RespEmp_ID"] != DBNull.Value ? reader["RespEmp_ID"].ToString() : string.Empty;
                }
            }
            connection.Close();
            return c1;
        }

        public List<CaseRepo> GetCases()
        {
            List<CaseRepo> cases = new List<CaseRepo>();

            string sqlString = "SELECT* FRoM ViewCases";
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
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
                    c1.EndDate = c1.StartDate + TimeSpan.FromDays(Convert.ToInt32(reader["TimeEstimate"]));
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = reader["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
                    c1.Service = reader["ServiceName"] != DBNull.Value ? reader["ServiceName"].ToString() : string.Empty;

                    c1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
                    c1.Client =  $"{(reader["ClientfName"] != DBNull.Value ? reader["ClientfName"].ToString() : string.Empty)} " +
                                 $"{(reader["ClientlName"] != DBNull.Value ? reader["ClientlName"].ToString() : string.Empty)}"; 

                    c1.RespEmployee = $"{(reader["EmployeefName"] != DBNull.Value ? reader["EmployeefName"].ToString() : string.Empty)} " +
                                      $"{(reader["EmployeelName"] != DBNull.Value ? reader["EmployeelName"].ToString() : string.Empty)}";

                    cases.Add(c1);
                }
            }
            connection.Close();
            return cases;
        }

        public List<ServiceRepo> GetProvidedServices()
        {
            List < ServiceRepo> services = new List<ServiceRepo>();
            return services;
        }

        public int EditService(ServiceRepo s1)
        {
            string sqlString = "INSERT INTO ProvidedServises (Employee_ID, Case_ID, Date, Hours, Km, Comment) VALUES " +
                               "(@Employee_ID, @Case_ID, @Date, @Hours, @Km, @Comment)";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@Employee_ID", s1.EmployeeID));
            command.Parameters.Add(new SqlParameter("@Case_ID", s1.CaseID));
            command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            command.Parameters.Add(new SqlParameter("@Comment", s1.Comment));

           
            return ExecuteSql(sqlString);
            
        }

        public int UpdateCase(CaseRepo c1)
        {
            return 1;
        }

        public int DeleteCase(int id)
        {
            return 1;

        }

        public int DeleteService(ServiceRepo s1)
        {
            return 1;
        }
        
    }
}
