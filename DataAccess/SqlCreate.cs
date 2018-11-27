﻿using DataAccess.Repositories;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System;

namespace DataAccess
{
    class SqlCreate
    {
        private SqlCommand _command;
        public SqlCreate()
        {
            _command = new SqlCommand();
        }
        internal SqlCommand NewCase(CaseRepo c1)
        {
            string sqlString = "INSERT INTO  [dbo].[Case] (CaseName, StartDate, NegotiatedPrice, Service_ID, " +
                               "RespEmp_ID, Client_ID) VALUES " +
                               "(@CaseName, @StartDate, @NegotiatedPrice, @Service_ID, @RespEmp_ID, @Client_ID)";

            _command.CommandText = sqlString;

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CaseName", c1.Name));
            _command.Parameters.Add(new SqlParameter("@StartDate", c1.StartDate));
            _command.Parameters.Add(new SqlParameter("@NegotiatedPrice", c1.NegPrice));
            _command.Parameters.Add(new SqlParameter("@Service_ID", c1.Service));
            _command.Parameters.Add(new SqlParameter("@RespEmp_ID", c1.RespEmployee));
            _command.Parameters.Add(new SqlParameter("@Client_ID", c1.Client));


            return _command;
        }

        public SqlCommand NewService(ServiceRepo s1)
        {
            string sqlString = "INSERT INTO ProvidedService (Employee_ID, Case_ID, Date, Hours, Km, Comment) VALUES " +
                                                        "((SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName)," +
                               " @Case_ID, @Date, @Hours, @Km, @Comment)";

            _command.CommandText = sqlString;

            string[] names = s1.EmployeeName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Case_ID", s1.CaseID));
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@Comment", s1.Comment));
            _command.Parameters.Add(new SqlParameter("@fName", names[0]));
            _command.Parameters.Add(new SqlParameter("@lName", names[1]));

            return _command;

        }
    }
}
