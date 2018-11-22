using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using DataAccess.Repositories;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCase
    {
        LhHandler LhHandler = new LhHandler();

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.NewCase(1);
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void TestGetCaseReturnCaseIdOne()
        {
            var c1 = LhHandler.GetCase(1);
            Assert.AreEqual(c1.Id, 1);
        }

        [TestMethod]
        public void TestGetCaseReturnCase()
        {
            Case c1 = LhHandler.GetCase(1);
            Type expectedType = typeof(Case);
            Assert.IsInstanceOfType(c1, expectedType);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List <Case> cases =  LhHandler.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<Service> services = LhHandler.GetProvidedServices(1);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestEditServiceReturnOne()
        {
            int expected = 1;
            int response = LhHandler.EditService(2, 50);
            Assert.AreEqual(response, expected);
        }

       
    }
}
