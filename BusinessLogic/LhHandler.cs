using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LhHandler
    {
        private static LhHandler _instance;
        Case cHandler; 
        public LhHandler()
        {
            cHandler = new Case();
        }
        public static LhHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhHandler();
                return _instance;
            }
        }
        public List <Case> GetCases()
        {
            return cHandler.GetCases();
        }
       
    }
}
