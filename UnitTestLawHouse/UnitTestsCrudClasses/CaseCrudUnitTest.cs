using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    // Stanja
    [TestClass]
    public class UnitTestCaseCrud
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestCaseCrudVedInitializationDbCaseIsNotNull()
        {
            CaseCrud _sut = new CaseCrud();
            var o = _sut._dbCase;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            CaseCrud _sut = new CaseCrud();
            var cases = _sut.GetCases(true);
            Assert.AreEqual(2, cases.Count);
        }
        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            CaseCrud _sut = new CaseCrud();
            var cases = _sut.GetCasesByClientId(1);
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseM);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestGetCasesByClientIdReturnTwoCases()
        {
            CaseCrud _sut = new CaseCrud();
            var cases = _sut.GetCasesByClientId(1);
            Assert.AreEqual(2, cases.Count);
        }
       
        [TestMethod]
        public void TestGetCasesByClientIdReturnListOfCases()
        {
            CaseCrud _sut = new CaseCrud();
            var cases = _sut.GetCasesByClientId(1);
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseM);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            CaseCrud _sut = new CaseCrud();
            int expected = 1;
            int response = _sut.NewCase("testCase", DateTime.Now, 3500, 1, 1, 1);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            CaseCrud _sut = new CaseCrud();
            int expected = 1;
            int actual = _sut.UpdateCase(1, 4000, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            CaseCrud _sut = new CaseCrud();
            int expected = 1;
            int actual = _sut.CloseCase(2, 5000, DateTime.Now);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            CaseCrud _sut = new CaseCrud();
            int expected = 1;
            int actual = _sut.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
