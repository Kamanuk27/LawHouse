using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestLhHandler
    {
        LhHandler LhHandler = LhHandler.Instance;

        [TestMethod]
        public void TestLhHandlerReturnOneInstance()
        {
            LhHandler actual = new LhHandler();
            object.ReferenceEquals(LhHandler, actual);
        }

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = LhHandler.NewCase("name", "client", "service", DateTime.Now, "employee", 0);
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
            Case c1 = LhHandler.GetCase(1);
            Type expectedType = typeof(Case);
            Assert.IsInstanceOfType(c1, expectedType);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List<Case> cases = LhHandler.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            List<Case> cases = LhHandler.GetCases();
            Type actual = cases[0].GetType();
            Type expectedType = typeof(Case);
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
        public void TestGetPriceReturn3250()
        {
            decimal expected = 3250;
            decimal response = LhHandler.GetPrice(1);
            Assert.AreEqual (expected, response);
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

        
        [TestMethod]
        public void TestGetLawyersReturnsListOfStrings()
        {
            var lawyers = LhHandler.GetLawyers();
            Type actual = lawyers[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetLawyersReturnsTwoStrings()
        {
            int expected = 2;
            int actual = LhHandler.GetLawyers().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsListOfStrings()
        {
            var names = LhHandler.GetEmplNames();
            Type actual = names[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsTwoStrings()
        {
            int expected = 2;
            int actual = LhHandler.GetEmplNames().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
