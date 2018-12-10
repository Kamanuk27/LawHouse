using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary.Models;

namespace BusinessLogic
{
    internal class EmployeeCrud
    {

        internal IEmployee _dbEmployee;
        internal EmployeeCrud()
        {
            _dbEmployee = DatabaseFactory.Instance.GetEmployeeDataAccess();
        }

        internal  List<EmployeeM> GetEmployees()
        {
            return _dbEmployee.GetEmployees();
        }

        internal List<EmployeeM> GetEmplNames()
        {
            return _dbEmployee.GetEmplNames();
        }

        internal List<EmployeeM> GetLawyers()
        {
            return _dbEmployee.GetLawyers();
        }

        internal int NewEmployee(string cpr, string fName, string lName, string address, int postNo,
            string eMail, string tlf, DateTime start, string position, decimal money)
        {
            EmployeeM employee = new EmployeeM();
            employee.CprNo = cpr;
            employee.FirstName = fName;
            employee.LastName = lName;
            employee.Address = address;
            employee.PostNo = postNo;
            employee.Email = eMail;
            employee.TlfNo = tlf;
            employee.StartDate = start;
            employee.Position = position;
            employee.PayRatePrHour = money;

            return _dbEmployee.NewEmployee(employee);
        }

        internal int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, string tlf, string position, decimal money)
        {
            EmployeeM emp = new EmployeeM();
            emp.Id = id;
            emp.FirstName = fName;
            emp.LastName = lName;
            emp.Address = address;
            emp.PostNo = postNo;
            emp.Email = eMail;
            emp.TlfNo = tlf;
            emp.Position = position;
            emp.PayRatePrHour = money;
            return _dbEmployee.UpdateEmployee(emp);
        }


        internal int CloseEmployee(int id)
        {
            return _dbEmployee.CloseEmployee(id);
        }

        internal int AddSpecializationToEmployee(int eId, int sId)
        {
            return _dbEmployee.AddSpecializationToEmployee(eId, sId);
        }


    }
}
