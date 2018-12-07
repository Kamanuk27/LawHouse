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
            throw new NotImplementedException();
        }

        public List<EmployeeM> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(EmployeeM emp)
        {
            throw new NotImplementedException();
        }

        public int AddSpecializationToEmployee(int eId, int sId)
        {
            throw new NotImplementedException();
        }

        public int CloseEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
