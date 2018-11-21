using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories;

namespace BusinessLogic
{
    public partial class Case : CaseRepo
    {
       
        private DbController dbController;
       
        public Case()
        {
            dbController = DatabaseFactory.Instance.GetDataAccess();
        }

        public int NewCase(CaseRepo c1)
        {
            dbController.NewCase(c1);
            return 1;
        }

        public void GetCase(int id)
        {

            CaseRepo c1 = dbController.GetCase(id);
            Id = c1.Id;
            Name = c1.Name;
            StartDate = c1.StartDate;
            EndDate = c1.EndDate;
            NegPrice = c1.NegPrice;
            TotalPrice = c1.TotalPrice;
            RespEmployee = c1.RespEmployee;
            Client = c1.Client;
            Service = c1.Service;

        }

        public List<CaseRepo> GetCases()
        {
            return dbController.GetCases();
        }

        public List <ServiceRepo> GetProvidedServices()
        {
            return dbController.GetProvidedServices();
        }

        public int EditService(ServiceRepo s1)
        {
           return dbController.EditService(s1);
        }

        public int UpdateCase(CaseRepo c1)
        {
            return dbController.UpdateCase(c1);
        }
       
        public int DeleteCase(int id)
        {
            return dbController.DeleteCase(id);
        }
       
        public int DeleteService (Service s1)
        {
            return dbController.DeleteService(s1);
        }
    }
}
