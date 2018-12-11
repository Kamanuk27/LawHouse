using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class CaseHandlerUnitTest

    {
        CaseHandler _caseHandler = CaseHandler.Instance;

        [TestMethod]
        public void TestCaseHandlerReturnSameInstance()
        {
            CaseHandler actual = new CaseHandler();
            object.ReferenceEquals(_caseHandler, actual);

        }
        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            int response = _caseHandler.NewCase("testCase", 2, 3, DateTime.Now, 4, 3500);
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            var cases = _caseHandler.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            var cases = _caseHandler.GetCases();
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseM);
            Assert.AreEqual(expected, actual);
        }

        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseHandler.UpdateCase(1, 4000, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseHandler.CloseCase(2, 5000, DateTime.Now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int actual = _caseHandler.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
