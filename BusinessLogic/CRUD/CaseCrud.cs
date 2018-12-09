﻿using LawHouseLibrary.Models;
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
        public CaseCrud()
        {
            _dbCase = DatabaseFactory.Instance.GetCaseDataAccess();
        }

        internal List<CaseM> GetCases()
        {
            return _dbCase.GetCases();
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
            return _dbCase.NewCase(c);
        }

        internal int UpdateCase(int id, decimal negPrice, string respEmp)
        {
            CaseM cE = new CaseM();
            cE.Id = id;
            cE.NegPrice = negPrice;
            cE.RespEmployee = respEmp;
            return _dbCase.UpdateCase(cE);
        }


        internal int CloseCase(int id, decimal totalPrice, DateTime endDate)
        {
            CaseM cE = new CaseM();
            cE.Id = id;
            cE.TotalPrice = totalPrice;
            cE.EndDate = endDate;
            return _dbCase.CloseCase(cE);
        }

        internal int DeleteCase(int id)
        {
            return _dbCase.DeleteCase(id);
        }
    }
}