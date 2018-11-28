using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    internal class DatabaseFactory
    {
        private static DatabaseFactory _instance;
        
        internal DatabaseFactory()
        {

        }
        internal static DatabaseFactory Instance
        {
            get
            {
                if (_instance == null)
                _instance = new DatabaseFactory();
                return _instance;
            }
        }
        internal DbController GetDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            DbController percistance = null;

            if (database == "sqlserver")
            {
                percistance = new DbController( new SqlController());
            }
            else
            {
                percistance = new DbController(new TestDB());
            }

            return percistance;
        }
    }
}

