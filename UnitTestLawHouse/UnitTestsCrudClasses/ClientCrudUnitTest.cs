using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class ClientCrudUnitTest
    {
        // Navnet _sut  står for System Under Test
        
        [TestMethod]
        public void TestClientCrudVedInitializationDbClientIsNotNull()
        {
            ClientCrud _sut = new ClientCrud();
            var o = _sut._dbClient;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestGetClientReturnClientWithTlfNo2222()
        {
            ClientCrud _sut = new ClientCrud();
            var client = _sut.GetClient("2222");
            Assert.AreEqual("2222", client.TlfNo);
        }

        [TestMethod]
        public void TestGetClientReturnClientM()
        {
            ClientCrud _sut = new ClientCrud();
            var client = _sut.GetClient("2222");
            Type actual = client.GetType();
            Type expected = typeof(ClientM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetClientsReturnTwoClients()
        {
            ClientCrud _sut = new ClientCrud();
            int actual = _sut.GetClients(true).Count;
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestGetClientsReturnListOfClientM()
        {
            ClientCrud _sut = new ClientCrud();
            Type expected = typeof(ClientM);
            Type actual = _sut.GetClients(true)[0].GetType();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewClientReturnOne()
        {
            ClientCrud _sut = new ClientCrud();
            int expected = 1;
            ClientM client = new ClientM();
            int actual = _sut.NewClient("123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            ClientCrud _sut = new ClientCrud();
            int expected = 1;
            int actual = _sut.UpdateClient(1, "123456", "Peter", "Nielsen", "Solvej 4", 8600, "Peters@email.com", "22222");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            ClientCrud _sut = new ClientCrud();
            int expected = 1;
            int actual = _sut.CloseClient(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
