using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;


namespace DataAccess
{
    internal class TestDB : IDataAccess
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

        public int NewLegalService(LegalServiceE legal)
        {
            return 1;
        }

        public int NewClient(ClientE client)
        {
            return 1;
        }

        public int NewEmployee(EmployeeE employee)
        {
            return 1;
        }

        public int NewField(FieldE f)
        {
            return 1;
        }
        public int AddFieldToEmployee(int id, string name)
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
        public List<FieldE> GetFields()
        {
            List<FieldE> fields = new List<FieldE>();
            fields.Add(new FieldE(1));
            fields.Add(new FieldE(2));
            return fields;
        }

        public List<FieldE> GetEmpFields(int id)
        {
            List<FieldE> fields = new List<FieldE>();
            fields.Add(new FieldE(1));
            fields.Add(new FieldE(2));
            return fields;
        }

        public List<EmployeeE> GetEmployees()
        {
            List<EmployeeE> employees = new List<EmployeeE>();
            employees.Add(new EmployeeE(23));
            employees.Add(new EmployeeE(12));
            return employees;
        }

        public ClientE GetClient(string cpr)
        {
            ClientE client = new ClientE();
            client.CprNo = cpr;
            return client;
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

        public List<decimal> GetUnitPrices()
        {
            List<decimal> prices = new List<decimal>();
            prices.Add(10);
            prices.Add(750);
            return prices;
        }

        public List<LegalServiceE> GetLegalServices()
        {
            List <LegalServiceE> legalServices = new List<LegalServiceE>();
            legalServices.Add(new LegalServiceE(1));
            legalServices.Add(new LegalServiceE(2));
            return legalServices;
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
       
        public int UpdateLegalService(LegalServiceE ls)
        {
            return 1;
        }

        public int UpdateClient(ClientE client)
        {
            return 1;
        }

        public int UpdateEmployee(EmployeeE emp)
        {
            return 1;
        }


        public int CloseClient(string cpr)
        {
            return 1;
        }

        public int CloseEmployee(int id)
        {
            return 1;
        }
        



        //Metoder for Delete
        public int DeleteLegalService(int id)
        {
            return 1;
        }

        public int DeleteField(string name)
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
    }
}
