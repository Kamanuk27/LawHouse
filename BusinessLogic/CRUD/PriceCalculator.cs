using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class PriceCalculator
    {
        internal decimal CalculatePrice(List<decimal> prices, List<ProvidedServiceM> servList)
        {
           int [] count = CountServices(servList);
           return prices[0] * count[0] + prices[1] * count[1];
        }
       
        internal int [] CountServices(List <ProvidedServiceM> servList)
        {
            int[] count = new int[2];
            foreach (var item in servList)
            {
                count [0] += item.Km;
                count[1] += item.Hours; 
            }
            return count;
        }

       
    }
}
