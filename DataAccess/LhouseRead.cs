using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    class LhouseRead
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        public LhouseRead(SqlConnection connection)
        {
            _command = new SqlCommand();
            _connection = connection;
        }
        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }

        internal List<SubjectM> GetSubjects()
        {
            List<SubjectM> subjects = new List<SubjectM>();
            _command.CommandText = "SELECT * FROM Subject";
            _command.Parameters.Clear();
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SubjectM ls1 = new SubjectM();

                    ls1.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
                    ls1.Name = reader["Name"] != DBNull.Value ? reader["Name"].ToString() : string.Empty;
                    ls1.HoursEstimate = reader["HoursEstimate"] != DBNull.Value ? Convert.ToInt32(reader["HoursEstimate"]) : default(int);
                    ls1.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : default(decimal);
                    ls1.TimeEstimate = reader["TimeEstimate"] != DBNull.Value ? Convert.ToInt32(reader["TimeEstimate"]) : default(int);


                    subjects.Add(ls1);
                }

            }
            _connection.Close();
            return subjects;
        }
       
        // her skal det læses fra Specializations
        public List<SubjectM> GetEmpSpecializations(int id)
        {
            List<SubjectM> fields = new List<SubjectM>();
            _command.CommandText = "SELECT*FROM Subject WHERE [ID] IN " +
                                   "(SELECT Subject_ID FROM Specialization WHERE Employee_ID = @id)";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SubjectM f = new SubjectM();
                    f.Id = Convert.ToInt32(reader["ID"]);
                    f.Name = reader["Name"].ToString();
                    fields.Add(f);
                }

            }
            _connection.Close();
            return fields;
        }

        //public List<EmployeeM> GetEmployees()
        //{
        //    List<EmployeeM> employees = new List<EmployeeM>();
        //    _command.CommandText = "SELECT * FROM Employee";
        //    PrepareSql();
        //    SqlDataReader reader = null;
        //    reader = _command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            EmployeeM e = new EmployeeM();

        //            e.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : default(int);
        //            e.CprNo = reader["CprNo"] != DBNull.Value ? reader["CprNo"].ToString() : string.Empty;
        //            e.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
        //            e.FirstName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
        //            e.Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
        //            e.PostNo = reader["PostNo"] != DBNull.Value ? Convert.ToInt32(reader["PostNo"]) : default(int);
        //            e.Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
        //            e.TlfNo = reader["TlfNo"] != DBNull.Value ? reader["TlfNo"].ToString() : string.Empty;
        //            e.StartDate = Convert.ToDateTime(reader["StartDate"]);
        //            e.Position = reader["Position"] != DBNull.Value ? reader["Position"].ToString() : string.Empty;
        //            e.PayRatePrHour = reader["ID"] != DBNull.Value ? Convert.ToDecimal(reader["ID"]) : default(decimal);

        //            employees.Add(e);
        //        }
        //    }
        //    _connection.Close();
        //    return employees; ;
        //}

    }
}
