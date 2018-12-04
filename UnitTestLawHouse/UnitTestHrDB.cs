using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestHrDb
    {
        HrDb _dbController = HrDb.Instance; 
        [TestMethod]
        public void TestHrDbReturnSameInstance()
        {
            HrDb actual = new HrDb();
            object.ReferenceEquals(_dbController, actual);
        }
        // Create metoder

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

        // Get/Read metoder
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

        // Update metoder
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
        // Delete metoder

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
