using System;
using System.Collections.Generic;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCaseHandler
    {
        CaseHandler LhHandler = CaseHandler.Instance;

        [TestMethod]
        public void TestLhHandlerReturnOneInstance()
        {
            CaseHandler actual = new CaseHandler();
            object.ReferenceEquals(LhHandler, actual);
        }

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.NewCase("test case");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewServiceReturnOne()
        {
            int expected = 1;
            int response = LhHandler.NewService(2, DateTime.Now, 2, 100, "Møde i retten", "Karina Olsen");
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
            CaseRepository c1 = LhHandler.GetCase(1);
            Type expectedType = typeof(CaseRepository);
            Assert.IsInstanceOfType(c1, expectedType);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List<CaseRepository> cases = LhHandler.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            List<CaseRepository> cases = LhHandler.GetCases();
            Type actual = cases[0].GetType();
            Type expectedType = typeof(CaseRepository);
            Assert.AreEqual(actual, expectedType);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<Service> services = LhHandler.GetProvidedServices(1);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = LhHandler.GetProvidedServices(1);
            Type actual = services[0].GetType();
            Type expected = typeof(Service);
            Assert.AreEqual(actual, expected);
        }



        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.UpdateCase(2, 2000, "Karina Nielsen");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetPriceReturn2000()
        {
            decimal expected = 2000;
            decimal response = LhHandler.GetPrice(1);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.CloseCase(1, 2000, DateTime.Now);
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void TestUpdateServiceReturnOne()
        {
            int expected = 1;
            int response = LhHandler.UpdateService(2, 2, 100, DateTime.Now, "comment");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.DeleteCase(4);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteServiceReturnOne()
        {
            int expected = 1;
            int response = LhHandler.DeleteService(2);
            Assert.AreEqual(response, expected);
        }
    }
}
