using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class EmployeeHandlerUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestHrDbReturnSameInstance()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            EmployeeHandler actual = new EmployeeHandler();
            object.ReferenceEquals(_sut, actual);
        }

        [TestMethod]
        public void TestNewEmployeeReturnOne()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            int expected = 1;
            int actual = _sut.NewEmployee("1234567890", "Karin", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     DateTime.Now, "Advokat", 750);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeesReturnTwoEmployees()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            var employees = _sut.GetEmployees();
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void TestGetEmployeesReturnListOfEmployees()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            var employees = _sut.GetEmployees();
            Type actual = employees[0].GetType();
            Type expected = typeof(EmployeeM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateEmployeeReturnOne()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            int expected = 1;
            int actual = _sut.UpdateEmployee(2, "Karine", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     "Advokat", 1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddSubjectToEmployeeReturnOne()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            int expected = 1;
            int actual = _sut.AddSubjectToEmployee(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseEmployeeReturnOne()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            int expected = 1;
            int actual = _sut.CloseEmployee(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteSubjectFromEmployeeReturnOne()
        {
            EmployeeHandler _sut = EmployeeHandler.Instance;
            int expected = 1;
            int actual = _sut.DeleteSubjectFromEmployee(1,2);
            Assert.AreEqual(expected, actual);
        }
    }
}
