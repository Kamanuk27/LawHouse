using System;
using System.Collections.Generic;
using DataAccess.Repositories;

namespace DataAccess
{
    internal class SqlController : IDataAccess
    {
        private SqlNonQuery _nonQuery;
        private SqlRead _read;

        public SqlController()
        {
            _nonQuery = new SqlNonQuery();
            _read = new SqlRead();
        }
        public int NewCase(CaseRepo c1)
        {
            return  _nonQuery.NewCase(c1);
        }
       

        public int NewService(ServiceRepo s1)
        {
           return _nonQuery.NewService(s1);
        }

        public CaseRepo GetCase(int id)
        {
            return _read.GetCase(id);
        }

        public List<CaseRepo> GetCases()
        {
            return _read.GetCases();                                              
        }

        public List<ServiceRepo> GetProvidedServices(int caseId)
        {
            return _read.GetProvidedServices(caseId);
        }

      
        public int UpdateCase(CaseRepo c1)
        {
            return _nonQuery.UpdateCase(c1);

        }

        public decimal GetPrice(int id)
        {
            return _read.GetPrice(id);
        }
        public int CloseCase(CaseRepo c1)
        {
            return _nonQuery.CloseCase(c1);
        }
        public int UpdateService(ServiceRepo s1)
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
    }
}
