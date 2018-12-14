using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic 
{
    public class CaseHandler
    {
        CaseCrud _caseCrud;
        public static CaseHandler _instance;
        public CaseHandler()
        {
            _caseCrud = new CaseCrud();
        }
        public static CaseHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CaseHandler();
                return _instance;
            }
        }
        public int NewCase(string caseName, DateTime startTime, decimal negoPrice, int serviceId, int empId, int clientId)
        {
            return _caseCrud.NewCase(caseName, startTime, negoPrice, serviceId, empId, clientId);
        }
        public List<CaseM> GetCases(bool active)
        {
            return _caseCrud.GetCases(active);
        }

        public List<CaseM> GetCasesByClientId(int id)
        {
            return _caseCrud.GetCasesByClientId(id);
        }


        public int CloseCase(int id, decimal total, DateTime endDate)
        {
            return _caseCrud.CloseCase(id, total, endDate);
        }

        public int UpdateCase(int id, decimal negPrice, int respEmpId)
        {
            return _caseCrud.UpdateCase(id, negPrice, respEmpId);
        }

        public int DeleteCase(int id)
        {
            return _caseCrud.DeleteCase(id);
        }

    }
}
