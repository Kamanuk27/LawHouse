using DataAccess;
using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class HrDb
    {
        private static HrDb _instance;
        private IHrDataAccess _persistence;
        internal HrDb()
        {
          _persistence = DatabaseFactory.Instance.GetHrDataAccess();
        }
        internal static HrDb Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HrDb();
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
        internal int AddField(int id, string name)
        {
            return _persistence.AddFieldToEmployee(id, name);
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
        internal int DeleteField(string name)
        {
            return _persistence.DeleteField(name);
        }

        internal int DeleteLegalService(int id)
        {
            return _persistence.DeleteLegalService(id);
        }
    }
}
