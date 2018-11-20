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
            c1.GetCase(1);
            Assert.AreEqual(c1.Id, 1);
        }
        //[TestMethod]
        //public void TestRegistrerService()
        //{
        //    int expected = 1;
        //    int response = c1.RegisterService (2, 50);
        //    Assert.AreEqual(response, 1);
        //}
    }
}
