﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary
{
    public partial class CaseModel : ICase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NegPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Service { get; set; }
        public string RespEmployee { get; set; }
        public string Client { get; set; }
    }
}