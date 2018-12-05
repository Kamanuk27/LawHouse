using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    public class LhouseHandler
    {
        private EmpCatalog _empCat;
        private ServiceCatalog _serviceCat;
        private static LhouseHandler _instance;

        public LhouseHandler()
        {
            _empCat = new EmpCatalog();
            _serviceCat = new ServiceCatalog();
        }
        public static LhouseHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhouseHandler();
                return _instance;
            }
        }

        // Employee Catalog metoder:
        public List <EmployeeE> GetEmployees()
        {
            return _empCat.GetEmployees();
        }

        public int NewEmployee(int cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, int tlf, DateTime start, string position, decimal money)
        {
            return _empCat.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }
        public int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, int tlf, string position, decimal money)
        {
            return _empCat.UpdateEmployee(id, fName, lName, address, postNo, eMail, tlf, position, money);
        }

        public int CloseEmployee(int id)
        {
            return _empCat.CloseEmployee(id);
        }

        public List<FieldE> GetEmployeeFields(int id)
        {
          return _empCat.GetEmployeeFields(id);

        }
        public List<FieldE> GetFields()
        {
            return _empCat.GetFields();
        }

        public int NewField(string name)
        {
            return _empCat.NewField(name);
        }

        public int AddField(int eId, int fId)
        {
            return _empCat.AddField(eId, fId);
        }
        public int DeleteField(int id)
        {
            return _empCat.DeleteField(id);
        }

        // LegalServices metoder:

        public int NewLegalService(string name, int hours, int time, decimal price)
        {
            return _serviceCat.NewLegalService(name, hours, time, price);
        }

        public List<LegalServiceE> GetLegalServices()
        {
            return _serviceCat.GetLegalServices();
        }

        public int UpdateLegalService(int id, string name, int hours, int time, decimal price)
        {
            return _serviceCat.UpdateLegalService(id, name, hours, time, price);
        }


        public int DeleteLegalService(int id)
        {
            return _serviceCat.DeleteLegalService(id);
        }

        
    }
}
