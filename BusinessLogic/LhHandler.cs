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
        public LhHandler()
        {
            cHandler = new Case();
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

        public int EditService(int hours, int km)
        {
            Service s1 = new Service();
            s1.Hours = hours;
            s1.Km = km;
            return cHandler.EditService(s1);
        }

        public int UpdateCase()
        {
            Case toUpdate = new Case();
            return cHandler.UpdateCase(toUpdate);
        }

        public int DeleteCase(int id)
        {
            return cHandler.DeleteCase(id);
        }

        public int DeleteSrvice()
        {
            Service toDelete = new Service();
            return cHandler.DeleteService(toDelete);
        }

       
    }
}
