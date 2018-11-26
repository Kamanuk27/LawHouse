using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LhHandler
    {
        private static LhHandler _instance;
        private Case _cHandler;
        private Employee _eHandler;

        public LhHandler()
        {
            _cHandler = new Case();
            _eHandler = new Employee();
        }

        // singleton - der kan være kun en instance af controller.
        public static LhHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhHandler();
                return _instance;
            }
        }

        public int NewCase (string name) // her kommer mange variabler fra Form
        {
           return  _cHandler.NewCase(name);
        }
       
        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
           return _cHandler.NewService(caseID, date, hours, km, comment, respEmpl);                                              
        }                                                                             
                                                                                      
        public Case GetCase(int id)                                                   
        {
            return _cHandler.GetCase(id);
        }

        public List <Case> GetCases()
        {
            return _cHandler.GetCases();
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            return _cHandler.GetProvidedServices(caseId);
        }

        public int UpdateService(int id, int hours, int km, DateTime date)
        {
            return _cHandler.UpdateService(id, hours, km, date);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp )
        {
            return _cHandler.UpdateCase(id, negPrice, respEmp);
        }

        public decimal GetPrice(int id)
        {
            return _cHandler.GetPrice(id);
        }

        public int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            return _cHandler.CloseCase(id, totalPrice, endDate);
        }

        public int DeleteCase(int id)
        {
            return _cHandler.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return _cHandler.DeleteService(id);
        }

        // metoder til dropdown felter
        public List <string> GetLawyers()
        {
            return _eHandler.GetLawyers();
        }

        public List <string> GetEmplNames()
        {
            return _eHandler.GetEmplNames();
        }


    }
}
