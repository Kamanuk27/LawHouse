using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using LawHouseLibrary.Models;

namespace DataAccess
{
    internal class SqlCaseDataAccess : ICaseDataAccess
    {
        private CaseNquery _nonQuery;
        private CaseRead _read;
        private SqlConnection _connection;

        public SqlCaseDataAccess()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql"].ToString());
            _nonQuery = new CaseNquery(_connection);
            _read = new CaseRead(_connection);
        }

        public int NewCase(CaseM c1)
        {
            return  _nonQuery.NewCase(c1);
        }
       
        // To Create
        public int NewProvidedService(ProvidedServiceM s1)
        {
           return _nonQuery.NewProvidedService(s1);
        }
        public int NewClient(ClientM client)
        {
            return _nonQuery.NewClient(client);
        }

      

        // To read/get
        public List<CaseM> GetCases()
        {
            return _read.GetCases();                                              
        }

        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            return _read.GetProvidedServices(caseId);
        }
        public List<SubjectM> GetSubjects()
        {
            return _read.GetSubjects();
        }

        public ClientM GetClient(string tlf)
        {
            return _read.GetClient(tlf);
        }


        public List<EmployeeM> GetLawyers()
        {
            return _read.GetLawyers();
        }

        public List<EmployeeM> GetEmplNames()
        {
            return _read.GetEmplNames();
        }

        public List<decimal> GetUnitPrices()
        {
            return _read.GetUnitPrices();
        }



        // To update
        public int UpdateCase(CaseM c1)
        {
            return _nonQuery.UpdateCase(c1);

        }
        public int CloseCase(CaseM c1)
        {
            return _nonQuery.CloseCase(c1);
        }
        public int UpdateProvidedService(ProvidedServiceM s1)
        {
            return _nonQuery.UpdateProvidedService(s1);
        }

     
        public int UpdateClient(ClientM client)
        {
            return _nonQuery.UpdateClient(client);
        }

      
        public int CloseClient(int id)
        {
            return _nonQuery.CloseClient(id);
        }


        // To delete
       
        public int DeleteCase(int id)
        {
            return _nonQuery.DeleteCase(id);
        }

        public int DeleteProvidedService(int id)
        {
            return _nonQuery.DeleteProvidedService(id);
        }
    }
}
