using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using LawHouseLibrary.Entities;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCases
    {
        Cases cases = new Cases();

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = cases.NewCase("name", "client", "service", DateTime.Now, "employee", 0);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewServiceReturnOne()
        {
            int expected = 1;
            int response = cases.NewService(2, DateTime.Now, 2, 100, "Møde i retten", "Karina Olsen");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetCaseReturnCaseIdOne()
        {
            var c1 = cases.GetCase(1);
            Assert.AreEqual(c1.Id, 1);
        }

        [TestMethod]
        public void TestGetCaseReturnCase()
        {
            CaseE actual = cases.GetCase(1);
            Type expected = typeof(CaseE);
            Assert.IsInstanceOfType(actual, expected);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List <CaseE> actual =  cases.GetCases();
            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            var responce = cases.GetCases();
            Type actual = responce[0].GetType();
            Type expected = typeof(CaseE);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<ServiceE> services = cases.GetProvidedServices(1);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = cases.GetProvidedServices(1);
            Type actual = services[0].GetType();
            Type expected = typeof(ServiceE);
            Assert.AreEqual(actual, expected);
        }

      

        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int response = cases.UpdateCase(2, 2000, "Karina Nielsen");
            Assert.AreEqual(expected, response);
        }

        //[TestMethod]
        //public void TestGetUnitPricesReturnDecimalArray()
        //{
        //    Type expected = typeof(decimal[]);
        //    var response = cases.GetUnitPrices().GetType();
        //    Assert.AreEqual(expected, response);
        //}

        [TestMethod]
        public void TestGetUnitPricesReturn2EllementsInArray()
        {
            int expected = 2;
            var response = cases.GetUnitPrices().Length;
            Assert.AreEqual(expected, response);
        }

        //[TestMethod]
        //public void TestGetPriceReturn3250()
        //{
        //    decimal expected = 3250;
        //    decimal response = cases.GetPrice(1);
        //    Assert.AreEqual(expected, response);
        //}

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int response = cases.CloseCase(1, 2000, DateTime.Now);
            Assert.AreEqual(response, expected);
        }



        [TestMethod]
        public void TestUpdateServiceReturnOne()
        {
            int expected = 1;
            int response = cases.UpdateService(2, 2, 100, DateTime.Now, "string");
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int response = cases.DeleteCase(4);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestDeleteServiceReturnOne()
        {
            int expected = 1;
            int response = cases.DeleteService(2);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestGetLawyersReturnsListOfStrings()
        {
            var lawyers = cases.GetLawyers();
            Type actual = lawyers[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetLawyersReturnsTwoStrings()
        {
            int expected = 2;
            int actual = cases.GetLawyers().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsListOfStrings()
        {
            var names = cases.GetEmplNames();
            Type actual = names[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsTwoStrings()
        {
            int expected = 2;
            int actual = cases.GetEmplNames().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
