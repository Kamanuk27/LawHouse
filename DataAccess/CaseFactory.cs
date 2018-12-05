using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class CaseFactory
    {
        private static CaseFactory _instance;
        
        internal CaseFactory()
        {

        }
        public static CaseFactory Instance
        {
            get
            {
                if (_instance == null)
                _instance = new CaseFactory();
                return _instance;
            }
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

