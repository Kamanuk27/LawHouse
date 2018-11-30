using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Entities;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    class SqlUpdate
    {
        private SqlCommand _command;
        internal SqlUpdate()
        {
            _command = new SqlCommand();
        }

        internal SqlCommand UpdateCase(CaseE c1)
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

            return _command;

        }

        internal SqlCommand UpdateService(ServiceE s1)
        {
            _command.CommandText = "UPDATE [dbo].[ProvidedService] SET Date = @Date, Hours = @Hours, Km = @Km WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@id", s1.Id));

            return _command;

        }

        internal SqlCommand CloseCase(CaseE c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET TotalPrice = @totalPrice, EndDate = @endDate WHERE ID = @id";
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@totalPrice", c1.TotalPrice));
            _command.Parameters.Add(new SqlParameter("@endDate", c1.EndDate));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));

            return _command;
        }
        internal SqlCommand UpdateEmployee(EmployeeE e1)
        {
            _command.CommandText = "UPDATE Employee SET Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo," +
                                   "Position = @Position, PayRatePrHour = @PayRatePrHour WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", e1.Id));
            _command.Parameters.Add(new SqlParameter("@Address", e1.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", e1.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", e1.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", e1.TlfNo));
            _command.Parameters.Add(new SqlParameter("@Position", e1.Position));
            _command.Parameters.Add(new SqlParameter("@PayRatePrHour", e1.PayRatePrHour));

            return _command;
        }
        internal SqlCommand CloseEmployee(EmployeeE e1)
        {
            _command.CommandText = "UPDATE Employee SET Address = null, PostNo = null, Email = null,  TlfNo = null " +
                                   "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", e1.Id));
            
            return _command;
        }
        internal SqlCommand UpdateClient(ClientE c1)
        {
            _command.CommandText = "UPDATE Client SET Address = @Address, PostNo = @PostNo, Email = @Email,  TlfNo = @TlfNo " +
                                   "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));
            _command.Parameters.Add(new SqlParameter("@Address", c1.Address));
            _command.Parameters.Add(new SqlParameter("@PostNo", c1.PostNo));
            _command.Parameters.Add(new SqlParameter("@Email", c1.Email));
            _command.Parameters.Add(new SqlParameter("@TlfNo", c1.TlfNo));
            
            return _command;
        }
        internal SqlCommand CloseClient(ClientE c1)
        {
            _command.CommandText = "UPDATE Client SET Address = null, PostNo = null, Email = null,  TlfNo = null " +
                                   "WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));

            return _command;
        }
    }
}
