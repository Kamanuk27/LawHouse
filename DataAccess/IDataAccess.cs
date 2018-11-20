
using LawHouseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataAccess
    {
        List< ACase> GetCases();
        ACase GetCase(int Id);
        int EditService(AService s1);
        int NewCase(ACase c1);
    }
}
