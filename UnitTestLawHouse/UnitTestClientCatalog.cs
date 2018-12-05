using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Entities;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestClientCatalog
    {
        ClientCatalog clients = new ClientCatalog();
        [TestMethod]
        public void TestGetClientReturnClientWithTlf()
        {
            ClientE client = clients.GetClient(12345);
            Assert.AreEqual(12345, client.TlfNo);
        }

        [TestMethod]
        public void TestGetClientReturnClient()
        {
            var client = clients.GetClient(12345);
            Type actual = client.GetType();
            Type expected = typeof(ClientE);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewClientReturnOne()
        {
            int expected = 1;
            int actual = clients.NewClient(111111, "Klara", "Olsen", "Irisvej 1", 7100, "eMail", 12345678);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            int expected = 1;
            int actual = clients.UpdateClient("Klara", "Olsen", 1111111, "Irisvej 5", 7100, "eMail", 12345678);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            int expected = 1;
            int actual = clients.CloseClient(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
