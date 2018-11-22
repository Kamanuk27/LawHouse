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
        Case cHandler;
        Employee eHandler;
        public LhHandler()
        {
            cHandler = new Case();
            eHandler = new Employee();
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

        public int NewCase (int id) // her kommer mange variabler fra Form
        {
            Case c1 = new Case();
            c1.Id = id;
           return  cHandler.NewCase(c1);
        }

        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl) // her kommer mange variabler fra Form
        {
           
            return cHandler.NewService(caseID, date, hours, km, comment, respEmpl);                                              
        }                                                                             
                                                                                      
        public Case GetCase(int id)                                                   
        {
            return cHandler.GetCase(id);
        }

        public List <Case> GetCases()
        {
            return cHandler.GetCases();
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            return cHandler.GetProvidedServices(caseId);
        }

        public int EditService(int id, int hours, int km, DateTime date)
        {
            Service s1 = new Service();
            s1.ID = id;
            s1.Hours = hours;
            s1.Date = date;
            s1.Km = km;
            return cHandler.EditService(s1);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp )
        {
            Case toUpdate = new Case();
            toUpdate.Id = id;
            toUpdate.RespEmployee = respEmp;
            toUpdate.NegPrice = negPrice;
            return cHandler.UpdateCase(toUpdate);
        }

        public int DeleteCase(int id)
        {
            return cHandler.DeleteCase(id);
        }

        public int DeleteSrvice(int id)
        {
            return cHandler.DeleteService(id);
        }

        // metoder til dropdown felter
        public List <string> GetLawyers()
        {
            return eHandler.GetLawyers();
        }

        public List <string> GetEmplNames()
        {
            return eHandler.GetEmplNames();
        }


    }
}
