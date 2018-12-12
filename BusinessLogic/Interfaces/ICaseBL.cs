using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Interfaces
{
    public interface ICaseBL
    {
        int NewCase(string name, int clientId, int serviceId, DateTime startTime, int empId, decimal negPrice);
        List<CaseM> GetCases();
        int CloseCase(int id, decimal total, DateTime endDate);
        int UpdateCase(int id, decimal negPrice, int respEmpId);
        int DeleteCase(int id);


    }
}
