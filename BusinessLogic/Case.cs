using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Case : CaseE
    {
        private DbController _dbController;
        private List<ServiceE> _services;


        public Case(DbController dbController)
        {
            _dbController = dbController;
        }
        internal void InitializeCase(int id, string name, string client, DateTime start,
            string service, decimal negPrice, decimal total, string respEmp)
        {
            Id = id;
            Name = name;
            StartDate = start;
            NegPrice = negPrice;
            TotalPrice = total;
            Service = service;
            RespEmployee = respEmp;
            Client = client;
            _services = _dbController.GetProvidedServices(Id);

        }

        internal int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            ServiceE s1 = new ServiceE();
            s1.CaseID = caseID;
            s1.Date = date;
            s1.Hours = hours;
            s1.Km = km;
            s1.Comment = comment;
            s1.EmployeeName = respEmpl;
            return _dbController.NewService(s1);
        }
        internal List <ServiceE> GetProvidedServices()
        {
            return _services;
        }
        internal int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            ServiceE s1 = new ServiceE();
            s1.Id = id;
            s1.Hours = hours;
            s1.Km = km;
            s1.Date = date;
            s1.Comment = comment;
            return _dbController.UpdateService(s1);
        }
        internal decimal GetPrice()
        {
            decimal total = NegPrice > 0 ? NegPrice : CalculatePrice();
            return total;
        }
        internal List<decimal> GetUnitPrices()
        {
            return _dbController.GetUnitPrices();
        }

        internal decimal CalculatePrice()
        {
            if (_services.Count > 0)
            {
                PriceCalculator calculator = new PriceCalculator();
                return calculator.CalculatePrice(GetUnitPrices(), _services);
            }
            else
                return 0;
        }

        internal int DeleteService(int id)
        {
            return _dbController.DeleteService(id);
        }

    }
}
