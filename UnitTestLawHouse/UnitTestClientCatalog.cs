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
        public void TestGetClientReturnClientWithCpr()
        {
            ClientE client = clients.GetClient("11111");
            Assert.AreEqual("11111", client.CprNo);
        }

        [TestMethod]
        public void TestGetClientReturnClient()
        {
            var client = clients.GetClient("22222");
            Type actual = client.GetType();
            Type expected = typeof(ClientE);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewClientReturnOne()
        {
            int expected = 1;
            int actual = clients.NewClient("444444", "Karina", "Sørensen", "Irisvej 2", 7100, "Karina@gmail.com", "12345678");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            int expected = 1;
            int actual = clients.UpdateClient("444444", "Horsensvej3", 6000, "Karina23.dk", "12345678");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            int expected = 1;
            int actual = clients.CloseClient("444444");
            Assert.AreEqual(expected, actual);
        }
    }
}
