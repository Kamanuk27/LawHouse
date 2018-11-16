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
        private static DatabaseFactory instance = null;
        private DatabaseFactory()
        {

        }

        public static DatabaseFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseFactory();
                }

                return instance;
            }
        }
        public Catalogue GetDatabase()
        {
            Catalogue empcat = null;
            string database = ConfigurationManager.AppSettings["database"];
            if (database == "test")
            {
                empcat = new Catalogue(new TestDB());
            }
            else if (database == "sqlserver")
            {
                empcat = new Catalogue(new DatabaseAccess());
            }
            return empcat;
        }
    }
}
}
