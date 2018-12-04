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
    class HrNonQuery
    {
        SqlConnection _connection;
        private SqlCommand _command;
        public HrNonQuery(SqlConnection connection)
        {
            _connection = connection;
            _command = new SqlCommand();
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

        // To Create
        internal int NewEmployee(EmployeeE e)
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

        internal int NewLegalService(LegalServiceE ls1)
        {
            string sqlString = "INSERT INTO LegalServices (Name, HoursEstimate, Price, TimeEstimate) VALUES " +
                                " (@Name, @HoursEstimate, @Price, @TimeEstimate)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Name", ls1.Name));
            _command.Parameters.Add(new SqlParameter("@HoursEstimate", ls1.HoursEstimate));
            _command.Parameters.Add(new SqlParameter("@Price", ls1.Price));
            _command.Parameters.Add(new SqlParameter("@TimeEstimate", ls1.TimeEstimate));
            return ExecuteNonQuery();
        }

        internal int NewField(FieldE f)
        {
            string sqlString = "INSERT INTO Field (Name) VALUES (@name)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@name", f.Name));
            return ExecuteNonQuery();
        }
        internal int AddFieldToEmployee(int id, string name)
        {
            string sqlString = "INSERT INTO [dbo].[EmployeeFields] (Employee_ID, Field_ID) " +
                              " VALUES (@id, (SELECT ID FROM Field WHERE Name = @name))";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            _command.Parameters.Add(new SqlParameter("@name", name));
            return ExecuteNonQuery();
        }

        // To update

        internal int UpdateLegalService(LegalServiceE ls)
        {
            _command.CommandText = "UPDATE LegalService SET Name = @name, HoursEstimale = @hours, TimeEstimate = @time," +
                                   " Price = @price WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", ls.Id));
            _command.Parameters.Add(new SqlParameter("@name", ls.Name));
            _command.Parameters.Add(new SqlParameter("@hours", ls.HoursEstimate));
            _command.Parameters.Add(new SqlParameter("@time", ls.TimeEstimate));
            _command.Parameters.Add(new SqlParameter("@price", ls.Price));
            return ExecuteNonQuery();
        }
        internal int UpdateEmployee(EmployeeE e)
        {
            _command.CommandText = "UPDATE Employee SET Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo," +
                                   "Position = @Position, PayRatePrHour = @PayRatePrHour WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", e.Id));
            _command.Parameters.Add(new SqlParameter("@Address", e.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", e.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", e.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", e.TlfNo));
            _command.Parameters.Add(new SqlParameter("@Position", e.Position));
            _command.Parameters.Add(new SqlParameter("@PayRatePrHour", e.PayRatePrHour));
            return ExecuteNonQuery();
        }
        internal int CloseEmployee(int id)
        {
            _command.CommandText = "UPDATE Employee SET Address = null, PostNo = null, Email = null,  TlfNo = null " +
                                   "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            return ExecuteNonQuery();
        }
        // To delete
        internal int DeleteLegalService(int id)
        {
            _command.CommandText = $"DELETE FROM [dbo].[LegalServices] WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery();
        }

        internal int DeleteField(string name)
        {
            _command.CommandText = $"DELETE FROM [dbo].[Field] WHERE Name = @name";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@name", name));
            return ExecuteNonQuery();
        }
    }
}
