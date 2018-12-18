
using System;

namespace LawHouseLibrary.Models
{
    // Stanja
    public class CaseM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HoursEstimate { get; set; }
        public decimal NegPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Subject { get; set; }
        public int SubjectId { get; set; }
        public string RespEmployee { get; set; }
        public string Client { get; set; }
        public int RespEmpId { get; set; }
        public int ClientId { get; set; }

        public CaseM()
        {

        }
        // constractor for tests
        public CaseM(int id)
        {
            Id = id;
        }
    }
}
