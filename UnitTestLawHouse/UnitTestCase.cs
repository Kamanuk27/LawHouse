﻿using System;
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
            Assert.Equals(c1.Id, 1);
        }
    }
}