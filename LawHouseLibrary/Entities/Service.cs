using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class Service : Entity
    {
        public int CaseID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Km { get; set; }
        public string Comment { get; set; }

        public Service()
        {

        }

        // constractor for tests
        public Service( int hours, int km)
        {
            Hours = hours;
            Km = km;
        }
    }
}
