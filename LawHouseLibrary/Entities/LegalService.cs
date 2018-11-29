using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    class LegalService : Entity
    {
        public string Name { get; set; }
        public int HoursEstimate { get; set; }
        public bool FixedPrice { get; set; }
        public decimal Price { get; set; }
        public int TimeEstimate { get; set; }
       

    }
}
