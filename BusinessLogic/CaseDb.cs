using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using LawHouseLibrary.Models;

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
        internal int NewCase(CaseM c1)
        {
            return _persistence.NewCase(c1);
        }


        internal int NewService(ProvidedServiceM s1)
        {
            return _persistence.NewProvidedService(s1);
        }

        internal int NewClient(ClientM client)
        {
            return _persistence.NewClient(client);
        }
       
        // Get/read metoder
        internal List<CaseM> GetCases()
        {
            return _persistence.GetCases();
        }

        internal List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            return _persistence.GetProvidedServices(caseId);
        }
        internal List<SubjectM> GetLegalServices()
        {
            return _persistence.GetSubjects();
        }
        internal ClientM GetClient(string tlf)
        {
            return _persistence.GetClient(tlf);
        }
       
        internal List<EmployeeM> GetLawyers()
        {
            return _persistence.GetLawyers();
        }

        internal  List<EmployeeM> GetEmplNames()
        {
            return _persistence.GetEmplNames();
        }

        internal List<decimal> GetUnitPrices()
        {
            return _persistence.GetUnitPrices();
        }

        // Update/Close metoder

        internal int UpdateService(ProvidedServiceM s1)
        {
            return _persistence.UpdateProvidedService(s1);
        }

        internal int UpdateCase(CaseM c1)
        {
            return _persistence.UpdateCase(c1);
        }
        internal int CloseCase(CaseM c1)
        {
            return _persistence.CloseCase(c1);
        }

        internal int UpdateClient(ClientM client)
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
            return _persistence.DeleteProvidedService(id);
        }
    }
}
