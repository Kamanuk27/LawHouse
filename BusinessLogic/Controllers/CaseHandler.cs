﻿using LawHouseLibrary.Models;
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
        public int NewCase(string name, int clientId, int serviceId, DateTime startTime, int empId, decimal negPrice)
        {
            return _caseCrud.NewCase(name, clientId, serviceId, startTime, empId, negPrice);
        }
        public List<CaseM> GetCases()
        {
            return _caseCrud.GetCases();
        }

        public int CloseCase(int id, decimal total, DateTime endDate)
        {
            return _caseCrud.CloseCase(id, total, endDate);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            return _caseCrud.UpdateCase(id, negPrice, respEmp);
        }

        public int DeleteCase(int id)
        {
            return _caseCrud.DeleteCase(id);
        }

    }
}