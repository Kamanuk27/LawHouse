using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace BusinessLogic
{
    internal class LhouseHandler
    {
        private CrudEmployees _crudEmployee;
        private CrudSubjects _crudSubject;
        private static LhouseHandler _instance;

        public LhouseHandler()
        {
            _crudEmployee = new CrudEmployees();
            _crudSubject = new CrudSubjects();
        }
        internal static LhouseHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhouseHandler();
                return _instance;
            }
        }

        // Employee Catalog metoder:
        public List <EmployeeM> GetEmployees()
        {
            return _crudEmployee.GetEmployees();
        }

        public int NewEmployee(int cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, int tlf, DateTime start, string position, decimal money)
        {
            return _crudEmployee.NewEmployee(cpr, fName, lName, address, postNo, eMail, tlf, start, position, money);
        }
        public int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, int tlf, string position, decimal money)
        {
            return _crudEmployee.UpdateEmployee(id, fName, lName, address, postNo, eMail, tlf, position, money);
        }

        public int CloseEmployee(int id)
        {
            return _crudEmployee.CloseEmployee(id);
        }

        public List<SubjectM> GetEmpSpecializations(int id)
        {
          return _crudEmployee.GetEmpSpecializations(id);

        }
     
        public int AddField(int eId, int fId)
        {
            return _crudEmployee.AddField(eId, fId);
        }
      
        // CrudSubject metoder:

        public int NewSubject(string name, int hours, int time, decimal price)
        {
            return _crudSubject.NewSubject(name, hours, time, price);
        }

        public List<SubjectM> GetSubject()
        {
            return _crudSubject.GetSubject();
        }

        public int UpdateLegalService(int id, string name, int hours, int time, decimal price)
        {
            return _crudSubject.UpdateSubject(id, name, hours, time, price);
        }


        public int DeleteSubject(int id)
        {
            return _crudSubject.DeleteSubject(id);
        }
    }
}
