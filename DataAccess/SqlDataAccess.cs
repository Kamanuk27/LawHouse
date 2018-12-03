using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using LawHouseLibrary.Entities;

namespace DataAccess
{
    internal class SqlDataAccess : IDataAccess
    {
        private SqlNonQuery _nonQuery;
        private SqlRead _read;
        private SqlConnection _connection;

        public SqlDataAccess()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _nonQuery = new SqlNonQuery(_connection);
            _read = new SqlRead(_connection);
        }

        public int NewCase(CaseE c1)
        {
            return  _nonQuery.NewCase(c1);
        }
       

        public int NewService(ServiceE s1)
        {
           return _nonQuery.NewService(s1);
        }
        public int NewClient(ClientE client)
        {
            return _nonQuery.NewClient(client);
        }

        public int NewEmployee(EmployeeE employee)
        {
            return _nonQuery.NewEmployee(employee);
        }
        public int NewLegalService(LegalServiceE legal)
        {
            return _nonQuery.NewLegalService(legal);
        }

        public List<CaseE> GetCases()
        {
            return _read.GetCases();                                              
        }

        public List<ServiceE> GetProvidedServices(int caseId)
        {
            return _read.GetProvidedServices(caseId);
        }

        public List<LegalServiceE> GetLegalServices()
        {
            return _read.GetLegalServices();
        }


        public int UpdateCase(CaseE c1)
        {
            return _nonQuery.UpdateCase(c1);

        }
        public int CloseCase(CaseE c1)
        {
            return _nonQuery.CloseCase(c1);
        }
        public int UpdateService(ServiceE s1)
        {
            return _nonQuery.UpdateService(s1);
        }

        public int DeleteCase(int id)
        {
            return _nonQuery.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _nonQuery.DeleteService(id);
        }

        public List<string> GetLawyers()
        {
           return _read.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
           return  _read.GetEmplNames();
        }

        public List<decimal> GetUnitPrices()
        {
            return _read.GetUnitPrices();
        }

        public int NewField(string name)
        {
            return _nonQuery.NewField(name);
        }

        public List<FieldE> GetFields()
        {
           return  _read.GetFields();
        }

        public List<FieldE> GetEmpFields(int id)
        {
           return  _read.GetEmpFields(id);
        }

        public List<EmployeeE> GetEmployees()
        {
          return  _read.GetEmployees();
        }

        public ClientE GetClient(string cpr)
        {
            return _read.GetClient(cpr);
        }

        public int UpdateLegalService(LegalServiceE ls)
        {
            return _nonQuery.UpdateLegalService(ls);
        }

        public int UpdateClient(ClientE client)
        {
            return _nonQuery.UpdateClient(client);
        }

        public int UpdateEmployee(EmployeeE emp)
        {
            return _nonQuery.UpdateEmployee(emp);
        }

        public int AddFieldToEmployee(int id, string name)
        {
            return _nonQuery.AddFieldToEmployee(id, name);
        }

        public int CloseClient(string cpr)
        {
            return _nonQuery.CloseClient(cpr);
        }

        public int CloseEmployee(int id)
        {
            return _nonQuery.CloseEmployee(id);
        }

        public int DeleteLegalService(int id)
        {
            return _nonQuery.DeleteLegalService(id);
        }

        public int DeleteField(string name)
        {
            return _nonQuery.DeleteField(name);
        }
    }
}
