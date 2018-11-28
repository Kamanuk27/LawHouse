using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
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

        internal SqlCommand UpdateCase(CaseRepo c1)
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

        internal SqlCommand UpdateService(ServiceRepo s1)
        {
            _command.CommandText = "UPDATE [dbo].[ProvidedService] SET Date = @Date, Hours = @Hours, Km = @Km WHERE ID = @id";

            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@Date", s1.Date));
            _command.Parameters.Add(new SqlParameter("@Hours", s1.Hours));
            _command.Parameters.Add(new SqlParameter("@Km", s1.Km));
            _command.Parameters.Add(new SqlParameter("@id", s1.ID));

            return _command;

        }

        internal SqlCommand CloseCase(CaseRepo c1)
        {
            _command.CommandText = "UPDATE [dbo].[Case] SET TotalPrice = @totalPrice, EndDate = @endDate WHERE ID = @id";
            _command.Parameters.Clear();

            _command.Parameters.Add(new SqlParameter("@totalPrice", c1.TotalPrice));
            _command.Parameters.Add(new SqlParameter("@endDate", c1.EndDate));
            _command.Parameters.Add(new SqlParameter("@id", c1.Id));

            return _command;
        }
    }
}
