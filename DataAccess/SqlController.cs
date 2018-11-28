﻿using System;
using System.Collections.Generic;
using LawHouseLibrary.Entities;

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
        public int NewCase(Case c1)
        {
            return  _nonQuery.NewCase(c1);
        }
       

        public int NewService(Service s1)
        {
           return _nonQuery.NewService(s1);
        }

        public Case GetCase(int id)
        {
            return _read.GetCase(id);
        }

        public List<Case> GetCases()
        {
            return _read.GetCases();                                              
        }

        public List<Service> GetProvidedServices(int caseId)
        {
            return _read.GetProvidedServices(caseId);
        }

      
        public int UpdateCase(Case c1)
        {
            return _nonQuery.UpdateCase(c1);

        }

        public decimal GetPrice(int id)
        {
            return _read.GetPrice(id);
        }
        public int CloseCase(Case c1)
        {
            return _nonQuery.CloseCase(c1);
        }
        public int UpdateService(Service s1)
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
