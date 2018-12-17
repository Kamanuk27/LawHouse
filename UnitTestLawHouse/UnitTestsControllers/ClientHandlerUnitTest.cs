using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    // Lisa
    [TestClass]
    public class ClientHandlerUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestClientHandlerReturnSameInstance()
        {
            ClientHandler _sut = ClientHandler.Instance;
            ClientHandler actual = new ClientHandler();
            object.ReferenceEquals(_sut, actual);

        }
        [TestMethod]
        public void TestGetClientReturnClientWithTlfNo2222()
        {
            ClientHandler _sut = ClientHandler.Instance;
            var client = _sut.GetClient("2222");
            Assert.AreEqual("2222", client.TlfNo);
        }

        [TestMethod]
        public void TestGetClientReturnClientM()
        {
            ClientHandler _sut = ClientHandler.Instance;
            var client = _sut.GetClient("2222");
            Type actual = client.GetType();
            Type expected = typeof(ClientM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetClientsReturnTwoClients()
        {
            ClientHandler _sut = new ClientHandler();
            int actual = _sut.GetClients(true).Count;
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestGetClientsReturnListOfClientM()
        {
            ClientHandler _sut = new ClientHandler();
            Type expected = typeof(ClientM);
            Type actual = _sut.GetClients(true)[0].GetType();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewClientReturnOne()
        {
            ClientHandler _sut = ClientHandler.Instance;
            int expected = 1;
            ClientM client = new ClientM();
            int actual = _sut.NewClient("123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            ClientHandler _sut = ClientHandler.Instance;
            int expected = 1;
            int actual = _sut.UpdateClient(1, "123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            ClientHandler _sut = ClientHandler.Instance;
            int expected = 1;
            int actual = _sut.CloseClient(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
