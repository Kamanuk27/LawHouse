﻿using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class PriceCalculator
    {
     
        public PriceCalculator()
        {

        }

       
        internal decimal CalculatePrice(List<decimal> prices, List<Service> servList)
        {
           int [] count = CountServices(servList);
           return prices[0] * count[0] + prices[1] * count[1];
        }
       
        internal int [] CountServices(List <Service> servList)
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
