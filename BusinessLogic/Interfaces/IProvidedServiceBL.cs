using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProvidedServiceBL
    {
        int NewProvidedService(int caseID, DateTime date, int hours, int km, string comment, int respEmpl);
        List<ProvidedServiceM> GetProvidedServices(int caseId);
        List<ProvidedServiceM> GetProvidedServicesByEmplId(int emplId, DateTime fromTime, DateTime toTime);
        int UpdateProvidedService(int id, int hours, int km, DateTime date, string comment);
        decimal GetPrice(int id, decimal negPrice);
        int DeleteProvidedService(int id);
        List<int> GetworkDone();
    }
}
