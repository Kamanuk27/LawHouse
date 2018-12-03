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
        private DbController _dbController;
        public CaseCatalog()
        {
            _dbController = DbController.Instance;
        }

        internal List<CaseE> GetCases()
        {
            return _dbController.GetCases();
        }

        internal int NewCaseE(string caseName, string client, string service, DateTime startTime, string respEmpl, decimal negoPrice)
        {
            CaseE cE = new CaseE();
            cE.Name = caseName;
            cE.Client = client;
            cE.Service = service;
            cE.StartDate = startTime;
            cE.RespEmployee = respEmpl;
            cE.NegPrice = negoPrice;
            return _dbController.NewCase(cE);
        }

        internal int UpdateCaseE(int id, decimal negPrice, string respEmp)
        {
            CaseE cE = new CaseE();
            cE.Id = id;
            cE.NegPrice = negPrice;
            cE.RespEmployee = respEmp;
            return _dbController.UpdateCase(cE);
        }


        internal int CloseCaseE(int id, decimal totalPrice, DateTime endDate)
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
        internal List<string> GetLawyers()
        {
            return _dbController.GetLawyers();
        }

        internal List<string> GetEmplNames()
        {
            return _dbController.GetEmplNames();
        }

    }
}
