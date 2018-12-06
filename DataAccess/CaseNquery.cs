using LawHouseLibrary.Models;
using System;
using System.Data.SqlClient;

namespace DataAccess
{
    class CaseNquery
    {
        private SqlConnection _connection;
        private SqlCommand _command;
       
        public CaseNquery(SqlConnection connection)
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
        internal int NewCase(CaseM c1)
        {
            string sqlString = "INSERT INTO  [dbo].[Case] (CaseName, StartDate, NegotiatedPrice, Service_ID, " +
                              "RespEmp_ID, Client_ID) VALUES " +
                              "(@CaseName, @StartDate, @NegotiatedPrice, @Service_ID, @Client_ID, @RespEmp_ID)"; 
                            

            _command.CommandText = sqlString;
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@CaseName", c1.Name));
            _command.Parameters.Add(new SqlParameter("@StartDate", c1.StartDate));
            _command.Parameters.Add(new SqlParameter("@NegotiatedPrice", c1.NegPrice));

            _command.Parameters.Add(new SqlParameter("@Service_ID", c1.SubjectId));
            _command.Parameters.Add(new SqlParameter("@Client_ID", c1.ClientId));
            _command.Parameters.Add(new SqlParameter("@RespEmp_ID", c1.RespEmpId));


            return ExecuteNonQuery();
        }


        internal int NewProvidedService(ProvidedServiceM s1)
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
            return ExecuteNonQuery();

        }
        internal int NewClient(ClientM client)
        {
            string sqlString = "INSERT INTO Client (CprNo, FirstName, LastName, Address, PostNo, Email, TlfNo) " +
                                 "VALUES (@CprNo, @FirstName, @LastName, @Address, @PostNo, @Email, @TlfNo)";

            _command.CommandText = sqlString;
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@CprNo", client.CprNo));
            _command.Parameters.Add(new SqlParameter("@FirstName", client.FirstName));
            _command.Parameters.Add(new SqlParameter("@LastName", client.LastName));
            _command.Parameters.Add(new SqlParameter("@Address", client.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", client.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", client.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", client.TlfNo));
            return ExecuteNonQuery();
        }

        // To update
        internal int UpdateCase(CaseM c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET NegotiatedPrice = @negPrice, RespEmp_ID = " +
                              "(SELECT ID FROM Employee WHERE FirstName = @fName AND LastName = @lName)" +
                              "WHERE ID = @id";
            _command.Parameters.Clear();

            string[] names = c1.RespEmployee.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _command.Parameters.Add(new SqlParameter("@negPrice", c1.NegPrice));
            _command.Parameters.Add(new SqlParameter("@fName", names[0]));
            _command.Parameters.Add(new SqlParameter("@lName", names[1]));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));
            return ExecuteNonQuery();
        }
       
        internal int UpdateClient(ClientM client)
        {
            _command.CommandText = "UPDATE Client SET Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo " +
                                  "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", client.Id));
            _command.Parameters.Add(new SqlParameter("@Address", client.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", client.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", client.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", client.TlfNo));
            return ExecuteNonQuery();
        }

        internal int CloseCase(CaseM c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET TotalPrice = @totalPrice, EndDate = @endDate WHERE ID = @id";
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@totalPrice", c1.TotalPrice));
            _command.Parameters.Add(new SqlParameter("@endDate", c1.EndDate));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));
            return ExecuteNonQuery();
        }
        internal int CloseClient(int id)
        {
            _command.CommandText = "UPDATE Client SET CprNo = null, FirstName = null, LastName = null, " +
                                   "Address = null, PostNo = null, Email = null WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));

            return ExecuteNonQuery();
        }

        internal int UpdateProvidedService (ProvidedServiceM s1)
        {
            _command.CommandText = "UPDATE [dbo].[ProvidedService] SET Date = @Date, Hours = @Hours, Km = @Km WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@id", s1.Id));

            return ExecuteNonQuery();
        }

        // To delete
        internal int DeleteProvidedService(int id)
        {
            _command.CommandText = $"DELETE FROM ProvidedService WHERE ID = @Id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("Id", id));
            return ExecuteNonQuery();
        }

        internal int DeleteCase(int id)
        {
            _command.CommandText = $"DELETE FROM [dbo].[Case] WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery();
        }
    }
}
