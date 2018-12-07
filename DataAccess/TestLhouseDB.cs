using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class TestLhouseDB : ILhouseDataAccess
    {
        // Metoder for Create
        public int NewSubject(SubjectM legal)
        {
            return 1;
        }
        public int NewEmployee(EmployeeM employee)
        {
            return 1;
        }

        //public int NewField(FieldE f)
        //{
        //    return 1;
        //}
        public int AddSpecializationToEmployee(int eId, int fId)
        {
            return 1;
        }

        // Metoder for Read/Get
        //public List<FieldE> GetFields()
        //{
        //    List<FieldE> fields = new List<FieldE>();
        //    fields.Add(new FieldE(1));
        //    fields.Add(new FieldE(2));
        //    return fields;
        //}

        //public List<FieldE> GetEmpFields(int id)
        //{
        //    List<FieldE> fields = new List<FieldE>();
        //    fields.Add(new FieldE(1));
        //    fields.Add(new FieldE(2));
        //    return fields;
        //}

        public List<SubjectM> GetEmpSpecializations(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeM> GetEmployees()
        {
            List<EmployeeM> employees = new List<EmployeeM>();
            employees.Add(new EmployeeM(23));
            employees.Add(new EmployeeM(12));
            return employees;
        }

        public List<SubjectM> GetSubjects()
        {
            List<SubjectM> legalServices = new List<SubjectM>();
            legalServices.Add(new SubjectM(1));
            legalServices.Add(new SubjectM(2));
            return legalServices;
        }

        //Metoder for Update
        public int UpdateSubject(SubjectM ls)
        {
            return 1;
        }
        public int UpdateEmployee(EmployeeM emp)
        {
            return 1;
        }

        public int CloseEmployee(int id)
        {
            return 1;
        }

        //Metoder for Delete
        public int DeleteSubject(int id)
        {
            return 1;
        }

        public int DeleteField(int id)
        {
            return 1;
        }
    }
}
