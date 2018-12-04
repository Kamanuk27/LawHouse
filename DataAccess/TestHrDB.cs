using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class TestHrDB : IHrDataAccess
    {
        // Metoder for Create
        public int NewLegalService(LegalServiceE legal)
        {
            return 1;
        }
        public int NewEmployee(EmployeeE employee)
        {
            return 1;
        }

        public int NewField(FieldE f)
        {
            return 1;
        }
        public int AddFieldToEmployee(int id, string name)
        {
            return 1;
        }

        // Metoder for Read/Get
        public List<FieldE> GetFields()
        {
            List<FieldE> fields = new List<FieldE>();
            fields.Add(new FieldE(1));
            fields.Add(new FieldE(2));
            return fields;
        }

        public List<FieldE> GetEmpFields(int id)
        {
            List<FieldE> fields = new List<FieldE>();
            fields.Add(new FieldE(1));
            fields.Add(new FieldE(2));
            return fields;
        }

        public List<EmployeeE> GetEmployees()
        {
            List<EmployeeE> employees = new List<EmployeeE>();
            employees.Add(new EmployeeE(23));
            employees.Add(new EmployeeE(12));
            return employees;
        }

        public List<LegalServiceE> GetLegalServices()
        {
            List<LegalServiceE> legalServices = new List<LegalServiceE>();
            legalServices.Add(new LegalServiceE(1));
            legalServices.Add(new LegalServiceE(2));
            return legalServices;
        }

        //Metoder for Update
        public int UpdateLegalService(LegalServiceE ls)
        {
            return 1;
        }
        public int UpdateEmployee(EmployeeE emp)
        {
            return 1;
        }

        public int CloseEmployee(int id)
        {
            return 1;
        }

        //Metoder for Delete
        public int DeleteLegalService(int id)
        {
            return 1;
        }

        public int DeleteField(string name)
        {
            return 1;
        }
    }
}
