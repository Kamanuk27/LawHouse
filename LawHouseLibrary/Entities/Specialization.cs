using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class Specialization : Entity
    {
        public int LegalService_ID { get; set; }
        public int Employee_ID { get; set; }

    }
}
