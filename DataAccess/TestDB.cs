using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class TestDB : IDataAccess
    {
        public List<Employee> ReadAllEmployee()
        {
            throw new NotImplementedException();
        }

        public Employee ReadSingleEmployee(string ssn)
        {
            throw new NotImplementedException();
        }
    }
}
