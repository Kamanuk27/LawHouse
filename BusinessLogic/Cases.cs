using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    internal class Cases
    {
        private DbController _dbController;
        private List<Service> _provServices;
        private Case _case;
        public Cases()
        {
            _dbController = DbController.Instance;
            _provServices = new List<Service>();
        }


        internal int NewCase(string name) // her kommer mange variabler fra Form
        {
            _case = new Case();
            _case.Name = name;
            return _dbController.NewCase(_case);
        }
        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            _case = new Case();
            _case.Id = id;
            _case.TotalPrice = totalPrice;
            _case.EndDate = endDate;
            return _dbController.CloseCase(_case);
        }

        internal int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            Service s1 = new Service();
            s1.CaseID = caseID;
            s1.Date = date;
            s1.Hours = hours;
            s1.Km = km;
            s1.Comment = comment;
            s1.EmployeeName = respEmpl;
            return _dbController.NewService(s1);
        }

        internal Case GetCase(int id)
        {
            _case= _dbController.GetCase(id);
            return _case;
        }

        internal List<Case> GetCases()
        {
            return _dbController.GetCases();
        }

        internal List<Service> GetProvidedServices(int caseId)
        {
            _provServices= _dbController.GetProvidedServices(caseId);
            return _provServices;
        }

        internal int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            Service s1 = new Service();
            s1.Id = id;
            s1.Hours = hours;
            s1.Km = km;
            s1.Date = date;
            s1.Comment = comment;
            return _dbController.UpdateService(s1);
        }

        internal int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            _case = new Case();
            _case.Id = id;
            _case.NegPrice = negPrice;
            _case.RespEmployee = respEmp;
            return _dbController.UpdateCase(_case);
        }

        internal decimal GetPrice(int id)
        {
            decimal total = _case.NegPrice > 0 ? _case.NegPrice : CalculatePrice();
            return total;
        }

        private decimal CalculatePrice()
        {
            int hours = 0;
            int km = 0;
            CountServices(ref hours, ref km);
            decimal[] prices = GetUnitPrices();

            return hours * prices[0] + km * prices[1];
        }
        private void CountServices(ref int hours, ref int km)
        {
            foreach (var item in _provServices)
            {
                hours += item.Hours;
                km += item.Km;
            }
        }
        private decimal [] GetUnitPrices()
        {
            return _dbController.GetUnitPrices();
        }


        internal int DeleteCase(int id)
        {
            return _dbController.DeleteCase(id);
        }

        internal int DeleteService(int id)
        {
            return _dbController.DeleteService(id);
        }

        internal List<string> GetLawyers()
        {
            return _dbController.GetLawyers();
        }

        internal List<string> GetEmplNames()
        {
            return _dbController.GetEmplNames();
        }

        internal List <string> GetClientNames()
        {
            return _dbController.GetClientNames();
        }

        internal int NewClient()
        {
            Client client = new Client();
            return _dbController.NewClient(client);
        }
    }
}
