using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
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

        public List<SubjectM> GetSubject()
        {
            return _subjectCrud.GetSubject();
        }

        public int UpdateSubjects(int id, string name, int hours, int time, decimal price)
        {
            return _subjectCrud.UpdateSubject(id, name, hours, time, price);
        }


        public int DeleteSubject(int id)
        {
            return _subjectCrud.DeleteSubject(id);
        }
    }
}
