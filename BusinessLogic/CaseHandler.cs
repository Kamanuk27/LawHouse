using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class CaseHandler
    {
        private static CaseHandler _instance;
        private CaseRepository _case;
        private ServiceRepository _service;
       
        public CaseHandler()
        {
            _case = new CaseRepository();
        }

        // singleton - der kan være kun en instance af controller.
        public static CaseHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CaseHandler();
                return _instance;
            }
        }

        public int NewCase (string name) // her kommer mange variabler fra Form
        {
            Case c1 = new Case();
            c1.Name = name;
            return  _case.Create(c1);
        }
        public int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            Case c1 = new Case();
            c1.Id = id;
            c1.TotalPrice = totalPrice;
            c1.EndDate = endDate;
            return _case.CloseCase(c1);
        }

        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            Service s1 = new Service();
            s1.CaseID = caseID;
            s1.Date = date;
            s1.Hours = hours;
            s1.Km = km;
            s1.Comment = comment;
            s1.EmployeeName = respEmpl;
            return _service.Create(s1);                                              
        }                                                                             
                                                                                      
        public Case GetCase(int id)                                                   
        {
            return _case.GetById(id);
        }

        public List <Case> GetCases()
        {
            return _case.GetList();
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            return _service.GetList(caseId);
        }

        public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            Service s1 = new Service();
            s1.Id = id;
            s1.Hours = hours;
            s1.Km = km;
            s1.Date = date;
            s1.Comment = comment;
            return _service.Update(s1);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp )
        {
            Case c1 = new Case();
            c1.Id = id;
            c1.NegPrice = negPrice;
            c1.RespEmployee = respEmp;
            return _case.Update(c1);
        }

        public decimal GetPrice(int id)
        {
            int hours = 0;
            int km = 0;
            List<Service> services = _service.GetList(id);
            foreach (var item in services)
            {
                hours += item.Hours;
                km += item.Km;
            }
            decimal[] prices = _service.GetUnitPrices();
            return hours * prices[0] + km * prices[1];
        }

        public int DeleteCase(int id)
        {
            return _case.Delete(id);
        }

        public int DeleteService(int id)
        {
            return _service.Delete(id);
        }
    }
}
