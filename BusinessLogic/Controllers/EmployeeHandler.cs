﻿using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class EmployeeHandler
    {
        private static EmployeeHandler _instance;
        private EmployeeCrud _employeeCrud;

        public EmployeeHandler()
        {
            _employeeCrud = new EmployeeCrud();
        }
        public static EmployeeHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeHandler();
                return _instance;
            }
        }
        public List<EmployeeM> GetEmployees()
        {
            return _employeeCrud.GetEmployees();
        }
        public List<EmployeeM> GetLawyers()
        {
            return _employeeCrud.GetLawyers();
        }

        public List<EmployeeM> GetEmplNames()
        {
            return _employeeCrud.GetEmplNames();
        }

        public int NewEmployee(string cpr, string fName, string lName, string address, int postNo,
            string eMail, string tlf, DateTime start, string position, decimal money)
        {
            return _employeeCrud.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }
        public int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, string tlf, string position, decimal money)
        {
            return _employeeCrud.UpdateEmployee(id, fName, lName, address, postNo, eMail, tlf, position, money);
        }

        public int CloseEmployee(int id)
        {
            return _employeeCrud.CloseEmployee(id);
        }
        internal int AddSpecializationToEmployee(int eId, int sId)
        {
            return _employeeCrud.AddSpecializationToEmployee(eId, sId);
        }
   }
}