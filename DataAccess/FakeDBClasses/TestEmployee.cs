using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    internal class TestEmployee: IEmployee

    {
        public int NewEmployee(EmployeeM employee)
        {
            return 1;
        }

        public List<EmployeeM> GetEmployees()
        {
            List<EmployeeM> employees = new List<EmployeeM>();
            employees.Add(new EmployeeM(1));
            employees.Add(new EmployeeM(2));
            return employees;
        }

        public int UpdateEmployee(EmployeeM emp)
        {
            return 1;
        }

        public int AddSubjectToEmployee(int eId, int sId)
        {
            return 1;
        }

        public int CloseEmployee(int id)
        {
            return 1;
        }

        public int DeleteSubjectFromEmployee(int eId, int sId)
        {
            return 1;
        }
    }
}
