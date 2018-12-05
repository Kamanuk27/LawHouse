using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCaseCatalog
    {
        CaseCatalog caseCat = new CaseCatalog();
        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List<CaseE> cases = caseCat.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            var cases = caseCat.GetCases();
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseE);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int actual = caseCat.NewCase("testCase", 1, 2, DateTime.Now, 3, 3500);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int actual = caseCat.UpdateCase(1, 4000, "Karin Olsen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int actual = caseCat.CloseCase(1, 4000, DateTime.Now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int actual = caseCat.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestGetLawyersReturnsTwoEmployeeEs()
        {
            int expected = 2;
            int actual = caseCat.GetLawyers().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetLawyersReturnsListOfEmployeeEs()
        {
            var lawyers = caseCat.GetLawyers();
            Type actual = lawyers[0].GetType();
            Type expected = typeof(EmployeeE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsTwoEmployeeEs()
        {
            int expected = 2;
            int actual = caseCat.GetEmplNames().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsListOfEmployeeEs()
        {
            var names = caseCat.GetEmplNames();
            Type actual = names[0].GetType();
            Type expected = typeof(EmployeeE);
            Assert.AreEqual(expected, actual);
        }
    }
}
