using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    internal class Cases
    {
        private DbController _dbController;
        private List<Service> _provServices;
        public Cases()
        {
            _dbController = DbController.Instance;
            _provServices = new List<Service>();
        }


        internal int NewCase(string name) // her kommer mange variabler fra Form
        {
            Case c1 = new Case();
            c1.Name = name;
            return _dbController.NewCase(c1);
        }
        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            Case c1 = new Case();
            c1.Id = id;
            c1.TotalPrice = totalPrice;
            c1.EndDate = endDate;
            return _dbController.CloseCase(c1);
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
            return _dbController.GetCase(id);
        }

        internal List<Case> GetCases()
        {
            return _dbController.GetCases();
        }

        internal List<Service> GetProvidedServices(int caseId)
        {
            return _dbController.GetProvidedServices(caseId);
         
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
            Case c1 = new Case();
            c1.Id = id;
            c1.NegPrice = negPrice;
            c1.RespEmployee = respEmp;
            return _dbController.UpdateCase(c1);
        }

        internal decimal CalculatePrice(int id)
        {
            int hours = 0;
            int km = 0;
            CountServices(id, ref hours, ref km);
            decimal[] prices = GetUnitPrices();
            return hours * prices[0] + km * prices[1];
        }
        private void CountServices(int id, ref int hours, ref int km)
        {
            foreach (var item in _dbController.GetProvidedServices(id))
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
    }
}
