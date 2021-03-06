﻿using System.Configuration;

namespace DataAccess
{
    // Stanja, Andriy, Lisa
    public class DatabaseFactory
    {
        private static DatabaseFactory _instance;
        public static DatabaseFactory Instance
        {
            get
            {
                if (_instance == null)
                _instance = new DatabaseFactory();
                return _instance;
            }
        }
       

        public ICase GetCaseDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            ICase percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlCase();
            }
            else
            {
                percistance = new FakeCase();
            }

            return percistance;
        }

        public IClient GetClientDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            IClient percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlClient();
            }
            else
            {
                percistance = new FakeClient();
            }

            return percistance;
        }
        public IEmployee GetEmployeeDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            IEmployee percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlEmployee();
            }
            else
            {
                percistance = new FakeEmployee();
            }

            return percistance;
        }

        public ISubject GetSubjectDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            ISubject percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlSubject();
            }
            else
            {
                percistance = new FakeSubject();
            }

            return percistance;
        }
        public IProvidedService GetProvidedServiceDataAccess()
        {
            string database = ConfigurationManager.AppSettings["database"];
            IProvidedService percistance = null;

            if (database == "sqlserver")
            {
                percistance = new SqlProvidedService();
            }
            else
            {
                percistance = new FakeProvidedService();
            }

            return percistance;
        }
    }
}

