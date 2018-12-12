using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ICase
    {
        int NewCase(CaseM c1);
        List<CaseM> GetCases(bool active);
        int UpdateCase(CaseM c1);
        int CloseCase(CaseM c1);
        int DeleteCase(int id);
    }
}
