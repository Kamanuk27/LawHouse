using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using LawHouseLibrary;

namespace DataAccess
{
    class DatabaseAccess : IDataAccess
    {
        private SqlConnection connection;
        private SqlCommand command = new SqlCommand();

       
        private string GetConnectionString()
        {
            return "Data Source = den1.mssql8.gear.host; Initial catalog = lawhouse; User ID = lawhouse; password = Kx584_?EtT5O";
             
        }

        //Metoden åbner SQL-connection og indeholder command.
        private void PrepareSql(string sqlString)
        {
            connection = new SqlConnection (GetConnectionString());
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


        public CaseModel GetCase(int id)
        {
            string sqlString = "SELECT*FROM [dbo].[Case] WHERE ID = @id";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@id", id));
            PrepareSql(sqlString);
            CaseModel c1 = new CaseModel();
            SqlDataReader reader = null;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["CaseName"] != DBNull.Value ? reader["CaseName"].ToString() : String.Empty;
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
                    //c1.EndDate = Convert.ToDateTime(reader["EndDate"]);
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = reader ["TotalPrice"] != DBNull.Value ? Convert.ToDecimal(reader["TotalPrice"]) : default(decimal);
                    c1.Service = reader["Service_ID"] != DBNull.Value ? reader["Service_ID"].ToString() : string.Empty;
                    c1.Client = reader["Client_ID"] != DBNull.Value ? reader["Client_ID"].ToString() : string.Empty;
                    c1.Service = reader["RespEmp_ID"] != DBNull.Value ? reader["RespEmp_ID"].ToString() : string.Empty;
                }
            }
            connection.Close();
            return c1;
        }

        public List<CaseModel> GetCases()
        {
            List<CaseModel> cases = new List<CaseModel>();
           
            string sqlString = "SELECT* FORM Case";
            PrepareSql(sqlString);
            SqlDataReader reader = null;
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CaseModel c1 = new CaseModel();
                    c1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    c1.Name = reader["Name"] != DBNull.Value ? reader["ID"].ToString() : String.Empty;
                    c1.StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : DateTime.Now;
                    c1.EndDate = Convert.ToDateTime(reader["EndDate"]);
                    c1.NegPrice = reader["NegotiatedPrice"] != DBNull.Value ? Convert.ToDecimal(reader["NegotiatedPrice"]) : default(decimal);
                    c1.TotalPrice = Convert.ToDecimal(reader["TotalPrice"]);
                    c1.Service = reader["Service_ID"] != DBNull.Value ? reader["Service_ID"].ToString() : string.Empty;
                    c1.Client = reader["Client_ID"] != DBNull.Value ? reader["Client_ID"].ToString() : string.Empty;
                    c1.RespEmployee = reader["RespEmp_ID"] != DBNull.Value ? reader["RespEmp_ID"].ToString() : string.Empty;

                    cases.Add(c1);
                }
            }
            connection.Close();
            return cases;
        }
    }
}
