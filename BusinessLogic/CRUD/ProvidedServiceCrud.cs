﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary.Models;

namespace BusinessLogic
{
   internal class ProvidedServiceCrud
    {
        internal IProvidedService _dbProvidedService;
        internal ProvidedServiceCrud()
        {
            _dbProvidedService = DatabaseFactory.Instance.GetProvidedServiceDataAccess();
        }

        internal int NewProvidedService(int caseID, DateTime date, int hours, int km, string comment, int respEmpl)
        {
            ProvidedServiceM s1 = new ProvidedServiceM
            {
                CaseID = caseID,
                Date = date,
                Hours = hours,
                Km = km,
                Comment = comment,
                EmployeeID = respEmpl
            };
            return _dbProvidedService.NewProvidedService(s1);
        }
        internal List<ProvidedServiceM> GetProvidedServices(int id)
        {
            return _dbProvidedService.GetProvidedServices(id);
        }

        internal List<ProvidedServiceM> GetProvidedServicesByEmplId(int emplId, DateTime fromTime, DateTime toTime)
        {
            return _dbProvidedService.GetProvidedServicesByEmplId(emplId, fromTime, toTime);
        }
        internal int UpdateProvidedService(int id, int hours, int km, DateTime date, string comment)
        {
            ProvidedServiceM s1 = new ProvidedServiceM
            {
                Id = id,
                Hours = hours,
                Km = km,
                Date = date,
                Comment = comment
            };
            return _dbProvidedService.UpdateProvidedService(s1);
        }
        internal decimal GetPrice(int caseId, decimal negPrice)
        {
            return negPrice > 0 ? negPrice : CalculatePrice(caseId);
        }
        internal List<decimal> GetUnitPrices()
        {
            return _dbProvidedService.GetUnitPrices();
        }

        internal decimal CalculatePrice(int caseId)
        {
            List< ProvidedServiceM> Services = _dbProvidedService.GetProvidedServices(caseId);
            if (Services.Count > 0)
            {
                PriceCalculator calculator = new PriceCalculator();
                return calculator.CalculatePrice(GetUnitPrices(), Services);
            }
            else
                return 0;
        }

        internal int DeleteProvidedService(int id)
        {
            return _dbProvidedService.DeleteProvidedService(id);
        }
    }
}

