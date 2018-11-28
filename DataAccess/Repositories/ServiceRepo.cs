using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public abstract class ServiceRepo
    {
        public int CaseID { get; set; }
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public double Hours { get; set; }
        public int Km { get; set; }
        public string Comment { get; set; }

        public ServiceRepo()
        {

        }

        // constractor for tests
        public ServiceRepo (int hours, int km)
        {
            Hours = hours;
            Km = km;
        }
    }
}
