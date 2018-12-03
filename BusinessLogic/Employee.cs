using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    class Employee : EmployeeE
    {
        private DbController _dbController;
        private List<FieldE> _fields;
        public Employee()
        {
            _dbController = DbController.Instance;
        }

        internal void InitializeEmployee(int id, string cpr, string fName, string lName, string address, int postNo,
                              string eMail, string tlf, DateTime start, string position, decimal money)
        {
            Id = id;
            CprNo = cpr;
            FirstName = fName;
            LastName = lName;
            Address = address;
            PostNo = postNo;
            Email = eMail;
            TlfNo = tlf;
            StartDate = start;
            Position = position;
            PayRatePrHour = money;
            _fields = _dbController.GetEmployeeFields(Id);

        }
        internal List<FieldE> GetFields()
        {
            return _dbController.GetFields();
        }

        internal int NewField(string name)
        {
            FieldE f = new FieldE();
            f.Name = name;
            return _dbController.NewField(f);
        }

        internal int AddField(string name)
        {
            return _dbController.AddField(Id, name);
        }
        internal int DeleteField(string name)
        {
            return _dbController.DeleteField(name);
        }
    }
}

