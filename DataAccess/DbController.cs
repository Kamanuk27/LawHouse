using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;



namespace DataAccess
{
    public class DbController
    {
        private static DbController _instance;
        private IDataAccess _persistenceLayer;
        public DbController()
        {

        }
        public static DbController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = DatabaseFactory.Instance.GetDataAccess();
                return _instance;
            }
        }
        

        internal DbController(IDataAccess persistenceLayer)
        {
          this._persistenceLayer = persistenceLayer;
           
        }
        public int NewCase(Case c1)
        {
            return _persistenceLayer.NewCase(c1);
        }

       
        public int NewService(Service s1)
        {
            return _persistenceLayer.NewService(s1);
        }
        public Case GetCase(int id)
        {
            return _persistenceLayer.GetCase(id);
        }
        public List <Case> GetCases()
        {
            return _persistenceLayer.GetCases();
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            return _persistenceLayer.GetProvidedServices(caseId);
        }

        public int UpdateService(Service s1)
        {
            return _persistenceLayer.UpdateService(s1);
        }

        public int UpdateCase(Case c1)
        {
            return _persistenceLayer.UpdateCase(c1);
        }

        public decimal GetPrice(int id)
        {
            return _persistenceLayer.GetPrice(id);
        }
        public int CloseCase(Case c1)
        {
            return _persistenceLayer.CloseCase(c1);
        }

        public int DeleteCase(int id)
        {
            return _persistenceLayer.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _persistenceLayer.DeleteService(id);
        }

        public List <string> GetLawyers()
        {
            return _persistenceLayer.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _persistenceLayer.GetEmplNames();
        }
    }
}
