using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLawHouse
{
    [TestClass]
    class UnitTestEmployee
    {
        LhHandler LhHandler = new LhHandler();

        [TestMethod]
        public void TestGetLawyersReturnsListOfStrings()
        {
            var c1 = LhHandler.GetLawyers();
            Type expectedType = typeof(string);
            Assert.IsInstanceOfType(c1, expectedType);
        }
    }
}
