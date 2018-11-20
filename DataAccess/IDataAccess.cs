
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
        List< ICase> GetCases();
        ICase GetCase(int Id);
        //int RegisterService(int hours, int km);
    }
}
