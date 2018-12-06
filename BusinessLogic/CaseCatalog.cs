using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class CaseCatalog
    {
        private CaseDb _dbController;
        public CaseCatalog()
        {
            _dbController = CaseDb.Instance;
        }

        internal List<CaseE> GetCases()
        {
            return _dbController.GetCases();
        }

        internal int NewCase(string caseName, int clientId, int serviceId, DateTime startTime, int empId, decimal negoPrice)
        {
            CaseE c = new CaseE();
            c.Name = caseName;
            c.ClientId = clientId;
            c.ServiceId = serviceId;
            c.StartDate = startTime;
            c.RespEmpId = empId;
            c.NegPrice = negoPrice;
            return _dbController.NewCase(c);
        }

        internal int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            CaseE cE = new CaseE();
            cE.Id = id;
            cE.NegPrice = negPrice;
            cE.RespEmployee = respEmp;
            return _dbController.UpdateCase(cE);
        }


        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            CaseE cE = new CaseE();
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
        internal List<EmployeeE> GetLawyers()
        {
            return _dbController.GetLawyers();
        }

        internal List<EmployeeE> GetEmplNames()
        {
            return _dbController.GetEmplNames();
        }

        internal List<LegalServiceE> GetLegalServices()
        {
            return _dbController.GetLegalServices();
        }

    }
}
