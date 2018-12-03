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
       
        
        public HrHandler()
        {
            _employee = new Employee();
            _empCat = new EmpCatalog();
            _serviceCat = new ServiceCatalog();
        }

        // Employee Catalog metoder:
        internal List <EmployeeE> GetEmployees()
        {
            return _empCat.GetEmployees();
        }

        internal int NewEmployee(string cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, string tlf, DateTime start, string position, decimal money)
        {
            return _empCat.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }
        internal int UpdateEmployee(string address, int postNo, string eMail, string tlf, string position, decimal money)
        {
            return _empCat.UpdateEmployee(address, postNo, eMail, tlf, position, money);
        }

        internal int CloseEmployee(int id)
        {
            return _empCat.CloseEmployee(id);
        }


        // Employee metoder:

        internal void InitializeEmployee(int id, string cpr, string fName, string lName, string address, int postNo,
                        string eMail, string tlf, DateTime start, string position, decimal money)
        {
           _employee.InitializeEmployee(id, cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);

        }
        internal List<FieldE> GetFields()
        {
            return _employee.GetFields();
        }

        internal int NewField(string name)
        {
            return _employee.NewField(name);
        }

        internal int AddField(string name)
        {
            return _employee.AddField(name);
        }
        internal int DeleteField(string name)
        {
            return _employee.DeleteField(name);
        }

        // Legal Services metoder:

        internal int NewLegalService(string name, int hours, int time, decimal price)
        {
            return _serviceCat.NewLegalService(name, hours, time, price);
        }

        internal List<LegalServiceE> GetLegalServices()
        {
            return _serviceCat.GetLegalServices();
        }

        internal int UpdateLegalService(string name, int hours, int time, decimal price)
        {
            return _serviceCat.UpdateLegalService(name, hours, time, price);
        }


        internal int DeleteLegalService(int id)
        {
            return _serviceCat.DeleteLegalService(id);
        }
    }
}
