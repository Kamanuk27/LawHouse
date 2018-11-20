using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model;
using LawHouseLibrary;

namespace DataAccess
{
    public class DbController
    {
        public List<ICase> cases;
        public ICase @case;

        private IDataAccess persistenceLayer;

        public DbController(IDataAccess persistenceLayer)
        {
          //  empslist = new List<ICase>();
            this.persistenceLayer = persistenceLayer;
            @case = new CaseModel();
        }

        public ICase GetCase(int id)
        {
            return persistenceLayer.GetCase(id);
        }



    }
}
