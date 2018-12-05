using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ILhouseDataAccess
    {
        int NewEmployee(EmployeeE employee);
        int NewLegalService(LegalServiceE legal);
        int NewField(FieldE f);

        List<LegalServiceE> GetLegalServices();
        List<FieldE> GetFields();
        List<FieldE> GetEmpFields(int id);
        List<EmployeeE> GetEmployees();

      


        int UpdateEmployee(EmployeeE emp);
        int AddFieldToEmployee(int eId, int fId);
        int UpdateLegalService(LegalServiceE ls);
        int CloseEmployee(int id);

        int DeleteLegalService(int id);
        int DeleteField(int id);



    }
}
