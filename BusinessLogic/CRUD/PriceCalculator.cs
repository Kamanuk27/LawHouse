﻿using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    // Stanja
    internal class PriceCalculator
    {
        internal decimal CalculatePrice(List<decimal> prices, List<ProvidedServiceM> servList)
        {
           int [] count = CountServices(servList);
            decimal total = prices[0] * count[0] + prices[1] * count[1];
           return total;
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
