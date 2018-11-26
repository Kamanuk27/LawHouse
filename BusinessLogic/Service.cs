using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace BusinessLogic
{
    public class Service : ServiceRepo
    {

        public Service()
        {

        }
        public Service(int caseID, DateTime date, int houres, int km, string comment, string respEmp)
        {
            Date = date;
            CaseID = caseID;
            Hours = houres;
            Km = km;
            Comment = comment;
            EmployeeName = respEmp;
        }
    }
}
