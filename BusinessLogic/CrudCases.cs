using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class CrudCases
    {
        private CaseDb _dbController;
        public CrudCases()
        {
            _dbController = CaseDb.Instance;
        }

        internal List<CaseM> GetCases()
        {
            return _dbController.GetCases();
        }

        internal int NewCase(string caseName, int clientId, int serviceId, DateTime startTime, int empId, decimal negoPrice)
        {
            CaseM c = new CaseM();
            c.Name = caseName;
            c.ClientId = clientId;
            c.SubjectId = serviceId;
            c.StartDate = startTime;
            c.RespEmpId = empId;
            c.NegPrice = negoPrice;
            return _dbController.NewCase(c);
        }

        internal int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            CaseM cE = new CaseM();
            cE.Id = id;
            cE.NegPrice = negPrice;
            cE.RespEmployee = respEmp;
            return _dbController.UpdateCase(cE);
        }


        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            CaseM cE = new CaseM();
            cE.Id = id;
            cE.TotalPrice = totalPrice;
            cE.EndDate = endDate;
            return _dbController.CloseCase(cE);
        }

        internal int DeleteCase(int id)
        {
            return _dbController.DeleteCase(id);
        }

        // Hjælpemetoder, som returner navne af aktør til dropdown menuer på UI;
        internal List<EmployeeM> GetLawyers()
        {
            return _dbController.GetLawyers();
        }

        internal List<EmployeeM> GetEmplNames()
        {
            return _dbController.GetEmplNames();
        }

    }
}
