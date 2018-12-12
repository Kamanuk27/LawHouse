using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class ProvidedServicesHandlerUnitTest
    {
        // Navnet _sut  står for System Under Test

        [TestMethod]
        public void TestProvidedServiceHandlerReturnSameInstance()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            ProvidedServiceHandler actual = new ProvidedServiceHandler();
            object.ReferenceEquals(_sut, actual);
        }
        [TestMethod]
        public void TestNewProvidedServiceReturnOne()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            int expected = 1;
            int actual = _sut.NewProvidedService(1, DateTime.Now, 2, 200, "Møde", 1);
            Assert.AreEqual(expected, actual);
        }

        // CaseId 1 returnerer en tom liste, caseId 2 returnerer en lIste med to ydelser på
        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            var services = _sut.GetProvidedServices(2);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            var services = _sut.GetProvidedServices(2);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetProvidedServicesByEmplIdReturnTwoServices()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            var services = _sut.GetProvidedServicesByEmplId(1, DateTime.Now, DateTime.Now);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesByEmplIdReturnListOfServices()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            var services = _sut.GetProvidedServicesByEmplId(1, DateTime.Now, DateTime.Now);
            Type actual = services[0].GetType();
            Type expected = typeof(ProvidedServiceM);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestUpdateProvidedServiceReturnOne()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            int expected = 1;
            int actual = _sut.UpdateProvidedService(1, 2, 150, DateTime.Now, "Møde med kunden og kørsel");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnNegotiatedPrice4500()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            decimal expected = 4500;
            decimal actual = _sut.GetPrice(1, 4500);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturn0IfThereIsNoNegPriceAndNoServicesOnCase()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            decimal expected = 0;
            decimal actual = _sut.GetPrice(1, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetPriceReturnCalculatedPrice4750()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            decimal expected = 4750;
            decimal actual = _sut.GetPrice(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteProvidedServiceReturnOne()
        {
            ProvidedServiceHandler _sut = ProvidedServiceHandler.Instance;
            int expected = 1;
            int actual = _sut.DeleteProvidedService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
