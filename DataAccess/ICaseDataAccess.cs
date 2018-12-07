
using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ICaseDataAccess
    {
        int NewCase(CaseM c1);
        int NewProvidedService(ProvidedServiceM s1);
        int NewClient(ClientM client);
      


        List< CaseM> GetCases();
        List<ProvidedServiceM> GetProvidedServices(int caseId);
        List<SubjectM> GetSubjects();
        List<EmployeeM> GetLawyers();
        List<EmployeeM> GetEmplNames();
        List<decimal> GetUnitPrices();

        ClientM GetClient(string tlf);


        int UpdateProvidedService(ProvidedServiceM s1);
        int UpdateCase(CaseM c1);
        int UpdateClient(ClientM client);
       


        int CloseCase(CaseM c1);
        int CloseClient(int id);
       

        int DeleteCase(int id);
        int DeleteProvidedService(int id);
    }
}
