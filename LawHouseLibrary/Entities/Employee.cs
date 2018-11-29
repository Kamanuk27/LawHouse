using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class Employee : Entity
    {
        public string CprNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostNo { get; set; }
        public string Email { get; set; }
        public string TlfNo { get; set; }
        public DateTime StartDate { get; set; }
        public string Position { get; set; }
        public string PayRatePrHour { get; set; }

        public Employee()
        {
            
        }

        public Employee(int id)
        {
            Id = id;
        }
    }
}
