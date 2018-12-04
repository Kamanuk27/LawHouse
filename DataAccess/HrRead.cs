using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    class HrRead
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        public HrRead(SqlConnection connection)
        {
            _command = new SqlCommand();
            _connection = connection;
        }
        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
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
                    ls1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
                    ls1.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : default(decimal);
                    ls1.TimeEstimate = reader["TimeEstimate"] != DBNull.Value ? Convert.ToInt32(reader["TimeEstimate"]) : default(int);


                    legServices.Add(ls1);
                }

            }
            _connection.Close();
            return legServices;
        }

        internal List<FieldE> GetFields()
        {
            List<FieldE> fields = new List<FieldE>();
            _command.CommandText = "SELECT*FROM Field";

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FieldE f = new FieldE();
                    f.Id = Convert.ToInt32(reader["ID"]);
                    f.Name = reader["Name"].ToString();
                    fields.Add(f);
                }

            }
            _connection.Close();
            return fields;
        }

        public List<FieldE> GetEmpFields(int id)
        {
            List<FieldE> fields = new List<FieldE>();
            _command.CommandText = "SELECT*FROM [dbo].[Field] WHERE [ID] IN " +
                                   "(SELECT Field_ID FROM [dbo].[EmployeeFields] WHERE Employee_ID = @id)";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    FieldE f = new FieldE();
                    f.Id = Convert.ToInt32(reader["ID"]);
                    f.Name = reader["Name"].ToString();
                    fields.Add(f);
                }

            }
            _connection.Close();
            return fields;
        }

        public List<EmployeeE> GetEmployees()
        {
            List<EmployeeE> employees = new List<EmployeeE>();
            _command.CommandText = "SELECT * FROM Employee";
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeE e = new EmployeeE();

                    e.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    e.CprNo = reader["CprNo"] != DBNull.Value ? reader["CprNo"].ToString() : string.Empty;
                    e.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
                    e.FirstName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
                    e.Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
                    e.PostNo = reader["PostNo"] != DBNull.Value ? Convert.ToInt32(reader["PostNo"]) : default(int);
                    e.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
                    e.TlfNo = reader["TlfNo"] != DBNull.Value ? reader["TlfNo"].ToString() : string.Empty;
                    e.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    e.Position = reader["Position"] != DBNull.Value ? reader["Position"].ToString() : string.Empty;
                    e.PayRatePrHour = reader["ID"] != DBNull.Value ? Convert.ToDecimal(reader["ID"]) : default(decimal);

                    employees.Add(e);
                }
            }
            _connection.Close();
            return employees; ;
        }

    }
}
