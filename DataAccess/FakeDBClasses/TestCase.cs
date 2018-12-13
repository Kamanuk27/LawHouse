using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class TestCase : ICase
    {
        public int CloseCase(CaseM c1)
        {
            return 1;
        }

        public int DeleteCase(int id)
        {
            return 1;
        }

        public List<CaseM> GetCasesByClientId(int id)
        {
            List<CaseM> cases = new List<CaseM>();
            cases.Add(new CaseM(1));
            cases.Add(new CaseM(4));
            return cases;
        }

        public List<CaseM> GetCases(bool active)
        {
            List<CaseM> cases = new List<CaseM>();
            cases.Add(new CaseM(1));
            cases.Add(new CaseM(4));
            return cases;
        }

        public int NewCase(CaseM c1)
        {
            return 1;
        }

        public int UpdateCase(CaseM c1)
        {
            return 1;
        }
    }
}
