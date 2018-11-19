using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary
{
    public interface ICase
    {
         int Id { get; set; }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        decimal NegPrice { get; set; }
        decimal TotalPrice { get; set; }
        string Service { get; set; }
        string RespEmployee { get; set; }
        string Client { get; set; }
    }
}
