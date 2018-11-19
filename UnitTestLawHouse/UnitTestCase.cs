using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary;


namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCase
    {
        Case c1 = new Case();
        [TestMethod]
        public void TestGetCase()
        {
            //Case c1 = new Case();
            //c1.GetCase(1);
            //Assert.AreEqual(c1.Id, 1);

            ICase c2 = c1.GetCase(1);
            Assert.AreEqual(c2.Id, 1);
        }
    }
}
