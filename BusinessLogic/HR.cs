using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    internal class HR
    {
        private DbController _dbController;
        public HR()
        {
            _dbController = DbController.Instance;
        }

        internal int NewLegalService(string name, int hours, int time, decimal price)
        {
            LegalService legalService = new LegalService();
            legalService.Name = name;
            legalService.HoursEstimate = hours;
            legalService.TimeEstimate = time;
            legalService.Price = price;
           

            return _dbController.NewLegalService(legalService);
        }
    }
}
