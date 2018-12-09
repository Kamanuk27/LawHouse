using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class ProvidedServicesHandlerUnitTest
    {
        private ProvidedServiceHandler _provServicesHandler = ProvidedServiceHandler.Instance;

        [TestMethod]
        public void TestProvidedServiceHandlerReturnSameInstance()
        {
            ProvidedServiceHandler actual = new ProvidedServiceHandler();
            object.ReferenceEquals(_provServicesHandler, actual);

        }
        [TestMethod]
        public void TestNewProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServicesHandler.NewProvidedService(1, DateTime.Now, 2, 200, "Møde", 1);
            Assert.AreEqual(expected, actual);
        }

        // CaseId 1 returnerer en tom liste, caseId 2 returnerer en lIste med to ydelser på
        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            var services = _provServicesHandler.GetProvidedServices(2);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = _provServicesHandler.GetProvidedServices(2);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServicesHandler.UpdateProvidedService(1, 2, 150, DateTime.Now, "Møde med kunden og kørsel");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnNegotiatedPrice4500()
        {
            decimal expected = 4500;
            decimal actual = _provServicesHandler.GetPrice(1, 4500);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturn0IfThereIsNoNegPriceAndNoServicesOnCase()
        {
            decimal expected = 0;
            decimal actual = _provServicesHandler.GetPrice(1, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetPriceReturnCalculatedPrice4750()
        {
            decimal expected = 4750;
            decimal actual = _provServicesHandler.GetPrice(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteProvidedServiceReturnOne()
        {
            int expected = 1;
            int actual = _provServicesHandler.DeleteProvidedService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
