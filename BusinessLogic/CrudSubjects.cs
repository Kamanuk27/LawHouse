using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class CrudSubjects
    {
        private LhouseDb _dbController;
        public CrudSubjects()
        {
            _dbController = LhouseDb.Instance;
        }
        internal List<SubjectM> GetSubject()
        {
            return  _dbController.Getsubjects();
            
        }

        internal int NewSubject(string name, int hours, int time, decimal price)
        {
            SubjectM subject = new SubjectM();
            subject.Name = name;
            subject.HoursEstimate = hours;
            subject.TimeEstimate = time;
            subject.Price = price;


            return _dbController.NewSubject(subject);
        }

        internal int UpdateSubject(int id, string name, int hours, int time, decimal price)
        {
            SubjectM subject = new SubjectM();
            subject.Id = id;
            subject.Name = name;
            subject.HoursEstimate = hours;
            subject.TimeEstimate = time;
            subject.Price = price;
            return _dbController.UpdateSubjects(subject);
        }

       
        internal int DeleteSubject(int id)
        {
            return _dbController.DeleteLegalService(id);
        }
    }
}
