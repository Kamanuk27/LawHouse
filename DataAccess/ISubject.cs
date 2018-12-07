using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISubject
    {
        int NewSubject(SubjectM subject);

        List<SubjectM> GetSubjects();
        List<SubjectM> GetEmployeeSubjectById(int id);
        int UpdateSubject(SubjectM ls);
        int DeleteSubject(int id);
        
    }
}
