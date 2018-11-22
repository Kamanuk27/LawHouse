using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using DataAccess.Repositories;

namespace DataAccess
{
    class TestDB : IDataAccess
    {
        public int NewCase(CaseRepo c1)
        {
            return 1;
        }
        public CaseRepo GetCase(int id)
        {
            CaseRepo c1 = new CaseModel();
            c1.Id = id;
            return c1;
        }

        public List<CaseRepo> GetCases()
        {
            List<CaseRepo> cases = new List<CaseRepo>();
            cases.Add(new CaseModel(1));
            cases.Add(new CaseModel(4));
            return cases;
        }

        public List <ServiceRepo> GetProvidedServices(int caseId)
        {
            List<ServiceRepo> services = new List<ServiceRepo>();
            services.Add(new ServiceModel(2, 50));
            services.Add(new ServiceModel(3, 100));
            return services;
        }

        public int EditService (ServiceRepo s1)
        {
            return 1;
        }

        public int UpdateCase(CaseRepo c1)
        {
            return 1;
        }

        public int DeleteCase(int id)
        {
            return 1;
        }

        public int DeleteService(ServiceRepo s1)
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
