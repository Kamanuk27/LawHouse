using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{
    internal class Cases
    {
        private DbController _dbController;
        private List<ServiceE> _provServices;
        private List<LegalServiceE> _legalServices;
        private CaseE _case;
        public Cases()
        {
            _dbController = DbController.Instance;
            _provServices = new List<ServiceE>();
            _legalServices = new List<LegalServiceE>();

        }


        internal int NewCase(string caseName, string client, string service, DateTime startTime, string respEmpl, decimal negoPrice) 
        {
            _case = new CaseE();
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
            _case = new CaseE();
            _case.Id = id;
            _case.TotalPrice = totalPrice;
            _case.EndDate = endDate;
            return _dbController.CloseCase(_case);
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

        internal CaseE GetCase(int id)
        {
            _case= _dbController.GetCase(id);
            return _case;
        }

        internal List<CaseE> GetCases()
        {
            return _dbController.GetCases();
        }

        internal List<ServiceE> GetProvidedServices(int caseId)
        {
            _provServices = _dbController.GetProvidedServices(caseId);
            return _provServices;
        }
        internal List<LegalServiceE> GetLegalServices()
        {
            _legalServices = _dbController.GetLegalServices();
            return _legalServices;
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

        internal int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            _case = new CaseE();
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

        internal decimal CalculatePrice()
        {
            PriceCalculator calculater = new PriceCalculator();
            return calculater.CalculatePrice(_dbController.GetUnitPrices(), _provServices);
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
