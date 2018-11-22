﻿
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataAccess
    {
        int NewCase(CaseRepo c1);
        CaseRepo GetCase(int Id);
        List< CaseRepo> GetCases();
        List<ServiceRepo> GetProvidedServices(int caseId);
        int EditService(ServiceRepo s1);
        int UpdateCase(CaseRepo c1);
        int DeleteCase(int id);
        int DeleteService(ServiceRepo s1);
        List<string> GetLawyers();
        List<string> GetEmplNames();
    }
}
