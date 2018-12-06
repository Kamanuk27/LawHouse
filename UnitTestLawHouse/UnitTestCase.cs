﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using LawHouseLibrary.Entities;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestCase
    {
       private CRUDServices _case = new CRUDServices();

        [TestMethod]
        public void TestInitializeCaseInitializesListOfTwoProvidedservises()
        {
            _case.InitializeCase(2,  3500, "karina Olsen");
            int expected = 2;
            int actual = _case.Services.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewServiceReturnOne()
        { 
            int expected = 1;
            int actual = _case.NewService(1, DateTime.Now, 2, 50, "Møde", "Karina Olsen");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            _case.InitializeCase(2, 3500, "karina Olsen");
            Type actual = _case.Services[0].GetType();
            Type expected = typeof(ServiceE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateServiceReturnOne()
        {
            int expected = 1;
            int actual = _case.UpdateService(1, 2, 50, DateTime.Now, "Møde og kørsel");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnNegotiatedPrice3500()
        {
            _case.InitializeCase(2,  3500, "karina Olsen");
            decimal expected = 3500;
            decimal actual = _case.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetPriceReturnCalculatedPrice4750()
        {
            CRUDServices case2 = new CRUDServices();
            case2.Services = new List<ServiceE>();
            case2.Services.Add(new ServiceE(50, 2));
            case2.Services.Add(new ServiceE(200, 1));
            decimal expected = 4750;
            decimal actual = case2.GetPrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnFirstDecimmal10()
        {
            decimal expected = 10;
            decimal actual = _case.GetUnitPrices()[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnSecondDecimmal750()
        {
            decimal expected = 750;
            decimal actual = _case.GetUnitPrices()[1];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculatePriceReturnCalculatedPrice4750()
        {
            CRUDServices case2 = new CRUDServices();
            case2.Services = new List<ServiceE>();
            case2.Services.Add(new ServiceE(50, 2));
            case2.Services.Add(new ServiceE(200, 1));
            decimal expected = 4750;
            decimal actual = case2.CalculatePrice();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteServiceReturnOne()
        {
            int expected = 1;
            int actual = _case.DeleteService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
