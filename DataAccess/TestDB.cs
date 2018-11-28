using System;
using System.Collections.Generic;
using DataAccess.Models;
using LawHouseLibrary.EntityModel;

namespace DataAccess
{
    internal class TestDB : IDataAccess
    {
        public int NewCase(CaseEntity c1)
        {
            return 1;
        }

       
        public int NewService(ServiceEntity s1)
        {
            return 1;
        }

        public CaseEntity GetCase(int id)
        {
            CaseEntity c1 = new CaseModel();
            c1.Id = id;
            return c1;
        }

        public List<CaseEntity> GetCases()
        {
            List<CaseEntity> cases = new List<CaseEntity>();
            cases.Add(new CaseModel(1));
            cases.Add(new CaseModel(4));
            return cases;
        }

        public List <ServiceEntity> GetProvidedServices(int caseId)
        {
            List<ServiceEntity> services = new List<ServiceEntity>();
            services.Add(new ServiceModel(2, 50));
            services.Add(new ServiceModel(3, 100));
            return services;
        }

        public int UpdateService (ServiceEntity s1)
        {
            return 1;
        }

        public int UpdateCase(CaseEntity c1)
        {
            return 1;
        }

        public decimal GetPrice(int id)
        {
            return 2000;
        }

        public int CloseCase(CaseEntity c1)
        {
            return 1;
        }

        public int DeleteCase(int id)
        {
            return 1;
        }

        public int DeleteService(int id)
        {
            return 1;
        }

        public List<string> GetLawyers()
        {
            List<string> names = new List<string>();
            names.Add("Ole");
            names.Add("Karina");
            return names;
        }

        public List<string> GetEmplNames()
        {
            List<string> names = new List<string>();
            names.Add("Employee Ole");
            names.Add("Employee Karina");
            return names;
        }

       
    }
}
