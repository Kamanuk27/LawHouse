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
        public static DatabaseFactory GetInstance()
        {

            if (_instance == null)
                _instance = new DatabaseFactory();
            return _instance;
        }
        public IDataAccess GetDataAccess()
        {
            //string database = ConfigurationManager.AppSettings["database"];
            //if (database == "sqlserver")
            //{
            //    percistance = new DatabaseAccess();
            //}
            percistance = new SqlAccess();
            return percistance;
        }
    }
}

