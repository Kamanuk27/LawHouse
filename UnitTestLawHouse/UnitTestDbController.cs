using System;
using System.Collections.Generic;
using BusinessLogic;
using LawHouseLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestDbController
    {
        DbController _dbController = DbController.Instance;
        [TestMethod]
        public void TestDbControllerReturnSameInstance()
        {
            DbController actual = new DbController();
            object.ReferenceEquals(_dbController, actual);
        }
        // Create metoder

        [TestMethod]
        public void TestNewCaseReturnOne()
        {
            int expected = 1;
            CaseE c1 = new CaseE(1);
            int response = _dbController.NewCase(c1);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewServiceReturnOne()
        {
            int expected = 1;
            ServiceE s1 = new ServiceE();
            int response = _dbController.NewService(s1);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewClientReturnOne()
        {
            int expected = 1;
            ClientE client = new ClientE();
            int response = _dbController.NewClient(client);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewEmployeeReturnOne()
        {
            int expected = 1;
            EmployeeE e = new EmployeeE();
            int response = _dbController.NewEmployee(e);
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void TestNewLegalServiceReturnOne()
        {
            int expected = 1;
            LegalServiceE ls = new LegalServiceE();
            int response = _dbController.NewLegalService(ls);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestNewFieldReturnOne()
        {
            int expected = 1;
            FieldE f = new FieldE();
            int response = _dbController.NewField(f);
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void TestAddFieldReturnOne()
        {
            int expected = 1;
            int response = _dbController.AddField(1, "New Field to Employee");
            Assert.AreEqual(response, expected);
        }


        // Get/read metoder

        [TestMethod]
        public void TestGetCasesReturnTwoCases()
        {
            List<CaseE> cases = _dbController.GetCases();
            Assert.AreEqual(2, cases.Count);
        }

        [TestMethod]
        public void TestGetCasesReturnListOfCases()
        {
            var cases = _dbController.GetCases();
            Type actual = cases[0].GetType();
            Type expected = typeof(CaseE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnTwoServices()
        {
            List<ServiceE> services = _dbController.GetProvidedServices(1);
            Assert.AreEqual(2, services.Count);
        }

        [TestMethod]
        public void TestGetProvidedServicesReturnListOfServices()
        {
            var services = _dbController.GetProvidedServices(1);
            Type actual = services[0].GetType();
            Type expected = typeof(ServiceE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeesReturnTwoEmployees()
        {
            List<EmployeeE> employees = _dbController.GetEmployees();
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void TestGetEmployeeesReturnListOfEmployees()
        {
            var employees = _dbController.GetEmployees();
            Type actual = employees[0].GetType();
            Type expected = typeof(EmployeeE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetLegalServicesReturnTwoServices()
        {
            List<LegalServiceE> legalServices = _dbController.GetLegalServices();
            Assert.AreEqual(2, legalServices.Count);
        }

        [TestMethod]
        public void TestGetLegalServicesReturnListOfServices()
        {
            var legalServices = _dbController.GetLegalServices();
            Type actual = legalServices[0].GetType();
            Type expected = typeof(LegalServiceE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeFieldsReturnTwoFields()
        {
            List<FieldE> fields = _dbController.GetEmployeeFields(1);
            Assert.AreEqual(2, fields.Count);
        }

        [TestMethod]
        public void TestGetEmployeeFieldsReturnListOfFields()
        {
            var employees = _dbController.GetEmployeeFields(1);
            Type actual = employees[0].GetType();
            Type expected = typeof(FieldE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetFieldsReturnTwoFields()
        {
            List<FieldE> fields = _dbController.GetFields();
            Assert.AreEqual(2, fields.Count);
        }

        [TestMethod]
        public void TestGetFieldsReturnListOfFields()
        {
            var fields = _dbController.GetFields();
            Type actual = fields[0].GetType();
            Type expected = typeof(FieldE);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetClientReturnClientWithCprNo()
        {
            ClientE client = _dbController.GetClient("22222");
            Assert.AreEqual("22222", client.CprNo);
        }

        [TestMethod]
        public void TestGetClientReturnClient()
        {
            var client = _dbController.GetClient("22222");
            Type actual = client.GetType();
            Type expected = typeof(ClientE);
            Assert.AreEqual(expected, actual);
        } 

        [TestMethod]
        public void TestGetLawyersReturnsTwoStrings()
        {
            int expected = 2;
            int actual = _dbController.GetLawyers().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetLawyersReturnsListOfStrings()
        {
            var lawyers = _dbController.GetLawyers();
            Type actual = lawyers[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(expected, actual);
        }
 
        [TestMethod]
        public void TestGetEmplNamesReturnsTwoStrings()
        {
            int expected = 2;
            int actual = _dbController.GetEmplNames().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmplNamesReturnsListOfStrings()
        {
            var names = _dbController.GetEmplNames();
            Type actual = names[0].GetType();
            Type expected = typeof(string);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnTwoDecimal()
        {
            int expected = 2;
            int actual = _dbController.GetUnitPrices().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetUnitPricesReturnListOfDecimal()
        {
            var prices = _dbController.GetUnitPrices();
            Type actual = prices[0].GetType();
            Type expected = typeof(decimal);
            Assert.AreEqual(expected, actual);
        }

        // Update/Close metoder

        [TestMethod]
        public void TestUpdateCaseReturnOne()
        {
            int expected = 1;
            CaseE c1 = new CaseE();
            int actual = _dbController.UpdateCase(c1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateServiceReturnOne()
        {
            int expected = 1;
            ServiceE s1 = new ServiceE();
            int actual = _dbController.UpdateService(s1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseCaseReturnOne()
        {
            int expected = 1;
            CaseE c1 = new CaseE();
            int actual = _dbController.CloseCase(c1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateClientReturnOne()
        {
            int expected = 1;
            ClientE client = new ClientE();
            int actual = _dbController.UpdateClient(client);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseClientReturnOne()
        {
            int expected = 1;
            int actual = _dbController.CloseClient("22222");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateEmployeeReturnOne()
        {
            int expected = 1;
            EmployeeE e = new EmployeeE();
            int actual = _dbController.UpdateEmployee(e);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _dbController.CloseEmployee(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateLegalServiceReturnOne()
        {
            int expected = 1;
            LegalServiceE ls = new LegalServiceE();
            int actual = _dbController.UpdateLegalService(ls);
            Assert.AreEqual(expected, actual);
        }

        //Delete metoder

        [TestMethod]
        public void TestDeleteCaseReturnOne()
        {
            int expected = 1;
            int actual = _dbController.DeleteCase(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteServiceReturnOne()
        {
            int expected = 1;
            int actual = _dbController.DeleteService(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteFieldReturnOne()
        {
            int expected = 1;
            int actual = _dbController.DeleteField("fieldName");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteLegalServiceReturnOne()
        {
            int expected = 1;
            int actual = _dbController.DeleteLegalService(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
