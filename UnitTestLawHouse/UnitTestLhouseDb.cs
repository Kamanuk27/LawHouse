using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace UnitTestLawHouse
{
    [TestClass]
    public class UnitTestLhouseDb
    {
        //LhouseDb _dbController = LhouseDb.Instance; 
        //[TestMethod]
        //public void TestHrDbReturnSameInstance()
        //{
        //    LhouseDb actual = new LhouseDb();
        //    object.ReferenceEquals(_dbController, actual);
        //}
        //// Create metoder

        //[TestMethod]
        //public void TestNewEmployeeReturnOne()
        //{
        //    int expected = 1;
        //    EmployeeM e = new EmployeeM();
        //    int response = _dbController.NewEmployee(e);
        //    Assert.AreEqual(response, expected);
        //}
        //[TestMethod]
        //public void TestNewLegalServiceReturnOne()
        //{
        //    int expected = 1;
        //    SubjectM ls = new SubjectM();
        //    int response = _dbController.NewSubject(ls);
        //    Assert.AreEqual(response, expected);
        //}
        //[TestMethod]
        //public void TestNewFieldReturnOne()
        //{
        //    //int expected = 1;
        //    //FieldE f = new FieldE();
        //    //int response = _dbController.NewField(f);
        //    //Assert.AreEqual(response, expected);
        //}

        //[TestMethod]
        //public void TestAddFieldReturnOne()
        //{
        //    int expected = 1;
        //    int response = _dbController.AddField(1, 2);
        //    Assert.AreEqual(response, expected);
        //}

        //// Get/Read metoder
        //[TestMethod]
        //public void TestGetEmployeeesReturnTwoEmployees()
        //{
        //    List<EmployeeM> employees = _dbController.GetEmployees();
        //    Assert.AreEqual(2, employees.Count);
        //}

        //[TestMethod]
        //public void TestGetEmployeeesReturnListOfEmployees()
        //{
        //    var employees = _dbController.GetEmployees();
        //    Type actual = employees[0].GetType();
        //    Type expected = typeof(EmployeeM);
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestGetLegalServicesReturnTwoServices()
        //{
        //    List<SubjectM> legalServices = _dbController.Getsubjects();
        //    Assert.AreEqual(2, legalServices.Count);
        //}

        //[TestMethod]
        //public void TestGetLegalServicesReturnListOfServices()
        //{
        //    var legalServices = _dbController.Getsubjects();
        //    Type actual = legalServices[0].GetType();
        //    Type expected = typeof(SubjectM);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestGetEmployeeFieldsReturnTwoFields()
        //{
        //    //List<FieldE> fields = _dbController.GetEmployeeFields(1);
        //    //Assert.AreEqual(2, fields.Count);
        //}

        //[TestMethod]
        //public void TestGetEmployeeFieldsReturnListOfFields()
        //{
        //    //var employees = _dbController.GetEmployeeFields(1);
        //    //Type actual = employees[0].GetType();
        //    //Type expected = typeof(FieldE);
        //    //Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestGetFieldsReturnTwoFields()
        //{
        //    //List<FieldE> fields = _dbController.GetFields();
        //    //Assert.AreEqual(2, fields.Count);
        //}

        //[TestMethod]
        //public void TestGetFieldsReturnListOfFields()
        //{
        //    //var fields = _dbController.GetFields();
        //    //Type actual = fields[0].GetType();
        //    //Type expected = typeof(FieldE);
        //    //Assert.AreEqual(expected, actual);
        //}

        //// Update metoder
        //[TestMethod]
        //public void TestUpdateEmployeeReturnOne()
        //{
        //    int expected = 1;
        //    EmployeeM e = new EmployeeM();
        //    int actual = _dbController.UpdateEmployee(e);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestCloseEmployeeReturnOne()
        //{
        //    int expected = 1;
        //    int actual = _dbController.CloseEmployee(1);
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void TestUpdateLegalServiceReturnOne()
        //{
        //    int expected = 1;
        //    SubjectM ls = new SubjectM();
        //    int actual = _dbController.UpdateSubjects(ls);
        //    Assert.AreEqual(expected, actual);
        //}
        //// Delete metoder

        //[TestMethod]
        //public void TestDeleteFieldReturnOne()
        //{
        //    //int expected = 1;
        //    //int actual = _dbController.DeleteField(2);
        //    //Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void TestDeleteLegalServiceReturnOne()
        //{
        //    int expected = 1;
        //    int actual = _dbController.DeleteLegalService(1);
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
