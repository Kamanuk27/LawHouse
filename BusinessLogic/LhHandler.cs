using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LhHandler
    {
        public static LhHandler _instance;
        private Cases _cases;

        public static LhHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhHandler();
                return _instance;
            }
        }
        public LhHandler()
        {
            _cases = new Cases();
        }
        public int NewCase(string caseName, string client, string service, DateTime startTime, string respEmpl, decimal negoPrice) 
        {
          return _cases.NewCase(caseName, client, service, startTime, respEmpl, negoPrice);
        }
        public int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            return _cases.CloseCase(id, totalPrice, endDate);
        }

        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            
            return _cases.NewService(caseID, date, hours, km, comment, respEmpl);
        }

        public Case GetCase(int id)
        {
            return _cases.GetCase(id);
        }

        public List<Case> GetCases()
        {
            return _cases.GetCases();
        }

        public List<Service> GetProvidedServices(int caseId)
        {
            return _cases.GetProvidedServices(caseId);
        }
        public List<LegalService> GetLegalServices()
        {
            return _cases.GetLegalServices();
        }
        

        public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _cases.UpdateService(id, hours, km, date, comment);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            return _cases.UpdateCase(id, negPrice, respEmp);
        }

        public decimal GetPrice(int id)
        {
            return _cases.GetPrice(id);
        }

        public int DeleteCase(int id)
        {
            return _cases.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _cases.DeleteService(id);
        }

        public List<string> GetLawyers()
        {
            return _cases.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _cases.GetEmplNames();
        }

        public List <string> GetClientNames()
        {
            return _cases.GetClientNames();
        }

        public int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            return _cases.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }
        public int NewEmployee(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf, DateTime start, string position, decimal money)
        {
            return _cases.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }

        
    }
}
