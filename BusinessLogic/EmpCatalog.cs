using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class EmpCatalog
    {
        DbController _dbController;

        public EmpCatalog()
        {
            _dbController = DbController.Instance;
        }

        internal List <EmployeeE> GetEmployees()
        {
            return _dbController.GetEmployees();
        }

        internal int NewEmployee(string cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, string tlf, DateTime start, string position, decimal money)
        {
            EmployeeE employee = new EmployeeE();
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

            return _dbController.NewEmployee(employee);
        }

        internal int UpdateEmployee(string address, int postNo, string eMail, string tlf, string position, decimal money)
        {
          EmployeeE emp = new EmployeeE();
            emp.Address = address;
            emp.PostNo = postNo;
            emp.Email = eMail;
            emp.TlfNo = tlf;
            emp.Position = position;
            emp.PayRatePrHour = money;
            return _dbController.UpdateEmployee(emp);
        }


        internal int CloseEmployee(int id)
        {
            return _dbController.CloseEmployee(id);
        }
    }
}
