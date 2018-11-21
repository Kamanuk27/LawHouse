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
        Case c1 = new Case();

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            Case c2 = new Case();
            int expected = 1;
            int response = c1.NewCase(c2);
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void TestGetCaseReturnCaseIdOne()
        {
            c1.GetCase(1);
            Assert.AreEqual(c1.Id, 1);
        }

        [TestMethod]
        public void TestGetCaseReturnCase()
        {
            c1.GetCase(1);
            Type expectedType = typeof(CaseRepo);
            Assert.IsInstanceOfType(c1, expectedType);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List <CaseRepo> cases =  c1.GetCases();
            Assert.AreEqual(cases.Count, 2);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<ServiceRepo> services = c1.GetProvidedServices();
            Assert.AreEqual(services.Count, 2);
        }

        [TestMethod]
        public void TestEditServiceReturnOne()
        {
            Service service = new Service();
            int expected = 1;
            int response = c1.EditService(service);
            Assert.AreEqual(response, expected);
        }

       
    }
}
