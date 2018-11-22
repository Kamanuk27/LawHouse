﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories;


namespace BusinessLogic
{
    public class Case : CaseRepo
    {
       
        private DbController dbController;
        List<Service> services;
       
        public Case()
        {
            dbController = DbController.Instance;
        }

        public int NewCase(int id)
        {
            // jeg tror måske Case kan sendes uden oversættelse til CaseRepo ??
            Case c1 = new Case();
            c1.Id = id;
            dbController.NewCase(c1);
            return 1;
        }

        public Case GetCase(int id)
        {
            CaseRepo caseRepo = dbController.GetCase(id);
 
            Case c1 = new Case();
            c1.Id = caseRepo.Id;
            c1.Name = caseRepo.Name;
            c1.StartDate = caseRepo.StartDate;
            c1.EndDate = caseRepo.EndDate;
            c1.NegPrice = caseRepo.NegPrice;
            c1.TotalPrice = caseRepo.TotalPrice;
            c1.RespEmployee = caseRepo.RespEmployee;
            c1.HoursEstimate = caseRepo.HoursEstimate;
            c1.Client = caseRepo.Client;
            c1.Service = caseRepo.Service;
            return c1;
        }

        public List<Case> GetCases()
        {
            // oversætte CaseRepo til Case
            List<CaseRepo> casesDb = dbController.GetCases();
            List<Case> cases = new List<Case>();
            for (int i = 0; i < casesDb.Count; i++)
            {
                cases.Add(new Case());
                cases[i].Id = casesDb[i].Id;
                cases[i].Name = casesDb[i].Name;
                cases[i].StartDate = casesDb[i].StartDate;
                cases[i].EndDate = casesDb[i].EndDate;
                cases[i].NegPrice = casesDb[i].NegPrice;
                cases[i].TotalPrice = casesDb[i].TotalPrice;
                cases[i].Service = casesDb[i].Service;
                cases[i].Client = casesDb[i].Client;
                cases[i].RespEmployee = casesDb[i].RespEmployee;

            }
           
            return cases;
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            // her skal vi oversætte
            List <ServiceRepo> servicesRepo = dbController.GetProvidedServices(caseId);
            services = new List<Service>();
            for (int i = 0; i < servicesRepo.Count; i++)
            {
                services.Add(new Service());
                services[i].CaseID = servicesRepo[i].CaseID;
                services[i].ID = servicesRepo[i].ID;
                services[i].EmployeeName = servicesRepo[i].EmployeeName;
                services[i].Date = servicesRepo[i].Date;
                services[i].Hours = servicesRepo[i].Hours;
                services[i].Km = servicesRepo[i].Km;
                services[i].Comment = servicesRepo[i].Comment;
            }
            return services;
        }

        public int EditService(int hours, int km)
        {
            Service s1 = new Service();
            s1.Hours = hours;
            s1.Km = km;
            return dbController.EditService(s1);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            Case toUpdate = new Case();
            toUpdate.Id = id;
            toUpdate.RespEmployee = respEmp;
            toUpdate.NegPrice = negPrice;
            return dbController.UpdateCase(toUpdate);
        }
       
        public int DeleteCase(int id)
        {
            return dbController.DeleteCase(id);
        }
       
        public int DeleteService (int id)
        {
            return dbController.DeleteService(id);
        }
    }
}
