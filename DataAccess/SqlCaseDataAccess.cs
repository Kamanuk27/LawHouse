using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using LawHouseLibrary.Entities;

namespace DataAccess
{
    internal class SqlCaseDataAccess : ICaseDataAccess
    {
        private CaseNonQuery _nonQuery;
        private CaseRead _read;
        private SqlConnection _connection;

        public SqlCaseDataAccess()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _nonQuery = new CaseNonQuery(_connection);
            _read = new CaseRead(_connection);
        }

        public int NewCase(CaseE c1)
        {
            return  _nonQuery.NewCase(c1);
        }
       
        // To Create
        public int NewService(ServiceE s1)
        {
           return _nonQuery.NewService(s1);
        }
        public int NewClient(ClientE client)
        {
            return _nonQuery.NewClient(client);
        }

      

        // To read/get
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

        public ClientE GetClient(string cpr)
        {
            return _read.GetClient(cpr);
        }


        public List<string> GetLawyers()
        {
            return _read.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _read.GetEmplNames();
        }

        public List<decimal> GetUnitPrices()
        {
            return _read.GetUnitPrices();
        }



        // To update
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

     
        public int UpdateClient(ClientE client)
        {
            return _nonQuery.UpdateClient(client);
        }

      
        public int CloseClient(string cpr)
        {
            return _nonQuery.CloseClient(cpr);
        }


        // To delete
       
        public int DeleteCase(int id)
        {
            return _nonQuery.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _nonQuery.DeleteService(id);
        }
    }
}
