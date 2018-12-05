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
        LhouseDb _dbController;
        //private List<FieldE> _fields;

        public EmpCatalog()
        {
            _dbController = LhouseDb.Instance;

        }

        internal List <EmployeeE> GetEmployees()
        {
            return _dbController.GetEmployees();
        }

        internal int NewEmployee(int cpr, string fName, string lName, string address, int postNo, 
                                 string eMail, int tlf, DateTime start, string position, decimal money)
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

        internal int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, int tlf, string position, decimal money)
        {
          EmployeeE emp = new EmployeeE();
            emp.Id = id;
            emp.FirstName = fName;
            emp.LastName = lName;
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

        internal List<FieldE> GetEmployeeFields(int id)
        {
            return _dbController.GetEmployeeFields(id);
        }
        internal List<FieldE> GetFields()
        {
            return _dbController.GetFields();
        }

        internal int NewField(string name)
        {
            FieldE f = new FieldE();
            f.Name = name;
            return _dbController.NewField(f);
        }

        internal int AddField(int eId, int fId)
        {
            return _dbController.AddField(eId, fId);
        }
        internal int DeleteField(int id)
        {
            return _dbController.DeleteField(id);
        }
    }
}
