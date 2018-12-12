using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class CaseHandlerUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestCaseHandlerReturnSameInstance()
        {
            CaseHandler _sut = CaseHandler.Instance;
            CaseHandler actual = new CaseHandler();
            object.ReferenceEquals(_sut, actual);

        }
        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            CaseHandler _sut = CaseHandler.Instance;
            int expected = 1;
            int response = _sut.NewCase("testCase", 2, 3, DateTime.Now, 4, 3500);
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            CaseHandler _sut = CaseHandler.Instance;
            var cases = _sut.GetCases(true);
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            CaseHandler _sut = CaseHandler.Instance;
            var cases = _sut.GetCases(true);
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseM);
            Assert.AreEqual(expected, actual);
        }

        public void TestUpdateCaseReturnOne()
        {
            CaseHandler _sut = CaseHandler.Instance;
            int expected = 1;
            int actual = _sut.UpdateCase(1, 4000, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            CaseHandler _sut = CaseHandler.Instance;
            int expected = 1;
            int actual = _sut.CloseCase(2, 5000, DateTime.Now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            CaseHandler _sut = CaseHandler.Instance;
            int expected = 1;
            int actual = _sut.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
