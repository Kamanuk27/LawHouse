using System;

namespace LawHouseLibrary.Models
{
    // Stanja
    public class ProvidedServiceM
    {
        public int Id { get; set; }
        public int CaseID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Km { get; set; }
        public string Comment { get; set; }

        public ProvidedServiceM()
        {

        }

        // constractor for tests
        public ProvidedServiceM( int km, int hours)
        {
            Hours = hours;
            Km = km;
        }
    }
}
