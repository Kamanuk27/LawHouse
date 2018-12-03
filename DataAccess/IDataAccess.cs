
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
        int NewField(FieldE f);


        List< CaseE> GetCases();
        List<ServiceE> GetProvidedServices(int caseId);
        List<LegalServiceE> GetLegalServices();
        List<FieldE> GetFields();
        List<FieldE> GetEmpFields(int id);
        List<EmployeeE> GetEmployees();

        ClientE GetClient(string cpr);


        int UpdateService(ServiceE s1);
        int UpdateLegalService(LegalServiceE ls);
        int UpdateCase(CaseE c1);
        int UpdateClient(ClientE client);
        int UpdateEmployee(EmployeeE emp);
        int AddFieldToEmployee(int id, string name);



        int CloseCase(CaseE c1);
        int CloseClient(string cpr);
        int CloseEmployee(int id);


        int DeleteCase(int id);
        int DeleteService(int id);
        int DeleteLegalService(int id);
        int DeleteField(string name);




        List<string> GetLawyers();
        List<string> GetEmplNames();
        List<decimal> GetUnitPrices();
        
    }
}
