﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Sql;
using LawHouseLibrary.Models;

namespace DataAccess
{
   internal class SqlEmployee : SqlBase, IEmployee
   {
        
        public int NewEmployee(EmployeeM e)
        {
            string sqlString = "INSERT INTO Employee (CprNo, FirstName, LastName, Address, PostNo, Email, TlfNo, StartDate, Position, PayRatePrHour) VALUES " +
                               " (@CprNo, @FirstName, @LastName, @Address, @PostNo, @Email, @TlfNo, @StartDate, @Position, @PayRatePrHour)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CprNo", e.CprNo));
            _command.Parameters.Add(new SqlParameter("@FirstName", e.FirstName));
            _command.Parameters.Add(new SqlParameter("@LastName", e.LastName));
            _command.Parameters.Add(new SqlParameter("@Address", e.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", e.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", e.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", e.TlfNo));
            _command.Parameters.Add(new SqlParameter("@StartDate", e.StartDate));
            _command.Parameters.Add(new SqlParameter("@Position", e.Position));
            _command.Parameters.Add(new SqlParameter("@PayRatePrHour", e.PayRatePrHour));
            return ExecuteNonQuery();
        }

        public List<EmployeeM> GetEmployees()
        {
            List<EmployeeM> employees = new List<EmployeeM>();
            _command.CommandText = "SELECT * FROM Employee";
            PrepareSql();
            SqlDataReader reader = null;
            reader = _command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeM e = new EmployeeM();

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

        public int UpdateEmployee(EmployeeM e)
        {
            _command.CommandText = "UPDATE Employee SET FirstName = @fName, LastName = @lName, " +
                                   "Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo," +
                                   "Position = @Position, PayRatePrHour = @PayRatePrHour WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@fName", e.FirstName));
            _command.Parameters.Add(new SqlParameter("@lName", e.LastName));
            _command.Parameters.Add(new SqlParameter("@id", e.Id));
            _command.Parameters.Add(new SqlParameter("@Address", e.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", e.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", e.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", e.TlfNo));
            _command.Parameters.Add(new SqlParameter("@Position", e.Position));
            _command.Parameters.Add(new SqlParameter("@PayRatePrHour", e.PayRatePrHour));
            return ExecuteNonQuery();
        }

        public int CloseEmployee(int id)
        {
            _command.CommandText = "UPDATE Employee SET Address = null, PostNo = null, Email = null,  CprNo = null " +
                                   "Position = null, PayRatePrHour = null  WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            return ExecuteNonQuery();
        }
        public int AddSpecializationToEmployee(int eId, int sId)
        {
            string sqlString = "INSERT INTO [dbo].[Specialization] (Employee_ID, Subject_ID) " +
                               " VALUES (@eId, @sId)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@eId", eId));
            _command.Parameters.Add(new SqlParameter("@sId", sId));
            return ExecuteNonQuery();
        }
       public List<EmployeeM> GetLawyers()
       {
           List<EmployeeM> lawyers = new List<EmployeeM>();
           this._command.CommandText = "SELECT ID, FirstName, LastName FROM Employee WHERE Position = 'Advokat'";

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
                   lawyers.Add(e);
               }

           }
           _connection.Close();
           return lawyers;

       }
       public List<EmployeeM> GetEmplNames()
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

    }
}