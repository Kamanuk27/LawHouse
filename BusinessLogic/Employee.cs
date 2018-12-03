using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    class Employee : EmployeeE
    {
        private DbController _dbController;
        private List<LegalServiceE> _lServices;
        public Employee(DbController dbController)
        {
            _dbController = dbController;
        }

    }
}
