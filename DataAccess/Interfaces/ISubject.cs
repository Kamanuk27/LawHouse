using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace DataAccess
{
    //Andriy
    public interface ISubject
    {
        int NewSubject(SubjectM subject);

        List<SubjectM> GetSubjects();
        List<SubjectM> GetEmployeeSubjectsById(int id);
        int UpdateSubject(SubjectM ls);
        int DeleteSubject(int id);
        
    }
}
