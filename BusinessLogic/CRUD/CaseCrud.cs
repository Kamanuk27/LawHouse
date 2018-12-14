using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace BusinessLogic
{
    internal class CaseCrud
    {
        internal ICase _dbCase;
        internal CaseCrud()
        {
            _dbCase = DatabaseFactory.Instance.GetCaseDataAccess();
        }

        internal List<CaseM> GetCases(bool active)
        {
            return _dbCase.GetCases(active);
        }

        internal List<CaseM> GetCasesByClientId(int id)
        {
            return _dbCase.GetCasesByClientId(id);
        }


        internal int NewCase(string caseName, DateTime startTime, decimal negoPrice, int serviceId, int empId, int clientId)
        {
            CaseM c = new CaseM();
            c.Name = caseName;
            c.StartDate = startTime;
            c.NegPrice = negoPrice;
            c.SubjectId = serviceId;
            c.RespEmpId = empId;
             c.ClientId = clientId;
            return _dbCase.NewCase(c);
        }

        internal int UpdateCase(int id, decimal negPrice, int respEmpId)
        {
            CaseM c = new CaseM();
            c.Id = id;
            c.NegPrice = negPrice;
            c.RespEmpId = respEmpId;
            return _dbCase.UpdateCase(c);
        }


        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            CaseM c = new CaseM();
            c.Id = id;
            c.TotalPrice = totalPrice;
            c.EndDate = endDate;
            return _dbCase.CloseCase(c);
        }

        internal int DeleteCase(int id)
        {
            return _dbCase.DeleteCase(id);
        }
    }
}
