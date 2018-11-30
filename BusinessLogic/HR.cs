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
       
        private List<LegalServiceE> _legalServices;
        public HR()
        {
            _dbController = DbController.Instance;
            _legalServices = new List<LegalServiceE>();
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

        internal List<LegalServiceE> GetLegalServices()
        {
            _legalServices = _dbController.GetLegalServices();
            return _legalServices;
        }

        internal int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            ClientE client = new ClientE();
            client.CprNo = cpr;
            client.FirstName = fName;
            client.LastName = lName;
            client.Address = address;
            client.PostNo = postNo;
            client.Email = eMail;
            client.TlfNo = tlf;
            return _dbController.NewClient(client);
        }
        internal int NewEmployee(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf, DateTime start, string position, decimal money)
        {
            EmployeeE employee = new EmployeeE();
            employee.CprNo = cpr;
            employee.FirstName = fName;
            employee.LastName = lName;
            employee.Address = address;
            employee.PostNo = postNo;
            employee.Email = eMail;
            employee.TlfNo = tlf;
            employee.StartDate = start;
            employee.Position = position;
            employee.PayRatePrHour = money;

            return _dbController.NewEmployee(employee);
        }
    }
}
