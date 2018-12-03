using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ServiceCatalog
    {
        private DbController _dbController;
        public ServiceCatalog()
        {
            _dbController = DbController.Instance;
        }
        internal List<LegalServiceE> GetLegalServices()
        {
            return  _dbController.GetLegalServices();
            
        }

        internal int NewLegalService(string name, int hours, int time, decimal price)
        {
            LegalServiceE legalService = new LegalServiceE();
            legalService.Name = name;
            legalService.HoursEstimate = hours;
            legalService.TimeEstimate = time;
            legalService.Price = price;


            return _dbController.NewLegalService(legalService);
        }

        internal int UpdateLegalService(string name, int hours, int time, decimal price)
        {
            LegalServiceE ls = new LegalServiceE();
            ls.Name = name;
            ls.HoursEstimate = hours;
            ls.TimeEstimate = time;
            ls.Price = price;
            return _dbController.UpdateLegalService(ls);
        }

       
        internal int DeleteLegalService(int id)
        {
            return _dbController.DeleteLegalService(id);
        }
    }
}
