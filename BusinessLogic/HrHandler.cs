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
        private Employee _employee;
        private EmpCatalog _empCat;
        private ServiceCatalog _serviceCat;
        private static HrHandler _instance;

        public HrHandler()
        {
            _employee = new Employee();
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


        // Employee metoder:

        public void InitializeEmployee(int id, string cpr, string fName, string lName, string address, int postNo,
                        string eMail, string tlf, DateTime start, string position, decimal money)
        {
           _employee.InitializeEmployee(id, cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);

        }
        public List<FieldE> GetFields()
        {
            return _employee.GetFields();
        }

        public int NewField(string name)
        {
            return _employee.NewField(name);
        }

        public int AddField(string name)
        {
            return _employee.AddField(name);
        }
        public int DeleteField(string name)
        {
            return _employee.DeleteField(name);
        }

        // Legal Services metoder:

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
