using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    internal class TestCaseDB : ICaseDataAccess
    {
        // Metoder for Create
        public int NewCase(CaseM c1)
        {
            return 1;
        }

       
        public int NewProvidedService(ProvidedServiceM s1)
        {
            return 1;
        }

     
        public int NewClient(ClientM client)
        {
            return 1;
        }



        // Metoder for Read/Get
        public List<CaseM> GetCases()
        {
            List<CaseM> cases = new List<CaseM>();
            cases.Add(new CaseM(1));
            cases.Add(new CaseM(4));
            return cases;
        }

        public List <ProvidedServiceM> GetProvidedServices(int caseId)
        {
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(3, 100));
            return services;
        }
        public List<SubjectM> GetSubjects()
        {
            List<SubjectM> legalServices = new List<SubjectM>();
            legalServices.Add(new SubjectM(1));
            legalServices.Add(new SubjectM(2));
            return legalServices;
        }

        public ClientM GetClient(int tlf)
        {
            ClientM client = new ClientM();
            client.TlfNo = tlf;
            return client;
        }

        public List<EmployeeM> GetLawyers()
        {
            List<EmployeeM> names = new List<EmployeeM>();
            names.Add(new EmployeeM(1));
            names.Add(new EmployeeM(2));
            return names;
        }

        public List<EmployeeM> GetEmplNames()
        {
            List<EmployeeM> names = new List<EmployeeM>();
            names.Add(new EmployeeM(1));
            names.Add(new EmployeeM(2));
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
        public int UpdateProvidedService (ProvidedServiceM s1)
        {
            return 1;
        }

        public int UpdateCase(CaseM c1)
        {
            return 1;
        }

        public int CloseCase(CaseM c1)
        {
            return 1;
        }
       
    
        public int UpdateClient(ClientM client)
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

        public int DeleteProvidedService(int id)
        {
            return 1;
        }
    }
}
