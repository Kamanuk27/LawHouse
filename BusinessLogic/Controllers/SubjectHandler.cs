using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    // Andriy
    public class SubjectHandler
    {

        private static SubjectHandler _instance;
        private SubjectCrud _subjectCrud;

        public SubjectHandler()
        {
            _subjectCrud = new SubjectCrud();
        }

        public static SubjectHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SubjectHandler();
                return _instance;
            }
        }

        public int NewSubject(string name, int hours, int time, decimal price)
        {
            return _subjectCrud.NewSubject(name, hours, time, price);
        }

        public List<SubjectM> GetSubjects()
        {
            return _subjectCrud.GetSubjects();
        }
        public List<SubjectM> GetEmployeeSubjectsById(int id)
        {
            return _subjectCrud.GetEmployeeSubjectsById(id);
        }

        public int UpdateSubject(int id, string name, int hours, int time, decimal price)
        {
            return _subjectCrud.UpdateSubject(id, name, hours, time, price);
        }


        public int DeleteSubject(int id)
        {
            return _subjectCrud.DeleteSubject(id);
        }
    }
}
