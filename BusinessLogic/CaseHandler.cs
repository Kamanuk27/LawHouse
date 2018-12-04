﻿using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;



namespace BusinessLogic
{  
    // Klass CaseHandler er en Controller, der står for at sende informationer mellem UI og BL
   
    public class CaseHandler
    {
       
        private Case _case;
        private CaseCatalog _cases;
        private ClientCatalog _clients;
        private static CaseHandler _instance;
        public CaseHandler()
        {
            _case = new Case();
            _cases = new CaseCatalog();
            _clients = new ClientCatalog();
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

        // Fra Case
        public void InitializeCase(int id, decimal negPrice, string respEmp)
        {
            _case.InitializeCase (id, negPrice, respEmp);
        }

       
        public int NewService(int caseID, DateTime date, int hours, int km, string comment, string respEmpl)
        {
            return _case.NewService(caseID, date, hours, km, comment, respEmpl);
        }


        public List<ServiceE> GetProvidedServices(int caseId)
        {
            return _case.GetProvidedServices();
           
        }
     
        public int UpdateService(int id, int hours, int km, DateTime date, string comment)
        {
            return _case.UpdateService(id, hours, km, date, comment);
        }

        public decimal GetPrice(int id)
        {
            return _case.GetPrice();
        }
        public int DeleteService(int id)
        {
            return _case.DeleteService(id);
        }

        // Fra CaseCatalog

        public int NewCase(string name, string client, string service, DateTime startTime, string respEmpl, decimal negPrice)
        {
            return _cases.NewCase(name, client, service, startTime, respEmpl, negPrice);
        }
        public List<CaseE> GetCases()
        {
            return _cases.GetCases();
        }
        public int CloseCase(int id, decimal total, DateTime endDate)
        {
            return _cases.CloseCase(id, total, endDate);
        }

        public int UpdateCaseE(int id, decimal negPrice, string respEmp)
        {
            return _cases.UpdateCase(id, negPrice, respEmp);
        }

        public int DeleteCase(int id)
        {
            return _cases.DeleteCase(id);
        }

      

        // Hjælpemetoder, som returner navne af aktør til dropdown menuer på UI;
        public List<string> GetLawyers()
        {
            return _cases.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _cases.GetEmplNames();
        }


        // fra ClientCatalog
        public ClientE GetClient(string cpr)
        {
            return _clients.GetClient(cpr);
        }

        public int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            return _clients.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        public int UpdateClient(string cpr, string address, int postNo, string eMail, string tlf)
        {
            return _clients.UpdateClient(cpr, address, postNo, eMail, tlf);
        }
        public int CloseClient(string cpr)
        {
            return _clients.CloseClient(cpr);
        }

    }
}
