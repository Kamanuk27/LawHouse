﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
   public interface IEmployee
    {
        int NewEmployee(EmployeeM employee);
        List<EmployeeM> GetEmployees();
        int UpdateEmployee(EmployeeM emp);
        int AddSpecializationToEmployee(int eId, int sId);
        int CloseEmployee(int id);
        List<EmployeeM> GetLawyers();
        List<EmployeeM> GetEmplNames();

    }
}