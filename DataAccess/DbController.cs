﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Repositories;

namespace DataAccess
{
    public class DbController
    {
        private static DbController _instance;
        public IDataAccess percistance;
        public DbController()
        {

        }
        public static DbController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DbController();
                return _instance;
            }
        }
        private IDataAccess persistenceLayer;

        public DbController(IDataAccess persistenceLayer)
        {
          //  empslist = new List<ICase>();
            this.persistenceLayer = persistenceLayer;
            //@case = new CaseModel();
        }
        public int NewCase(CaseRepo c1)
        {
            return persistenceLayer.NewCase(c1);
        }

        public int NewService(ServiceRepo s1)
        {
            return persistenceLayer.NewService(s1);
        }
        public CaseRepo GetCase(int id)
        {
            return persistenceLayer.GetCase(id);
        }
        public List <CaseRepo> GetCases()
        {
            return persistenceLayer.GetCases();
        }

        public List <ServiceRepo> GetProvidedServices(int caseId)
        {
            return persistenceLayer.GetProvidedServices(caseId);
        }

        public int EditService(ServiceRepo s1)
        {
            return persistenceLayer.EditService(s1);
        }

        public int UpdateCase(CaseRepo c1)
        {
            return persistenceLayer.UpdateCase(c1);
        }

        public int DeleteCase(int id)
        {
            return persistenceLayer.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return persistenceLayer.DeleteService(id);
        }

        public List <string> GetLawyers()
        {
            return persistenceLayer.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return persistenceLayer.GetEmplNames();
        }
    }
}
