using System;

namespace LawHouseLibrary.Models
{
    // Andriy
    public class EmployeeM 
    {
        public int Id { get; set; }
        public string CprNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostNo { get; set; }
        public string Email { get; set; }
        public string TlfNo { get; set; }
        public DateTime StartDate { get; set; }
        public string Position { get; set; }
        public decimal PayRatePrHour { get; set; }

        public EmployeeM()
        {
            
        }

        public EmployeeM(int id)
        {
            Id = id;
        }
    }
}
