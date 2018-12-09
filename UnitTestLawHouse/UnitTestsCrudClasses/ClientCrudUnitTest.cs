using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class ClientCrudUnitTest
    {
        private ClientCrud _clientCrud = new ClientCrud();
        [TestMethod]
        public void TestClientCrudVedInitializationDbClientIsNotNull()
        {
            var o = _clientCrud._dbClient;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestGetClientReturnClientWithTlfNo2222()
        {
            var client = _clientCrud.GetClient("2222");
            Assert.AreEqual("2222", client.TlfNo);
        }

        [TestMethod]
        public void TestGetClientReturnClientM()
        {
            var client = _clientCrud.GetClient("2222");
            Type actual = client.GetType();
            Type expected = typeof(ClientM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewClientReturnOne()
        {
            int expected = 1;
            ClientM client = new ClientM();
            int actual = _clientCrud.NewClient("123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            int expected = 1;
            int actual = _clientCrud.UpdateClient(1, "123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            int expected = 1;
            int actual = _clientCrud.CloseClient(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
