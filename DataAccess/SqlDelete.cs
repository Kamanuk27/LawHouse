using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    class SqlDelete
    {
        private SqlCommand _command;
        internal SqlDelete()
        {
            _command = new SqlCommand();
        }

        internal SqlCommand DeleteService(int id)
        {
            _command.CommandText = $"DELETE FROM ProvidedService WHERE ID = @Id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("Id", id));
            return _command;
        }

        internal SqlCommand DeleteCase(int id)
        {
            _command.CommandText = $"DELETE FROM [dbo].[Case] WHERE ID = @id";
            _command.Parameters.Clear();
            _command.Parameters.Add(new SqlParameter("@id", id));
            return _command;
        }
    }
}
