using LawHouseLibrary.Entities;
using System.Data.SqlClient;

namespace DataAccess
{
    class SqlNonQuery
    {
        private SqlConnection _connection;
        private SqlCommand _command = new SqlCommand();
        private SqlCreate _create;
        private SqlUpdate _update;
        private SqlDelete _delete;

        public SqlNonQuery(SqlConnection connection)
        {
            _create = new SqlCreate();
            _update = new SqlUpdate();
            _delete = new SqlDelete();
            _connection = connection;
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

        internal int NewCase(CaseE c1)
        {
            _command = _create.NewCase(c1);
            return ExecuteNonQuery();
        }


        internal int NewService(ServiceE s1)
        {
            _command = _create.NewService(s1);
            return ExecuteNonQuery();

        }
        internal int NewClient(ClientE client)
        {
            _command = _create.NewClient(client);
            return ExecuteNonQuery();
        }

        internal int NewEmployee(EmployeeE employee)
        {
            _command = _create.NewEmployee(employee);
            return ExecuteNonQuery();
        }

        internal int NewLegalService(LegalServiceE ls1)
        {
            _command = _create.NewLegalService(ls1);
            return ExecuteNonQuery();
        }

        internal int NewField(string name)
        {
            _command = _create.NewField(name);
            return ExecuteNonQuery();
        }
        internal int AddFieldToEmployee(int id, string name)
        {
            _command = _create.AddFieldToEmployee(id, name);
            return ExecuteNonQuery();
        }


        internal int UpdateCase(CaseE c1)
        {
            _command = _update.UpdateCase(c1);
            return ExecuteNonQuery();
        }
        internal int UpdateLegalService(LegalServiceE ls)
        {
            _command = _update.UpdateLegalService(ls);
            return ExecuteNonQuery();
        }

        internal int UpdateClient(ClientE client)
        {
            _command = _update.UpdateClient(client);
            return ExecuteNonQuery();
        }

        internal int UpdateEmployee(EmployeeE emp)
        {
            _command = _update.UpdateEmployee(emp);
            return ExecuteNonQuery();
        }

        internal int CloseCase(CaseE c1)
        {
            _command = _update.CloseCase(c1);
            return ExecuteNonQuery();
        }
        internal int CloseClient(string cpr)
        {
           _command = _update.CloseClient(cpr);
            return ExecuteNonQuery();
        }

        internal int CloseEmployee(int id)
        {
            _command = _update.CloseEmployee(id);
            return ExecuteNonQuery();
        }

        internal int UpdateService (ServiceE s1)
        {
            _command = _update.UpdateService(s1);
            return ExecuteNonQuery();
        }

        internal int DeleteService(int id)
        {
            _command = _delete.DeleteService(id);
            return ExecuteNonQuery();
        }

        internal int DeleteCase(int id)
        {
            _command = _delete.DeleteCase(id);
            return ExecuteNonQuery();
        }
        internal int DeleteLegalService(int id)
        {
            _command = _delete.DeleteLegalService(id);
            return ExecuteNonQuery();
        }

        internal int DeleteField(string name)
        {
            _command = _delete.DeleteField(name);
            return ExecuteNonQuery();
        }

    }
}
