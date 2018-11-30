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

        public CaseE GetCase(int id)
        {
            return _read.GetCase(id);
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

        public List<string> GetClientNames()
        {
            return _read.GetClientNames();
        }

        public List<decimal> GetUnitPrices()
        {
            return _read.GetUnitPrices();
        }

        
    }
}
