using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    internal class CaseDb
    {
        private static CaseDb _instance;
        private ICaseDataAccess _persistence;
        internal CaseDb()
        {
            _persistence = DatabaseFactory.Instance.GetCaseDataAccess();
        }
        internal  static CaseDb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CaseDb();
                return _instance;
            }
        }
       
        // Create metoder
        internal int NewCase(CaseE c1)
        {
            return _persistence.NewCase(c1);
        }


        internal int NewService(ServiceE s1)
        {
            return _persistence.NewService(s1);
        }

        internal int NewClient(ClientE client)
        {
            return _persistence.NewClient(client);
        }
       
        // Get/read metoder
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
        internal ClientE GetClient(int tlf)
        {
            return _persistence.GetClient(tlf);
        }
       
        internal List<EmployeeE> GetLawyers()
        {
            return _persistence.GetLawyers();
        }

        internal  List<EmployeeE> GetEmplNames()
        {
            return _persistence.GetEmplNames();
        }

        internal List<decimal> GetUnitPrices()
        {
            return _persistence.GetUnitPrices();
        }

        // Update/Close metoder

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

        internal int UpdateClient(ClientE client)
        {
            return _persistence.UpdateClient(client);
        }
        internal int CloseClient(int id)
        {
            return _persistence.CloseClient(id);
        }

        //Delete metoder
        internal int DeleteCase(int id)
        {
            return _persistence.DeleteCase(id);
        }

        internal int DeleteService(int id)
        {
            return _persistence.DeleteService(id);
        }
    }
}
