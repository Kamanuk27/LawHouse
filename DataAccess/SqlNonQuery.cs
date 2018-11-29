using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    class SqlNonQuery
    {
        private SqlConnection connection;
        private SqlCommand _command = new SqlCommand();
        private SqlCreate _create;
        private SqlUpdate _update;
        private SqlDelete _delete;

        public SqlNonQuery()
        {
            _create = new SqlCreate();
            _update = new SqlUpdate();
            _delete = new SqlDelete();
        }

        private void PrepareSql()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            connection.Open();
            _command.Connection = connection;
        }


        private int ExecuteNonQuery()
        {
            PrepareSql();
            int rows = _command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }

        internal int NewCase(Case c1)
        {
            _command = _create.NewCase(c1);
            return ExecuteNonQuery();
        }


        internal int NewService(Service s1)
        {
            _command = _create.NewService(s1);
            return ExecuteNonQuery();

        }

        internal int UpdateCase(Case c1)
        {
            _command = _update.UpdateCase(c1);
            return ExecuteNonQuery();
        }

        internal int NewClient(Client client)
        {
            _command = _create.NewClient(client);
            return ExecuteNonQuery();
        }
        internal int NewEmployee(Employee employee)
        {
            _command = _create.NewEmployee(employee);
            return ExecuteNonQuery();
        }
        internal int NewLegalService(LegalService legal)
        {
            _command = _create.NewLegalService(legal);
            return ExecuteNonQuery();
        }
        

        internal int CloseCase(Case c1)
        {
            _command = _update.CloseCase(c1);
            return ExecuteNonQuery();
        }

        internal int UpdateService (Service s1)
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

    }
}
