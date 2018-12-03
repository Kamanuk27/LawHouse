using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{  
    // Klass CaseHandler er en Controller  
    // Har en instance af Case og CaseCatalog.
    internal class CaseHandler
    {
       
        private Case _case;
        private CaseCatalog _cases;
        private ClientCatalog _clients;
        public CaseHandler()
        {
            _case = new Case();
            _cases = new CaseCatalog();
            _clients = new ClientCatalog();
        }
        
      
        internal int NewCaseE(string name, string client, string service, DateTime startTime, string respEmpl, decimal negPrice) 
        {
            return _cases.NewCaseE(name, client, service, startTime, respEmpl, negPrice);
        }
        internal void InitiateCaseFromCaseE(int id, string name, string client, DateTime start, 
                                             string service, decimal negPrice, decimal total, string respEmp)
        {
            _case.InitializeCase(id, name, client, start, service, negPrice, total, respEmp);
        }

        internal int CloseCaseE(int id, decimal total, DateTime endDate)
        {
            return _cases.CloseCaseE(id, total, endDate);
        }

        internal int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            return _case.NewService(caseID, date, hours, km, comment, respEmpl);
        }

        internal List<CaseE> GetCases()
        {
            return _cases.GetCases();
        }

        internal List<ServiceE> GetProvidedServices(int caseId)
        {
            return _case.GetProvidedServices();
           
        }
     
        internal int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _case.UpdateService(id, hours, km, date, comment);
        }

        internal int UpdateCaseE(int id, decimal negPrice, string respEmp)
        {
            return _cases.UpdateCaseE(id, negPrice, respEmp);
        }

        internal decimal GetPrice(int id)
        {
            return _case.GetPrice();
        }
     
        
        internal int DeleteCase(int id)
        {
            return _cases.DeleteCase(id);
        }

        internal int DeleteService(int id)
        {
            return _case.DeleteService(id);
        }

        // Hjælpemetoder, som returner navne af aktør til dropdown menuer på UI;
        internal List<string> GetLawyers()
        {
            return _cases.GetLawyers();
        }

        internal List<string> GetEmplNames()
        {
            return _cases.GetEmplNames();
        }

        internal ClientE GetClient(string cpr)
        {
            return _clients.GetClient(cpr);
        }

        internal int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            return _clients.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        internal int UpdateClient(string cpr, string address, int postNo, string eMail, string tlf)
        {
            return _clients.UpdateClient(cpr, address, postNo, eMail, tlf);
        }
        internal int CloseClient(string cpr)
        {
            return _clients.CloseClient(cpr);
        }

    }
}
