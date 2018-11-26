﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LhHandler
    {
        private static LhHandler _instance;
        Case cHandler;
        Employee eHandler;
        public LhHandler()
        {
            cHandler = new Case();
            eHandler = new Employee();
        }

        // singleton - der kan være kun en instance af controller.
        public static LhHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LhHandler();
                return _instance;
            }
        }

        public int NewCase (int id) // her kommer mange variabler fra Form
        {
            Case c1 = new Case();
            c1.Id = id;
           return  cHandler.NewCase(c1);
        }
        public int CloseCase(int id, string caseName, string clientName, string service_Name, DateTime startDate, string respEmpl, decimal totalPrice, DateTime endDate)
        {
            Case c1 = new Case();
            c1.Id = id;
            c1.Name = caseName;
            c1.Client = clientName;
            c1.Service = service_Name;
            c1.StartDate = startDate;
            c1.RespEmployee = respEmpl;
            c1.EndDate = endDate;
            return cHandler.CloseCase(c1);
        }

        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl) // her kommer mange variabler fra Form
        {
           return cHandler.NewService(caseID, date, hours, km, comment, respEmpl);                                              
        }                                                                             
                                                                                      
        public Case GetCase(int id)                                                   
        {
            return cHandler.GetCase(id);
        }

        public List <Case> GetCases()
        {
            return cHandler.GetCases();
        }

        public List <Service> GetProvidedServices(int caseId)
        {
            return cHandler.GetProvidedServices(caseId);
        }

        public int UpdateService(int id, int hours, int km, DateTime date)
        {
            return cHandler.UpdateService(id, hours, km, date);
        }

        public int UpdateCase(int id, decimal negPrice, string respEmp )
        {
            return cHandler.UpdateCase(id, negPrice, respEmp);
        }

        public int DeleteCase(int id)
        {
            return cHandler.DeleteCase(id);
        }

        public int DeleteService(int id)
        {
            return cHandler.DeleteService(id);
        }

        // metoder til dropdown felter
        public List <string> GetLawyers()
        {
            return eHandler.GetLawyers();
        }

        public List <string> GetEmplNames()
        {
            return eHandler.GetEmplNames();
        }


    }
}
