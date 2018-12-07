﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class SqlSubject : ISubject
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        public SqlSubject()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());

        }
        private void PrepareSql()
        {
            _connection.Open();
            _command.Connection = _connection;
        }
        private int ExecuteNonQuery()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            _connection.Close();
            return rows;
        }


        public int DeleteSubject(int id)
        {
            _command.CommandText = $"DELETE FROM Subject WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery();
        }

        public List<SubjectM> GetEmployeeSubjectById(int id)
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

        public List<SubjectM> GetSubjects()
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

        public int NewSubject(SubjectM subject)
        {
            string sqlString = "INSERT INTO LegalServices (Name, HoursEstimate, Price, TimeEstimate) VALUES " +
                    " (@Name, @HoursEstimate, @Price, @TimeEstimate)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Name", subject.Name));
            _command.Parameters.Add(new SqlParameter("@HoursEstimate", subject.HoursEstimate));
            _command.Parameters.Add(new SqlParameter("@Price", subject.Price));
            _command.Parameters.Add(new SqlParameter("@TimeEstimate", subject.TimeEstimate));
            return ExecuteNonQuery();
        }

        public int UpdateSubject(SubjectM subject)
        {
            _command.CommandText = "UPDATE Subject SET Name = @name, HoursEstimale = @hours, TimeEstimate = @time," +
                                  " Price = @price WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", subject.Id));
            _command.Parameters.Add(new SqlParameter("@name", subject.Name));
            _command.Parameters.Add(new SqlParameter("@hours", subject.HoursEstimate));
            _command.Parameters.Add(new SqlParameter("@time", subject.TimeEstimate));
            _command.Parameters.Add(new SqlParameter("@price", subject.Price));
            return ExecuteNonQuery();
        }
    }
}
