﻿using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class SqlLhouseDataAccess : ILhouseDataAccess
    {
        private LhouseNquery _nonQuery;
        private LhouseRead _read;
        private SqlConnection _connection;

        public SqlLhouseDataAccess()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _nonQuery = new LhouseNquery(_connection);
            _read = new LhouseRead(_connection);
        }

        public int NewEmployee(EmployeeE employee)
        {
            return _nonQuery.NewEmployee(employee);
        }
        public int NewLegalService(LegalServiceE legal)
        {
            return _nonQuery.NewLegalService(legal);
        }
        public int NewField(FieldE f)
        {
            return _nonQuery.NewField(f);
        }
        public int AddFieldToEmployee(int eId, int fId)
        {
            return _nonQuery.AddFieldToEmployee(eId, fId);
        }


        public List<LegalServiceE> GetLegalServices()
        {
            return _read.GetLegalServices();
        }
        public List<FieldE> GetFields()
        {
            return _read.GetFields();
        }

        public List<FieldE> GetEmpFields(int id)
        {
            return _read.GetEmpFields(id);
        }

        public List<EmployeeE> GetEmployees()
        {
            return _read.GetEmployees();
        }


        public int UpdateLegalService(LegalServiceE ls)
        {
            return _nonQuery.UpdateLegalService(ls);
        }

        public int UpdateEmployee(EmployeeE emp)
        {
            return _nonQuery.UpdateEmployee(emp);
        }

        public int CloseEmployee(int id)
        {
            return _nonQuery.CloseEmployee(id);
        }

        // To delete
        public int DeleteLegalService(int id)
        {
            return _nonQuery.DeleteLegalService(id);
        }

        public int DeleteField(int id)
        {
            return _nonQuery.DeleteField(id);
        }


    }
}
