using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary.Entities
{
    public class FieldE : Entity
    {
        public string  Name { get; set; }

        public FieldE()
        {

        }
        public FieldE(int id)
        {
            Id = id;
        }
    }
}
