using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class CrudEmployees
    {
        LhouseDb _dbController;
        //private List<FieldE> _fields;

        public CrudEmployees()
        {
            _dbController = LhouseDb.Instance;

        }

        //internal List <EmployeeM> GetEmployees()
        //{
        //    return _dbController.GetEmployees();
        //}

        //internal int NewEmployee(string cpr, string fName, string lName, string address, int postNo, 
        //                         string eMail, string tlf, DateTime start, string position, decimal money)
        //{
        //    EmployeeM employee = new EmployeeM();
        //    employee.CprNo = cpr;
        //    employee.FirstName = fName;
        //    employee.LastName = lName;
        //    employee.Address = address;
        //    employee.PostNo = postNo;
        //    employee.Email = eMail;
        //    employee.TlfNo = tlf;
        //    employee.StartDate = start;
        //    employee.Position = position;
        //    employee.PayRatePrHour = money;

        //    return _dbController.NewEmployee(employee);
        //}

        //internal int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, string tlf, string position, decimal money)
        //{
        //  EmployeeM emp = new EmployeeM();
        //    emp.Id = id;
        //    emp.FirstName = fName;
        //    emp.LastName = lName;
        //    emp.Address = address;
        //    emp.PostNo = postNo;
        //    emp.Email = eMail;
        //    emp.TlfNo = tlf;
        //    emp.Position = position;
        //    emp.PayRatePrHour = money;
        //    return _dbController.UpdateEmployee(emp);
        //}


        //internal int CloseEmployee(int id)
        //{
        //    return _dbController.CloseEmployee(id);
        //}

        //internal List<SubjectM> GetEmpSpecializations(int id)
        //{
        //    return _dbController.GetEmpSpecializations(id);
        //}
      
      
        internal int AddField(int eId, int fId)
        {
            return _dbController.AddField(eId, fId);
        }
    }
}
