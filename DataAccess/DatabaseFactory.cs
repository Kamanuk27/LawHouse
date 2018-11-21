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
        public IDataAccess percistance;
        public DatabaseFactory()
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
        public DbController GetDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            DbController percistance = null;

            if (database == "sqlserver")
            {
                percistance = new DbController( new DatabaseAccess());
            }
            else
            {
                percistance = new DbController(new TestDB());
            }

            return percistance;
        }
    }
}

