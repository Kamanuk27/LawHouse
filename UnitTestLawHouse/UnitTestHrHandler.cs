using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestHrHandler
    {
        HrHandler hrHandler = HrHandler.Instance;

        [TestMethod]
        public void TesthrHandlerReturnOneInstance()
        {
            HrHandler actual = new HrHandler();
            object.ReferenceEquals(hrHandler, actual);
        }
        [TestMethod]
        public void TestGetLawyersReturnsListOfStrings()
        {
            var lawyers = hrHandler.GetLawyers();
            Type actual = lawyers[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetLawyersReturnsTwoStrings()
        {
            int expected = 2;
            int actual = hrHandler.GetLawyers().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsListOfStrings()
        {
            var names = hrHandler.GetEmplNames();
            Type actual = names[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsTwoStrings()
        {
            int expected = 2;
            int actual = hrHandler.GetEmplNames().Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
