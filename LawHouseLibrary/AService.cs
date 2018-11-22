﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseLibrary
{
    public abstract class AService
    {
        public int CaseID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public double Hours { get; set; }
        public int Km { get; set; }
        public string Comment { get; set; }

        public AService()
        {

        }

        // constractor for tests
        public AService(int hours, int km)
        {
            Hours = hours;
            Km = km;
        }
    }
}