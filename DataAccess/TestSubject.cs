using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class TestSubject : ISubject
    {
        public int DeleteSubject(int id)
        {
            return 1;
        }

        public List<SubjectM> GetEmployeeSubjectById(int id)
        {
            List<SubjectM> legalServices = new List<SubjectM>();
            legalServices.Add(new SubjectM(1));
            legalServices.Add(new SubjectM(2));
            return legalServices;
        }

        public List<SubjectM> GetSubjects()
        {
            List<SubjectM> legalServices = new List<SubjectM>();
            legalServices.Add(new SubjectM(1));
            legalServices.Add(new SubjectM(2));
            return legalServices;
        }

        public int NewSubject(SubjectM subject)
        {
            return 1;
        }

        public int UpdateSubject(SubjectM ls)
        {
            return 1;
        }
    }
}
