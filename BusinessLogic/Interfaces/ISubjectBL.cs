using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ISubjectBL
    {
        int NewSubject(string name, int hours, int time, decimal price);
        List<SubjectM> GetSubjects();
        List<SubjectM> GetEmployeeSubjectsById(int id);
        int UpdateSubject(int id, string name, int hours, int time, decimal price);
        int DeleteSubject(int id);
    }
}
