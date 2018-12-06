using DataAccess;
using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class LhouseDb
    {
        private static LhouseDb _instance;
        private ILhouseDataAccess _persistence;
        internal LhouseDb()
        {
          _persistence = DatabaseFactory.Instance.GetHrDataAccess();
        }
        internal static LhouseDb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhouseDb();
                return _instance;
            }
        }
        // Create
        internal int NewEmployee(EmployeeM employee)
        {
            return _persistence.NewEmployee(employee);
        }
        internal int NewSubject(SubjectM legal)
        {
            return _persistence.NewSubject(legal);
        }

        internal int AddField(int eId, int fId)
        {
            return _persistence.AddSpecializationToEmployee(eId, fId);
        }

        // Get/read metoder
        internal List<EmployeeM> GetEmployees()
        {
            return _persistence.GetEmployees();
        }
        internal List<SubjectM> GetEmpSpecializations(int id)
        {
            return _persistence.GetEmpSpecializations(id);
        }

     
        internal List<SubjectM> Getsubjects()
        {
            return _persistence.GetSubjects();
        }

        // Update
        internal int UpdateEmployee(EmployeeM emp)
        {
            return _persistence.UpdateEmployee(emp);
        }

        internal int CloseEmployee(int id)
        {
            return _persistence.CloseEmployee(id);
        }

        internal int UpdateSubjects(SubjectM ls)
        {
            return _persistence.UpdateSubject(ls);
        }

        //Delete metoder
        internal int DeleteLegalService(int id)
        {
            return _persistence.DeleteSubject(id);
        }
    }
}
