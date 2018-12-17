using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Stanja
    public interface ICase
    {
        int NewCase(CaseM c1);
        List<CaseM> GetCases(bool active);
        List<CaseM> GetCasesByClientId(int id);
        int UpdateCase(CaseM c1);
        int CloseCase(CaseM c1);
        int DeleteCase(int id);
        
    }
}
