using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{  
    // Klass CaseHandler er en Controller, der står for at sende informationer mellem UI og BL
   
    public class OldCaseHandler
    {
       
        private CrudProvServices _case;
        private CrudCases _cases;
        private CrudClients _clients;
        private static OldCaseHandler _instance;
        public OldCaseHandler()
        {
            _case = new CrudProvServices();
            _cases = new CrudCases();
            _clients = new CrudClients();
        }
        public static OldCaseHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OldCaseHandler();
                return _instance;
            }
        }

        // Fra Case
        public void InitializeCase(int id, decimal negPrice, string respEmp)
        {
            _case.InitializeCase (id, negPrice, respEmp);
        }

       
        public int NewService(int caseID, DateTime date, int hours, int km, string comment, int respEmpl)
        {
            return _case.NewService(caseID, date, hours, km, comment, respEmpl);
        }


        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            return _case.GetProvidedServices();
           
        }
     
        public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _case.UpdateService(id, hours, km, date, comment);
        }

        public decimal GetPrice(int id)
        {
            return _case.GetPrice();
        }
        public int DeleteService(int id)
        {
            return _case.DeleteService(id);
        }

        // Fra CaseCatalog

        //public int NewCase(string name, int clientId, int serviceId, DateTime startTime, int empId, decimal negPrice)
        //{
        //    return _cases.NewCase(name, clientId, serviceId, startTime, empId, negPrice);
        //}
        //public List<CaseM> GetCases()
        //{
        //    return _cases.GetCases();
        //}
        //public int CloseCase(int id, decimal total, DateTime endDate)
        //{
        //    return _cases.CloseCase(id, total, endDate);
        //}

        //public int UpdateCaseE(int id, decimal negPrice, string respEmp)
        //{
        //    return _cases.UpdateCase(id, negPrice, respEmp);
        //}

        //public int DeleteCase(int id)
        //{
        //    return _cases.DeleteCase(id);
        //}

      

        // Hjælpemetoder, som returner navne af aktør til dropdown menuer på UI;
        public List<EmployeeM> GetLawyers()
        {
            return _cases.GetLawyers();
        }

        public List<EmployeeM> GetEmplNames()
        {
            return _cases.GetEmplNames();
        }


        // fra ClientCatalog
        //public ClientM GetClient(string tlf)
        //{
        //    return _clients.GetClient(tlf);
        //}

        //public int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        //{
        //    return _clients.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        //}

        //public int UpdateClient(string fName, string lName, string cpr, string address, int postNo, string eMail, string tlf)
        //{
        //    return _clients.UpdateClient(fName, lName, cpr, address, postNo, eMail, tlf);
        //}
        //public int CloseClient(int id)
        //{
        //    return _clients.CloseClient(id);
        //}

    }
}
