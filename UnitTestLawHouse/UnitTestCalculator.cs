using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCalculator
    {
        PriceCalculator calculator = new PriceCalculator();

        [TestMethod]
        public void TestCalculatePriceReturn3750()
        {
            List <Service> _services = new List<Service>();
            _services.Add(new Service(50, 2));
            _services.Add(new Service(100, 1));

            List<decimal> prices = new List<decimal>();
            prices.Add(10);
            prices.Add(750);

            decimal actual = calculator.CalculatePrice(prices, _services);
            decimal expected = 3750;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturn3AtFirstPlace()
        {
            List<Service> services = new List<Service>();
            services.Add(new Service(2, 50));
            services.Add(new Service(1, 100));

            int actual = calculator.CountServices(services)[0];
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturn150AtSecondPlace()
        {
            List<Service> services = new List<Service>();
            services.Add(new Service(2, 50));
            services.Add(new Service(1, 100));

            int actual = calculator.CountServices(services)[1];
            int expected = 150;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturnTwoEllementsInArray()
        {
            List<Service> services = new List<Service>();
            services.Add(new Service(2, 50));
            services.Add(new Service(1, 100));

            int actual = calculator.CountServices(services).Length;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
