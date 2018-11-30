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
        internal DbController()
        {
            GetDataAccess();
        }
        internal  static DbController Instance
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
        internal int NewCase(CaseE c1)
        {
            return _persistence.NewCase(c1);
        }


        internal int NewService(ServiceE s1)
        {
            return _persistence.NewService(s1);
        }
        internal CaseE GetCase(int id)
        {
            return _persistence.GetCase(id);
        }
        internal List<CaseE> GetCases()
        {
            return _persistence.GetCases();
        }

        internal List<ServiceE> GetProvidedServices(int caseId)
        {
            return _persistence.GetProvidedServices(caseId);
        }
        internal List<LegalServiceE> GetLegalServices()
        {
            return _persistence.GetLegalServices();
        }

        
        internal int UpdateService(ServiceE s1)
        {
            return _persistence.UpdateService(s1);
        }

        internal int UpdateCase(CaseE c1)
        {
            return _persistence.UpdateCase(c1);
        }
        internal int CloseCase(CaseE c1)
        {
            return _persistence.CloseCase(c1);
        }

        internal int DeleteCase(int id)
        {
            return _persistence.DeleteCase(id);
        }

        internal int DeleteService(int id)
        {
            return _persistence.DeleteService(id);
        }

        internal List<string> GetLawyers()
        {
            return _persistence.GetLawyers();
        }

        internal  List<string> GetEmplNames()
        {
            return _persistence.GetEmplNames();
        }

        internal List<string> GetClientNames()
        {
            return _persistence.GetClientNames();
        }

        internal List<decimal> GetUnitPrices()
        {
            return _persistence.GetUnitPrices();
        }

        internal int NewClient(ClientE client)
        {
            return _persistence.NewClient(client);
        }
        internal int NewEmployee(EmployeeE employee)
        {
            return _persistence.NewEmployee(employee);
        }
        internal int NewLegalService(LegalServiceE legal)
        {
            return _persistence.NewLegalService(legal);
        }
    }
}
