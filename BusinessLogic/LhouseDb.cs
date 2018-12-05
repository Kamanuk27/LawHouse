using DataAccess;
using LawHouseLibrary.Entities;
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
          _persistence = LHouseFactory.Instance.GetHrDataAccess();
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
        internal int NewEmployee(EmployeeE employee)
        {
            return _persistence.NewEmployee(employee);
        }
        internal int NewLegalService(LegalServiceE legal)
        {
            return _persistence.NewLegalService(legal);
        }

        internal int NewField(FieldE f)
        {
            return _persistence.NewField(f);
        }
        internal int AddField(int eId, int fId)
        {
            return _persistence.AddFieldToEmployee(eId, fId);
        }

        // Get/read metoder
        internal List<EmployeeE> GetEmployees()
        {
            return _persistence.GetEmployees();
        }
        internal List<FieldE> GetEmployeeFields(int id)
        {
            return _persistence.GetEmpFields(id);
        }

        internal List<FieldE> GetFields()
        {
            return _persistence.GetFields();
        }
        internal List<LegalServiceE> GetLegalServices()
        {
            return _persistence.GetLegalServices();
        }

        // Update
        internal int UpdateEmployee(EmployeeE emp)
        {
            return _persistence.UpdateEmployee(emp);
        }

        internal int CloseEmployee(int id)
        {
            return _persistence.CloseEmployee(id);
        }

        internal int UpdateLegalService(LegalServiceE ls)
        {
            return _persistence.UpdateLegalService(ls);
        }

        //Delete metoder
        internal int DeleteField(int id)
        {
            return _persistence.DeleteField(id);
        }

        internal int DeleteLegalService(int id)
        {
            return _persistence.DeleteLegalService(id);
        }
    }
}
