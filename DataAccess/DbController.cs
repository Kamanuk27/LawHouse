using System;
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
        public int NewCase(CaseRepo c1)
        {
            return _persistenceLayer.NewCase(c1);
        }

        public int CloseCase(CaseRepo c1)
        {
            return _persistenceLayer.CloseCase(c1);
        }

        public int EditService(ServiceRepo s1)
        {
            return _persistenceLayer.NewService(s1);
        }
        public CaseRepo GetCase(int id)
        {
            return _persistenceLayer.GetCase(id);
        }
        public List <CaseRepo> GetCases()
        {
            return _persistenceLayer.GetCases();
        }

        public List <ServiceRepo> GetProvidedServices(int caseId)
        {
            return _persistenceLayer.GetProvidedServices(caseId);
        }

        public int UpdateService(ServiceRepo s1)
        {
            return _persistenceLayer.UpdateService(s1);
        }

        public int UpdateCase(CaseRepo c1)
        {
            return _persistenceLayer.UpdateCase(c1);
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
