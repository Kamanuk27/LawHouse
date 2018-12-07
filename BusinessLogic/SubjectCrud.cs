using DataAccess;
using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class SubjectCrud
    {

        private ISubject _dbSubject;
        public SubjectCrud()
        {
            _dbSubject = DatabaseFactory.Instance.GetSubjectDataAccess();
        }
        internal List<SubjectM> GetSubject()
        {
            return _dbSubject.GetSubjects();

        }

        internal int NewSubject(string name, int hours, int time, decimal price)
        {
            SubjectM subject = new SubjectM();
            subject.Name = name;
            subject.HoursEstimate = hours;
            subject.TimeEstimate = time;
            subject.Price = price;


            return _dbSubject.NewSubject(subject);
        }

        internal int UpdateSubject(int id, string name, int hours, int time, decimal price)
        {
            SubjectM subject = new SubjectM();
            subject.Id = id;
            subject.Name = name;
            subject.HoursEstimate = hours;
            subject.TimeEstimate = time;
            subject.Price = price;
            return _dbSubject.UpdateSubject(subject);
        }


        internal int DeleteSubject(int id)
        {
            return _dbSubject.DeleteSubject(id);
        }
    }
}
