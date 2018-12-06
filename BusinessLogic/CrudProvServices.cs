using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class CrudProvServices : CaseM
    {
        private CaseDb _dbController;
        internal List<ProvidedServiceM> Services;


        public CrudProvServices()
        {
            _dbController = CaseDb.Instance;
        }
        internal void InitializeCase(int id, decimal negPrice, string respEmp)
        {
            Id = id;
            NegPrice = negPrice;
            RespEmployee = respEmp;
            Services = _dbController.GetProvidedServices(Id);
        }

        internal int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            ProvidedServiceM s1 = new ProvidedServiceM();
            s1.CaseID = caseID;
            s1.Date = date;
            s1.Hours = hours;
            s1.Km = km;
            s1.Comment = comment;
            s1.EmployeeName = respEmpl;
            return _dbController.NewService(s1);
        }
        internal List <ProvidedServiceM> GetProvidedServices()
        {
            return Services;
        }
        internal int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            ProvidedServiceM s1 = new ProvidedServiceM();
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
            if (Services.Count > 0)
            {
                PriceCalculator calculator = new PriceCalculator();
                return calculator.CalculatePrice(GetUnitPrices(), Services);
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
