using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class ServiceE : Entity
    {
        public int CaseID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Km { get; set; }
        public string sType { get; set; }

        public ServiceE()
        {

        }

        // constractor for tests
        public ServiceE( int km, int hours)
        {
            Hours = hours;
            Km = km;
        }
    }
}
