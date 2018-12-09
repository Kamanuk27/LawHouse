using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class ProvidedServicesCrudUnitTest
    {
        private ProvidedServiceCrud _provServices = new ProvidedServiceCrud();

        [TestMethod]
        public void TestProvidedServicesCrudVedInitializationDbProvidedServicesIsNotNull()
        {
            var o = _provServices._dbProvidedService;
            Assert.IsNotNull(o);
        }
        [TestMethod]
        public void TestNewProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServices.NewProvidedService(1, DateTime.Now, 2, 200, "Møde", 1);
            Assert.AreEqual(expected, actual);
        }

        // CaseId 1 returnerer en tom liste, caseId 2 returnerer en lIste med to ydelser på
        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            var services = _provServices.GetProvidedServices(2);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = _provServices.GetProvidedServices(2);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServices.UpdateProvidedService(1, 2, 150, DateTime.Now, "Møde med kunden og kørsel");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnNegotiatedPrice4500()
        {
            decimal expected = 4500;
            decimal actual = _provServices.GetPrice(1, 4500);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturn0IfThereIsNoNegPriceAndNoServicesOnCase()
        {
            decimal expected = 0;
            decimal actual = _provServices.GetPrice(1, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetPriceReturnCalculatedPrice4750()
        {
            decimal expected = 4750;
            decimal actual = _provServices.GetPrice(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnTwoDecimal()
        {
            int expected = 2;
            int actual = _provServices.GetUnitPrices().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnListOfDecimal()
        {
            var prices = _provServices.GetUnitPrices();
            Type actual = prices[0].GetType();
            Type expected = typeof(decimal);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculatePriceReturn0IfListOfServicesIsEmpty()
        {
            // CaseId 1 returnerer en tom liste
            decimal expected = 0;
            decimal actual = _provServices.CalculatePrice(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculatePriceReturn4750IfListOfServicesIsNotEmpty()
        {
            
            decimal expected = 4750;
            decimal actual = _provServices.CalculatePrice(2);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestDeleteProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServices.DeleteProvidedService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
