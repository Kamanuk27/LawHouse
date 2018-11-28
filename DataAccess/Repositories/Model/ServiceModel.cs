using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace DataAccess.Model
{
    class ServiceModel : ServiceRepo
    {
        public ServiceModel() : base()
        {

        }
        public ServiceModel(int hours, int km) : base (hours, km)
        {
            Hours = hours;
            Km = km;
        }
    }
}
