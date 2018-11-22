using System;
using System.Collections.Generic;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestEmployee
    {
        LhHandler LhHandler = LhHandler.Instance;

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
