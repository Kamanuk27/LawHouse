
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class CaseE : Entity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HoursEstimate { get; set; }
        public decimal NegPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Service { get; set; }
        public int ServiceId { get; set; }
        public string RespEmployee { get; set; }
        public string Client { get; set; }
        public int RespEmpId { get; set; }
        public int ClientId { get; set; }

        public CaseE()
        {

        }
        // constractor for tests
        public CaseE(int id)
        {
            Id = id;
        }
    }
}
