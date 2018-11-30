using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LhController
    {
        public static LhController _instance;
        private CaseHandler _caseHandler;
        private HR _hr;

        public static LhController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhController();
                return _instance;
            }
        }
        public LhController()
        {
            _caseHandler = new CaseHandler();
            _hr = new HR();
        }
        public int NewCase(string caseName, string client, string service, DateTime startTime, string respEmpl, decimal negoPrice) 
        {
          return _caseHandler.NewCaseE(caseName, client, service, startTime, respEmpl, negoPrice);
        }
        public int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            return _caseHandler.CloseCaseE(id, totalPrice, endDate);
        }

        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            
            return _caseHandler.NewService(caseID, date, hours, km, comment, respEmpl);
        }

        public void InitializeCase(CaseE cE)
        {
           _caseHandler.InitiateCaseFromCaseE(cE);
        }
       
        public List<CaseE> GetCases()
        {
            return _caseHandler.GetCases();
        }

        public List<ServiceE> GetProvidedServices(int caseId)
        {
            return _caseHandler.GetProvidedServices(caseId);
        }
        public List<LegalServiceE> GetLegalServices()
        {
            return _hr.GetLegalServices();
        }
        

        public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _caseHandler.UpdateService(id, hours, km, date, comment);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            return _caseHandler.UpdateCaseE(id, negPrice, respEmp);
        }

        public decimal GetPrice(int id)
        {
            return _caseHandler.GetPrice(id);
        }

        public int DeleteCase(int id)
        {
            return _caseHandler.DeleteCaseE(id);
        }

        public int DeleteService(int id)
        {
            return _caseHandler.DeleteService(id);
        }

        public List<string> GetLawyers()
        {
            return _caseHandler.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _caseHandler.GetEmplNames();
        }

        public List <string> GetClientNames()
        {
            return _caseHandler.GetClientNames();
        }

        public int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            return _hr.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }
        public int NewEmployee(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf, DateTime start, string position, decimal money)
        {
            return _hr.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }

        public int NewLegalService(string name, int hours, int time, decimal price)
        {
            return _hr.NewLegalService(name, hours, time, price);
        }
    }
}
