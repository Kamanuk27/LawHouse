using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class LegalServiceE : Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HoursEstimate { get; set; }
        public decimal Price { get; set; }
        public int TimeEstimate { get; set; }


    }
}
