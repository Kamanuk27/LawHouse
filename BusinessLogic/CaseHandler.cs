using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{
    // Klass CaseHandler håndterer mange CaseE enttities, dvs Get, Update, Delete 
    // Har en instance af Case og virker som controller for at videresende opgaver til Case.
    internal class CaseHandler
    {
        private DbController _dbController;
        private Case _case;
        public CaseHandler()
        {
            _dbController = DbController.Instance;
            _case = new Case(_dbController);
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
        internal void InitiateCaseFromCaseE(CaseE cE)
        {
            _case.InitializeCase(cE);
        }

        internal int CloseCaseE(int id, decimal totalPrice, DateTime endDate)
        {
            CaseE cE = new CaseE();
            cE.Id = id;
            cE.TotalPrice = totalPrice;
            cE.EndDate = endDate;
            return _dbController.CloseCase(cE);
        }

        internal int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            return _case.NewService(caseID, date, hours, km, comment, respEmpl);
        }

        internal List<CaseE> GetCases()
        {
            return _dbController.GetCases();
        }

        internal List<ServiceE> GetProvidedServices(int caseId)
        {
            return _case.GetProvidedServices();
           
        }
     
        internal int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _case.UpdateService(id, hours, km, date, comment);
        }

        internal int UpdateCaseE(int id, decimal negPrice, string respEmp)
        {
            CaseE cE = new CaseE();
            cE.Id = id;
            cE.NegPrice = negPrice;
            cE.RespEmployee = respEmp;
            return _dbController.UpdateCase(cE);
        }

        internal decimal GetPrice(int id)
        {
            return _case.GetPrice();
        }
     
        
        internal int DeleteCaseE(int id)
        {
            return _dbController.DeleteCase(id);
        }

        internal int DeleteService(int id)
        {
            return _case.DeleteService(id);
        }

        // Hjælpemetoder, som returnere navne af aktør til dropdown menuer på IU;
        internal List<string> GetLawyers()
        {
            return _dbController.GetLawyers();
        }

        internal List<string> GetEmplNames()
        {
            return _dbController.GetEmplNames();
        }

        internal List <string> GetClientNames()
        {
            return _dbController.GetClientNames();
        }
    }
}
