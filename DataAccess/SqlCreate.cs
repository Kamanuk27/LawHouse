
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using LawHouseLibrary.Entities;
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
        internal SqlCommand NewCase(CaseE c1)
        {
            string sqlString = "INSERT INTO  [dbo].[Case] (CaseName, StartDate, NegotiatedPrice, Service_ID, " +
                               "RespEmp_ID, Client_ID) VALUES " +
                               "(@CaseName, @StartDate, @NegotiatedPrice, " +
                               "(SELECT ID FROM LegalServices WHERE Name = @Service_ID), " +
                               "(SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName), " +
                               "(SELECT ID FROM Client WHERE FirstName = @fCName AND LastName = @lCName))";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@CaseName", c1.Name));
            _command.Parameters.Add(new SqlParameter("@StartDate", c1.StartDate));
            _command.Parameters.Add(new SqlParameter("@NegotiatedPrice", c1.NegPrice));

            _command.Parameters.Add(new SqlParameter("@Service_ID", c1.Service));

            string[] names = c1.RespEmployee.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _command.Parameters.Add(new SqlParameter("@fName", names[0]));
            _command.Parameters.Add(new SqlParameter("@lName", names[1]));

            string[] clientNames = c1.Client.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _command.Parameters.Add(new SqlParameter("@fCName", clientNames[0]));
            _command.Parameters.Add(new SqlParameter("@lCName", clientNames[1]));
            
            return _command;
        }

        public SqlCommand NewService(ServiceE s1)
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
            _command.Parameters.Add(new SqlParameter("@Comment", s1.sType));
            _command.Parameters.Add(new SqlParameter("@fName", names[0]));
            _command.Parameters.Add(new SqlParameter("@lName", names[1]));

            return _command;

        }
        public SqlCommand NewClient(ClientE c1)
        {
            string sqlString = "INSERT INTO Client (CprNo, FirstName, LastName, Address, PostNo, Email, TlfNo) " +
                               "VALUES (@CprNo, @FirstName, @LastName, @Address, @PostNo, @Email, @TlfNo)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CprNo", c1.CprNo));
            _command.Parameters.Add(new SqlParameter("@FirstName", c1.FirstName));
            _command.Parameters.Add(new SqlParameter("@LastName", c1.LastName));
            _command.Parameters.Add(new SqlParameter("@Address", c1.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", c1.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", c1.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", c1.TlfNo));

            return _command;

        }
        public SqlCommand NewEmployee(EmployeeE e1)
        {
            string sqlString = "INSERT INTO Employee (CprNo, FirstName, LastName, Address, PostNo, Email, TlfNo, StartDate, Position, PayRatePrHour) VALUES " +
                               " (@CprNo, @FirstName, @LastName, @Address, @PostNo, @Email, @TlfNo, @StartDate, @Position, @PayRatePrHour)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CprNo", e1.CprNo));
            _command.Parameters.Add(new SqlParameter("@FirstName", e1.FirstName));
            _command.Parameters.Add(new SqlParameter("@LastName", e1.LastName));
            _command.Parameters.Add(new SqlParameter("@Address", e1.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", e1.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", e1.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", e1.TlfNo));
            _command.Parameters.Add(new SqlParameter("@StartDate", e1.StartDate));
            _command.Parameters.Add(new SqlParameter("@Position", e1.Position));
            _command.Parameters.Add(new SqlParameter("@PayRatePrHour", e1.PayRatePrHour));

            return _command;
        
        }
        public SqlCommand NewLegalService(LegalServiceE lS1)
        {
            string sqlString = "INSERT INTO LegalServices (Name, HoursEstimate, Price, TimeEstimate) VALUES " +
                               " (@Name, @HoursEstimate, @Price, @TimeEstimate)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Name", lS1.Name));
            _command.Parameters.Add(new SqlParameter("@HoursEstimate", lS1.HoursEstimate));
            _command.Parameters.Add(new SqlParameter("@Price", lS1.Price));
            _command.Parameters.Add(new SqlParameter("@TimeEstimate", lS1.TimeEstimate));
            return _command;

        }
        internal SqlCommand NewField(string name)
        {
            string sqlString = "INSERT INTO Field (Name) VALUES (@name)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@name", name));
            return _command;

        }
        internal SqlCommand AddFieldToEmployee(int id, string name)
        {
            string sqlString = "INSERT INTO [dbo].[EmployeeFields] (Employee_ID, Field_ID) " +
                               " VALUES (@id, (SELECT ID FROM Field WHERE Name = @name))";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            _command.Parameters.Add(new SqlParameter("@name", name));
            return _command;
        }

    }
}
