
using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ICaseDataAccess
    {
        int NewCase(CaseE c1);
        int NewService(ServiceE s1);
        int NewClient(ClientE client);
      


        List< CaseE> GetCases();
        List<ServiceE> GetProvidedServices(int caseId);
        List<LegalServiceE> GetLegalServices();
        List<EmployeeE> GetLawyers();
        List<EmployeeE> GetEmplNames();
        List<decimal> GetUnitPrices();

        ClientE GetClient(string tlf);


        int UpdateService(ServiceE s1);
        int UpdateCase(CaseE c1);
        int UpdateClient(ClientE client);
       


        int CloseCase(CaseE c1);
        int CloseClient(int id);
       

        int DeleteCase(int id);
        int DeleteService(int id);
    }
}
