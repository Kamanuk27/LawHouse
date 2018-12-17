using System.Collections.Generic;
using LawHouseLibrary.Models;

namespace DataAccess
{
    //Andriy
    public interface IEmployee
    {
        int NewEmployee(EmployeeM employee);
        List<EmployeeM> GetEmployees();
        int UpdateEmployee(EmployeeM emp);
        int AddSubjectToEmployee(int eId, int sId);
        int CloseEmployee(int id);
        int DeleteSubjectFromEmployee (int eId, int sId);

    }
}
