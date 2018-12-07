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
            throw new NotImplementedException();
        }

        public List<ProvidedServiceM> GetProvidedServices(int caseId)
        {
            throw new NotImplementedException();
        }

        public int UpdateProvidedService(ProvidedServiceM s1)
        {
            throw new NotImplementedException();
        }

        public int DeleteProvidedService(int id)
        {
            throw new NotImplementedException();
        }

        public List<decimal> GetUnitPrices()
        {
            throw new NotImplementedException();
        }
    }
}
