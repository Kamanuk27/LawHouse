
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
       

        ClientE GetClient(string cpr);


        int UpdateService(ServiceE s1);
        int UpdateCase(CaseE c1);
        int UpdateClient(ClientE client);
       


        int CloseCase(CaseE c1);
        int CloseClient(string cpr);
       

        int DeleteCase(int id);
        int DeleteService(int id);
       


        List<string> GetLawyers();
        List<string> GetEmplNames();
        List<decimal> GetUnitPrices();
        
    }
}
