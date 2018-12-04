using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Entities;

namespace BusinessLogic
{
    internal class HrHandler
    {
        private EmpCatalog _empCat;
        private ServiceCatalog _serviceCat;
        private static HrHandler _instance;

        public HrHandler()
        {
            _empCat = new EmpCatalog();
            _serviceCat = new ServiceCatalog();
        }
        internal static HrHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HrHandler();
                return _instance;
            }
        }

        // Employee Catalog metoder:
        public List <EmployeeE> GetEmployees()
        {
            return _empCat.GetEmployees();
        }

        public int NewEmployee(string cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, string tlf, DateTime start, string position, decimal money)
        {
            return _empCat.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }
        public int UpdateEmployee(string address, int postNo, string eMail, string tlf, string position, decimal money)
        {
            return _empCat.UpdateEmployee(address, postNo, eMail, tlf, position, money);
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

        public int AddField(int id, string name)
        {
            return _empCat.AddField(id, name);
        }
        public int DeleteField(string name)
        {
            return _empCat.DeleteField(name);
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

        public int UpdateLegalService(string name, int hours, int time, decimal price)
        {
            return _serviceCat.UpdateLegalService(name, hours, time, price);
        }


        public int DeleteLegalService(int id)
        {
            return _serviceCat.DeleteLegalService(id);
        }
    }
}
