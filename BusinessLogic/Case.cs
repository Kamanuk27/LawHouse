using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary;

namespace BusinessLogic
{
    public class Case : ICase
    {
         private IDataAccess _data;
       
        public Case()
        {
            DatabaseFactory factory = DatabaseFactory.GetInstance();
           _data = factory.GetDataAccess();
        }

    
        public ICase GetCase(int id)
        {
            return _data.GetCase(id);
            //ICase c1 = new Case();
            //c1 = _data.GetCase(1);
            //Id = c1.Id;
            //Name = c1.Name;
            //StartDate = c1.StartDate;
        }
    }
}
