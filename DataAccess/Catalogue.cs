using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Catalogue
    {

        public List<Employee> empslist;
        public Employee e;
        private IDataAccess persistenceLayer;

        public Catalogue(IDataAccess persistenceLayer)
        {
            empslist = new List<Employee>();
            e = new Employee();
            this.persistenceLayer = persistenceLayer;
        }
        public void ReadAllEmployee()
        {
            empslist = persistenceLayer.ReadAllEmployee();
        }
        public void ReadSingleEmployee(string ssn)
        {
            e = persistenceLayer.ReadSingleEmployee(ssn);
        }

    }
}
