using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    internal class DbController
    {
        private static DbController _instance;
        private IDataAccess _persistence;
        public DbController()
        {
            GetDataAccess();
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
        internal void GetDataAccess()
        {
            _persistence = DatabaseFactory.Instance.GetDataAccess();

        }
        public int NewCase(Case c1)
        {
            return _persistence.NewCase(c1);
        }


        public int NewService(Service s1)
        {
            return _persistence.NewService(s1);
        }
        public Case GetCase(int id)
        {
            return _persistence.GetCase(id);
        }
        public List<Case> GetCases()
        {
            return _persistence.GetCases();
        }

        public List<Service> GetProvidedServices(int caseId)
        {
            return _persistence.GetProvidedServices(caseId);
        }

        public int UpdateService(Service s1)
        {
            return _persistence.UpdateService(s1);
        }

        public int UpdateCase(Case c1)
        {
            return _persistence.UpdateCase(c1);
        }
        public int CloseCase(Case c1)
        {
            return _persistence.CloseCase(c1);
        }

        public int DeleteCase(int id)
        {
            return _persistence.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _persistence.DeleteService(id);
        }

        public List<string> GetLawyers()
        {
            return _persistence.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _persistence.GetEmplNames();
        }

        public decimal[] GetUnitPrices()
        {
            return _persistence.GetUnitPrices();
        }
    }
}
