using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCaseCrud
    {
       private CaseCrud _caseCrud = new CaseCrud();

        [TestMethod]
        public void TestCaseCrudVedInitializationDbCaseIsNotNull()
        {
            var o = _caseCrud._dbCase;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            var cases = _caseCrud.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            var cases = _caseCrud.GetCases();
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = _caseCrud.NewCase("testCase", 2, 3, DateTime.Now, 4, 3500);
            Assert.AreEqual(response, expected);
        }

        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseCrud.UpdateCase(1, 4000, "employee");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseCrud.CloseCase(2, 5000, DateTime.Now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseCrud.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
