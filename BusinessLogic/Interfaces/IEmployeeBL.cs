using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IEmployeeBL
    {

        int NewEmployee(string cpr, string fName, string lName, string address, int postNo,
            string eMail, string tlf, DateTime start, string position, decimal money);

        List<EmployeeM> GetEmployees();

        int AddSubjectToEmployee(int eId, int sId);

        int DeleteSubjectFromEmployee(int eId, int sId);

        int UpdateEmployee(int id, string fName, string lName, string address, int postNo, string eMail, string tlf, string position, decimal money);

        int CloseEmployee(int id);
    }
}
