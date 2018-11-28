using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary.Entities;


namespace BusinessLogic
{
    class OldEmployee
    {
        internal DbController dbController;
        internal List<Specialization> specializations;

        public OldEmployee()
        {
            dbController = DbController.Instance;
        }

        public List <string> GetLawyers()
        {
            return dbController.GetLawyers();
        }
        public List <string> GetEmplNames()
        {
           return dbController.GetEmplNames();
            
        }
    }
}
