using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{
    internal class Cases
    {
        private DbController _dbController;
        private List<Service> _provServices;
        private List<LegalService> _legalServices;
        private Case _case;
        public Cases()
        {
            _dbController = DbController.Instance;
            _provServices = new List<Service>();
            _legalServices = new List<LegalService>();

        }


        internal int NewCase(string caseName, string client, string service, DateTime startTime, string respEmpl, decimal negoPrice) 
        {
            _case = new Case();
            _case.Name = caseName;
            _case.Client = client;
            _case.Service = service;
            _case.StartDate = startTime;
            _case.RespEmployee = respEmpl;
            _case.NegPrice = negoPrice;
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
            _provServices = _dbController.GetProvidedServices(caseId);
            return _provServices;
        }
        internal List<LegalService> GetLegalServices()
        {
            _legalServices = _dbController.GetLegalServices();
            return _legalServices;
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
        internal decimal [] GetUnitPrices()
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

        internal int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            Client client = new Client();
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
            Employee employee = new Employee();
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
