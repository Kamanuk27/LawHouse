
using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess
    {
        int NewCase(Case c1);
        int NewService(Service s1);
        int NewClient(Client client);
        int NewEmployee(Employee employee);
        Case GetCase(int Id);
        List< Case> GetCases();
        List<Service> GetProvidedServices(int caseId);
        List<LegalService> GetLegalServices();
        int UpdateService(Service s1);
        int UpdateCase(Case c1);
        int CloseCase(Case c1);
        int DeleteCase(int id);
        int DeleteService(int id);
        List<string> GetLawyers();
        List<string> GetEmplNames();
        List<string> GetClientNames();
        decimal[] GetUnitPrices();
        
    }
}
