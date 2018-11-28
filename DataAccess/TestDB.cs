using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    internal class TestDB : IDataAccess
    {
        public int NewCase(Case c1)
        {
            return 1;
        }

       
        public int NewService(Service s1)
        {
            return 1;
        }

        public Case GetCase(int id)
        {
            Case c1 = new Case();
            c1.Id = id;
            return c1;
        }

        public List<Case> GetCases()
        {
            List<Case> cases = new List<Case>();
            cases.Add(new Case(1));
            cases.Add(new Case(4));
            return cases;
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            List<Service> services = new List<Service>();
            services.Add(new Service(2, 50));
            services.Add(new Service(3, 100));
            return services;
        }

        public int UpdateService (Service s1)
        {
            return 1;
        }

        public int UpdateCase(Case c1)
        {
            return 1;
        }

        public decimal GetPrice(int id)
        {
            return 2000;
        }

        public int CloseCase(Case c1)
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

        public decimal[] GetUnitPrices()
        {
            decimal [] prices = new decimal[2];
            prices[0] = 500;
            prices[1] = 5;
            return prices;
        }
    }
}
