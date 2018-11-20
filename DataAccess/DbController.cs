using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary;

namespace DataAccess
{
    public class DbController
    {


        public List<ICase> empslist;
        public CaseModel cm;

        private IDataAccess persistenceLayer;

        public DbController(IDataAccess persistenceLayer)
        {
          //  empslist = new List<ICase>();
            this.persistenceLayer = persistenceLayer;
            cm = new CaseModel();
        }

        public void GetCase(int id)
        {
            cm = persistenceLayer.GetCase(id);
        }



    }
}
