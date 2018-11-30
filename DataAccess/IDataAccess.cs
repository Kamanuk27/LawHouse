
using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess
    {
        int NewCase(CaseE c1);
        int NewService(ServiceE s1);
        int NewClient(ClientE client);
        int NewEmployee(EmployeeE employee);
        int NewLegalService(LegalServiceE legal);
      
        List< CaseE> GetCases();
        List<ServiceE> GetProvidedServices(int caseId);
        List<LegalServiceE> GetLegalServices();
        int UpdateService(ServiceE s1);
        int UpdateCase(CaseE c1);
        int CloseCase(CaseE c1);
        int DeleteCase(int id);
        int DeleteService(int id);
        List<string> GetLawyers();
        List<string> GetEmplNames();
        List<string> GetClientNames();
        List<decimal> GetUnitPrices();
        
    }
}
