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
        public IDataAccessAdapter percistance;
        public DatabaseFactory()
        {

        }
        public static DatabaseFactory GetInstance()
        {

            if (_instance == null)
                _instance = new DatabaseFactory();
            return _instance;
        }
        public IDataAccessAdapter GetDataAccess()
        {
            //string database = ConfigurationManager.AppSettings["database"];
            //if (database == "sqlserver")
            //{
            //    percistance = new DatabaseAccess();
            //}
            percistance = new DatabaseAccess();
            return percistance;
        }
    }
}

