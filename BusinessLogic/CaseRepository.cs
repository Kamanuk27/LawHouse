using System;
using System.Collections.Generic;
using DataAccess;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    public partial class CaseRepository : IRepository <Case>
    {
       
        private DbController dbController;
       
        public CaseRepository()
        {
            dbController = DbController.Instance;
        }

        public int Create(Case c1)
        {
            return dbController.NewCase(c1); 
        }

        public int Delete(int id)
        {
            return dbController.DeleteCase(id);
        }

        public Case GetById(int id)
        {
            return dbController.GetCase(id);
        }

        public List<Case> GetList()
        {
            return dbController.GetCases();
        }

        public int Update(Case c1)
        {
            return dbController.UpdateCase(c1);
        }

        public int CloseCase(Case c1)
        {
           return dbController.CloseCase(c1);
        }


        //public int NewCase(string name)
        //{
        //    Case c1 = new Case();
        //    c1.Name = name;
        //    // jeg tor måske Case kan sendes uden oversættelse til CaseRepo ??
        //    dbController.NewCase(c1);
        //    return 1;
        //}

        //public int NewService(int caseID, DateTime date, int houres, int km, string comment, string employee)
        //{

        //    return s1.NewService(caseID, date, houres, km, comment, employee);

        //}

        //public Case GetCase(int id)
        //{
        //    Case caseRepo = dbController.GetCase(id);

        //    Case c1 = new Case();
        //    c1.Id = caseRepo.Id;
        //    c1.Name = caseRepo.Name;
        //    c1.StartDate = caseRepo.StartDate;
        //    c1.EndDate = caseRepo.EndDate;
        //    c1.NegPrice = caseRepo.NegPrice;
        //    c1.TotalPrice = caseRepo.TotalPrice;
        //    c1.RespEmployee = caseRepo.RespEmployee;
        //    c1.HoursEstimate = caseRepo.HoursEstimate;
        //    c1.Client = caseRepo.Client;
        //    c1.Service = caseRepo.Service;
        //    return c1;
        //}

        //public List<Case> GetCases()
        //{
        //    // oversætte CaseRepo til Case
        //    List<Case> casesDb = dbController.GetCases();
        //    List<Case> cases = new List<Case>();
        //    for (int i = 0; i < casesDb.Count; i++)
        //    {
        //        cases.Add(new Case());
        //        cases[i].Id = casesDb[i].Id;
        //        cases[i].Name = casesDb[i].Name;
        //        cases[i].StartDate = casesDb[i].StartDate;
        //        cases[i].EndDate = casesDb[i].EndDate;
        //        cases[i].NegPrice = casesDb[i].NegPrice;
        //        cases[i].TotalPrice = casesDb[i].TotalPrice;
        //        cases[i].Service = casesDb[i].Service;
        //        cases[i].Client = casesDb[i].Client;
        //        cases[i].RespEmployee = casesDb[i].RespEmployee;

        //    }

        //    return cases;
        //}

        //public List <Service> GetProvidedServices(int caseId)
        //{
        //    // her skal vi oversætte
        //    List <Service> servicesRepo = dbController.GetProvidedServices(caseId);
        //    services = new List<Service>();
        //    for (int i = 0; i < servicesRepo.Count; i++)
        //    {
        //        services.Add(new Service());
        //        services[i].CaseID = servicesRepo[i].CaseID;
        //        services[i].Id = servicesRepo[i].Id;
        //        services[i].EmployeeName = servicesRepo[i].EmployeeName;
        //        services[i].Date = servicesRepo[i].Date;
        //        services[i].Hours = servicesRepo[i].Hours;
        //        services[i].Km = servicesRepo[i].Km;
        //        services[i].Comment = servicesRepo[i].Comment;
        //    }
        //    return services;
        //}

        //public int UpdateCase(int id, decimal negPrice, string respEmp)
        //{
        //    Case toUpdate = new Case();
        //    toUpdate.Id = id;
        //    toUpdate.RespEmployee = respEmp;
        //    toUpdate.NegPrice = negPrice;
        //    return dbController.UpdateCase(toUpdate);
        //}
        //public decimal GetPrice(int id)
        //{
        //    return dbController.GetPrice(id);
        //}



        //public int CloseCase(int id, decimal totalPrice, DateTime endDate)
        //{
        //    Case c1 = new Case();
        //    c1.Id = id;
        //    c1.TotalPrice = totalPrice;
        //    c1.EndDate = endDate;
        //    return dbController.CloseCase(c1);
        //}

        //public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        //{
        //    Service toUpdate = new Service();
        //    toUpdate.Id = id;
        //    toUpdate.Hours = hours;
        //    toUpdate.Date = date;
        //    toUpdate.Km = km;
        //    toUpdate.Comment = comment;
        //    return dbController.UpdateService(toUpdate);
        //}

        //public int DeleteCase(int id)
        //{
        //    return dbController.DeleteCase(id);
    }

    //public int DeleteService (int id)
    //{
    //    return dbController.DeleteService(id);
    //}

}
}
