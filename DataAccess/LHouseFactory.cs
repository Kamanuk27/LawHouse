using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LHouseFactory
    {
        private static LHouseFactory _instance;

        internal LHouseFactory()
        {

        }
        public static LHouseFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LHouseFactory();
                return _instance;
            }
        }
        public ILhouseDataAccess GetHrDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            ILhouseDataAccess percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlLhouseDataAccess();
            }
            else
            {
                percistance = new TestLhouseDB();
            }

            return percistance;
        }

    }
}
