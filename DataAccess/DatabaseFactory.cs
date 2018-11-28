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
        public IDataAccess GetDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            IDataAccess percistance = null;

            if (database == "sqlserver")
            {
                percistance =new SqlDataAccess();
            }
            else
            {
                percistance = new TestDB();
            }

            return percistance;
        }
    }
}

