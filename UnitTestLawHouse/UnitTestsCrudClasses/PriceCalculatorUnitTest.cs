using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    // Stanja
    [TestClass]
    public class PriceCalculatorUnitTest
    {
       
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestCalculatePriceReturn3750()
        {
            PriceCalculator _sut = new PriceCalculator();
            List <ProvidedServiceM> _services = new List<ProvidedServiceM>();
            _services.Add(new ProvidedServiceM(50, 2));
            _services.Add(new ProvidedServiceM(100, 1));

            List<decimal> prices = new List<decimal>();
            prices.Add(10);
            prices.Add(750);

            decimal actual = _sut.CalculatePrice(prices, _services);
            decimal expected = 3750;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturn3AtFirstPlace()
        {
            PriceCalculator _sut = new PriceCalculator();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(1, 100));

            int actual = _sut.CountServices(services)[0];
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturn150AtSecondPlace()
        {
            PriceCalculator _sut = new PriceCalculator();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(1, 100));

            int actual = _sut.CountServices(services)[1];
            int expected = 150;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountServicesReturnTwoEllementsInList()
        {
            PriceCalculator _sut = new PriceCalculator();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(1, 100));

            int actual = _sut.CountServices(services).Length;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}
