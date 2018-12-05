using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class DatabaseFactory
    {
        private static DatabaseFactory _instance;
        
        internal DatabaseFactory()
        {

        }
        public static DatabaseFactory Instance
        {
            get
            {
                if (_instance == null)
                _instance = new DatabaseFactory();
                return _instance;
            }
        }
        public ILhouseDataAccess GetHrDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            ILhouseDataAccess percistance = null;

            if (database == "sqlserver")
            {
                percistance =new SqlLhouseDataAccess();
            }
            else
            {
                percistance = new TestLhouseDB();
            }

            return percistance;
        }

        public ICaseDataAccess GetCaseDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            ICaseDataAccess percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlCaseDataAccess();
            }
            else
            {
                percistance = new TestCaseDB();
            }

            return percistance;
        }
    }
}

