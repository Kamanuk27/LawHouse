using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    public interface IProvidedService
    {
        int NewProvidedService(ProvidedServiceM s1);
        List<ProvidedServiceM> GetProvidedServices(int caseId);
        int UpdateProvidedService(ProvidedServiceM s1);
        int DeleteProvidedService(int id);
         List<decimal> GetUnitPrices();
        List<ProvidedServiceM> GetProvidedServicesByEmplId(int emplId, DateTime fromTime, DateTime toTime);


    }
}
