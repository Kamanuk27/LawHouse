using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class ClientHandlerUnitTest
    {
        ClientHandler _clientHandler = ClientHandler.Instance;

        [TestMethod]
        public void TestClientHandlerReturnSameInstance()
        {
            ClientHandler actual = new ClientHandler();
            object.ReferenceEquals(_clientHandler, actual);

        }
        [TestMethod]
        public void TestGetClientReturnClientWithTlfNo2222()
        {
            var client = _clientHandler.GetClient("2222");
            Assert.AreEqual("2222", client.TlfNo);
        }

        [TestMethod]
        public void TestGetClientReturnClientM()
        {
            var client = _clientHandler.GetClient("2222");
            Type actual = client.GetType();
            Type expected = typeof(ClientM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewClientReturnOne()
        {
            int expected = 1;
            ClientM client = new ClientM();
            int actual = _clientHandler.NewClient("123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            int expected = 1;
            int actual = _clientHandler.UpdateClient(1, "123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            int expected = 1;
            int actual = _clientHandler.CloseClient(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
