using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary;

namespace DataAccess
{
    class TestDB : IDataAccess
    {
        public ACase GetCase(int Id)
        {
            throw new NotImplementedException();
        }

        public List<ACase> GetCases()
        {
            throw new NotImplementedException();
        }

        public int EditService (AService s1)
        {
            throw new NotImplementedException();
        }
        public int NewCase(ACase c1)
        {
            return 1;
        }

      

       
    }
}
