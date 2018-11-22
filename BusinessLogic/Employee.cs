using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Repositories;

namespace BusinessLogic
{
    class Employee : EmployeeRepo
    {
        private DbController dbController;
        List<Employee> employees;

        public Employee()
        {
            dbController = DbController.Instance;
        }

        public List <string> GetLawyers()
        {
            return dbController.GetLawyers();
        }
        public List <string> GetEmplNames()
        {
           return dbController.GetEmplNames();
            
        }


    }
}
