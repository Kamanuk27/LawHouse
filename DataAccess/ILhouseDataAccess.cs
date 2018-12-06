using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ILhouseDataAccess
    {
        int NewEmployee(EmployeeM employee);
        int NewSubject(SubjectM subject);

        List<SubjectM> GetSubjects();
        List<SubjectM> GetEmpSpecializations(int id);
        List<EmployeeM> GetEmployees();
        //List<ProvidedServiceM> GetEmployeesProvServices(int id, DateTime from, DateTime to);

       


        int UpdateEmployee(EmployeeM emp);
        int AddSpecializationToEmployee(int eId, int sId);
        int UpdateSubject(SubjectM ls);
        int CloseEmployee(int id);

        int DeleteSubject(int id);
       
    }
}
