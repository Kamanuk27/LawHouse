﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;



namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCase
    {
        Case cHandler = new Case();

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = cHandler.NewCase("test case");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetCaseReturnCase()
        {
            Case actual = cHandler.GetCase(1);
            Type expected = typeof(Case);
            Assert.IsInstanceOfType(actual, expected);
        }

        public void TestNewServiceReturnOne()
        {
            int expected = 1;
            int response = cHandler.NewService(2, DateTime.Now, 2, 100, "Møde i retten", "Karina Olsen");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetCaseReturnCaseIdOne()
        {
            var c1 = cHandler.GetCase(1);
            Assert.AreEqual(c1.Id, 1);
        }

        

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List <Case> cases =  cHandler.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            List<Case> cases = cHandler.GetCases();
            Type actual = cases[0].GetType();
            Type expectedType = typeof(Case);
            Assert.AreEqual(actual, expectedType);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<Service> services = cHandler.GetProvidedServices(1);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = cHandler.GetProvidedServices(1);
            Type actual = services[0].GetType();
            Type expected = typeof(Service);
            Assert.AreEqual(actual, expected);
        }

     
        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int response = cHandler.UpdateCase(2, 2000, "Karina Nielsen");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetPriceReturn2000()
        {
            decimal expected = 2000;
            decimal response = cHandler.GetPrice(1);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int response = cHandler.CloseCase(1, 2000, DateTime.Now);
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void TestUpdateServiceReturnOne()
        {
            int expected = 1;
            int response = cHandler.UpdateService(2, 2, 100, DateTime.Now);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int response = cHandler.DeleteCase(4);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteServiceReturnOne()
        {
            int expected = 1;
            int response = cHandler.DeleteService(2);
            Assert.AreEqual(response, expected);
        }
    }
}
