using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    // Lisa
    [TestClass]
    public class ProvidedServicesCrudUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestProvidedServicesCrudVedInitializationDbProvidedServicesIsNotNull()
        {
           ProvidedServiceCrud _sut = new ProvidedServiceCrud();
           var o = _sut._dbProvidedService;
           Assert.IsNotNull(o);
        }
        [TestMethod]
        public void TestNewProvidedServiceReturnOne()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            int expected = 1;
            int actual = _sut.NewProvidedService(1, DateTime.Now, 2, 200, "Møde", 1);
            Assert.AreEqual(expected, actual);
        }

        // CaseId 1 returnerer en tom liste, caseId 2 returnerer en lIste med to ydelser på
        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            var services = _sut.GetProvidedServices(2);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            var services = _sut.GetProvidedServices(2);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetProvidedServicesByEmplIdReturnTwoServices()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            var services = _sut.GetProvidedServicesByEmplId(1, DateTime.Now, DateTime.Now);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesByEmplIdReturnListOfServices()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            var services = _sut.GetProvidedServicesByEmplId(1, DateTime.Now, DateTime.Now);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateProvidedServiceReturnOne()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            int expected = 1;
            int actual = _sut.UpdateProvidedService(1, 2, 150, DateTime.Now, "Møde med kunden og kørsel");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnNegotiatedPrice4500()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            decimal expected = 4500;
            decimal actual = _sut.GetPrice(1, 4500);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturn0IfThereIsNoNegPriceAndNoServicesOnCase()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            decimal expected = 0;
            decimal actual = _sut.GetPrice(1, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetPriceReturnCalculatedPrice4750()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            decimal expected = 4750;
            decimal actual = _sut.GetPrice(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnTwoDecimal()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            int expected = 2;
            int actual = _sut.GetUnitPrices().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnListOfDecimal()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            var prices = _sut.GetUnitPrices();
            Type actual = prices[0].GetType();
            Type expected = typeof(decimal);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculatePriceReturn0IfListOfServicesIsEmpty()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            // CaseId 1 returnerer en tom liste
            decimal expected = 0;
            decimal actual = _sut.CalculatePrice(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculatePriceReturn4750IfListOfServicesIsNotEmpty()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            decimal expected = 4750;
            decimal actual = _sut.CalculatePrice(2);
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void TestCountWorkReturnTwoEllementsInArray()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(5, 200));

            int actual = _sut.CountWorkDone(services).Length;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountWorkDoneReturn7AtFirstPlace()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(5, 200));

            int actual = _sut.CountWorkDone(services)[0];
            int expected = 7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountWorkDoneReturn250AtSecondPlace()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            List<ProvidedServiceM> services = new List<ProvidedServiceM>();
            services.Add(new ProvidedServiceM(2, 50));
            services.Add(new ProvidedServiceM(5, 200));

            int actual = _sut.CountWorkDone(services)[1];
            int expected = 250;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteProvidedServiceReturnOne()
        {
            ProvidedServiceCrud _sut = new ProvidedServiceCrud();
            int expected = 1;
            int actual = _sut.DeleteProvidedService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
