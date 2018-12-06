﻿using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    internal class TestCaseDB : ICaseDataAccess
    {
        // Metoder for Create
        public int NewCase(CaseE c1)
        {
            return 1;
        }

       
        public int NewService(ServiceE s1)
        {
            return 1;
        }

     
        public int NewClient(ClientE client)
        {
            return 1;
        }



        // Metoder for Read/Get
        public List<CaseE> GetCases()
        {
            List<CaseE> cases = new List<CaseE>();
            cases.Add(new CaseE(1));
            cases.Add(new CaseE(4));
            return cases;
        }

        public List <ServiceE> GetProvidedServices(int caseId)
        {
            List<ServiceE> services = new List<ServiceE>();
            services.Add(new ServiceE(2, 50));
            services.Add(new ServiceE(3, 100));
            return services;
        }
        public List<LegalServiceE> GetLegalServices()
        {
            List<LegalServiceE> legalServices = new List<LegalServiceE>();
            legalServices.Add(new LegalServiceE(1));
            legalServices.Add(new LegalServiceE(2));
            return legalServices;
        }

        public ClientE GetClient(string tlf)
        {
            ClientE client = new ClientE();
            client.TlfNo = tlf;
            return client;
        }

        public List<EmployeeE> GetLawyers()
        {
            List<EmployeeE> names = new List<EmployeeE>();
            names.Add(new EmployeeE(1));
            names.Add(new EmployeeE(2));
            return names;
        }

        public List<EmployeeE> GetEmplNames()
        {
            List<EmployeeE> names = new List<EmployeeE>();
            names.Add(new EmployeeE(1));
            names.Add(new EmployeeE(2));
            return names;
        }

        public List<decimal> GetUnitPrices()
        {
            List<decimal> prices = new List<decimal>();
            prices.Add(10);
            prices.Add(750);
            return prices;
        }

        //Metoder for Update
        public int UpdateService (ServiceE s1)
        {
            return 1;
        }

        public int UpdateCase(CaseE c1)
        {
            return 1;
        }

        public int CloseCase(CaseE c1)
        {
            return 1;
        }
       
    
        public int UpdateClient(ClientE client)
        {
            return 1;
        }

        public int CloseClient(int id)
        {
            return 1;
        }

     
        //Metoder for Delete
      
        public int DeleteCase(int id)
        {
            return 1;
        }

        public int DeleteService(int id)
        {
            return 1;
        }
    }
}
