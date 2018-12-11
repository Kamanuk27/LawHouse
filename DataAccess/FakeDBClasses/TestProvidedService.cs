using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    internal class TestProvidedService : IProvidedService
    {
        public int NewProvidedService(ProvidedServiceM s1)
        {
            return 1;
        }

        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            // if/else for at teste metoden, som skal returnere 0 hvis der ingen services er på listen.
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            if (caseId == 1)
            {
                return services;
            }
            else
            {
                services.Add(new ProvidedServiceM(50, 2));
                services.Add(new ProvidedServiceM(200, 1));
                return services;
            }
        }

        public int UpdateProvidedService(ProvidedServiceM s1)
        {
            return 1;
        }

        public int DeleteProvidedService(int id)
        {
            return 1;
        }

        public List<decimal> GetUnitPrices()
        {
            List<decimal> prices = new List<decimal>();
            prices.Add(10);
            prices.Add(750);
            return prices;
        }

        public List<ProvidedServiceM> GetProvidedServicesByEmplId(int emplId, DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }
    }
}
