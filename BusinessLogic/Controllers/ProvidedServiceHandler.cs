using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace BusinessLogic
{
    public class ProvidedServiceHandler
    {
        private static ProvidedServiceHandler _instance;
        private ProvidedServiceCrud _providedServiceCrud;

        public ProvidedServiceHandler()
        {
            _providedServiceCrud = new ProvidedServiceCrud();
        }

        public static ProvidedServiceHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProvidedServiceHandler();
                return _instance;
            }
        }

        public int NewProvidedService(int caseID, DateTime date, int hours, int km, string comment, int respEmpl)
        {
            return _providedServiceCrud.NewProvidedService(caseID, date, hours, km, comment, respEmpl);
        }


        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            return _providedServiceCrud.GetProvidedServices(caseId);
        }

        public List<ProvidedServiceM> GetProvidedServicesByEmplId(int emplId, DateTime fromTime, DateTime toTime)
        {
            return _providedServiceCrud.GetProvidedServicesByEmplId(emplId, fromTime, toTime);
        }

        public int UpdateProvidedService(int id, int hours, int km, DateTime date, string comment)
        {
            return _providedServiceCrud.UpdateProvidedService(id, hours, km, date, comment);
        }

        public decimal GetPrice(int id, decimal negPrice)
        {
            return _providedServiceCrud.GetPrice(id, negPrice);
        }

        public int DeleteProvidedService(int id)
        {
            return _providedServiceCrud.DeleteProvidedService(id);
        }

        //public List<int> GetworkDone()
        //{
        //    return _providedServiceCrud.GetworkDone();
        //}

        public int[] GetworkDone()
        {
            return _providedServiceCrud.GetworkDone();
        }
    }
}
