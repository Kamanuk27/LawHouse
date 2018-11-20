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
        public List<ACase> cases;
        public ACase @case;

        private IDataAccess persistenceLayer;

        public DbController(IDataAccess persistenceLayer)
        {
          //  empslist = new List<ICase>();
            this.persistenceLayer = persistenceLayer;
            @case = new CaseModel();
        }

        public ACase GetCase(int id)
        {
            return persistenceLayer.GetCase(id);
        }
        public int EditService(AService s1)
        {
            return persistenceLayer.EditService(s1);
        }
        public int NewCase(ACase c1)
        {
            return persistenceLayer.NewCase(c1);
        }



    }
}
