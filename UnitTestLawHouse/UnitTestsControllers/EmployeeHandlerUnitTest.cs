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
        private EmployeeHandler _employeeHandler = EmployeeHandler.Instance;

        [TestMethod]
        public void TestHrDbReturnSameInstance()
        {
            EmployeeHandler actual = new EmployeeHandler();
            object.ReferenceEquals(_employeeHandler, actual);

        }

        [TestMethod]
        public void TestNewEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeHandler.NewEmployee("1234567890", "Karin", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     DateTime.Now, "Advokat", 750);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeesReturnTwoEmployees()
        {
            var employees = _employeeHandler.GetEmployees();
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void TestGetEmployeesReturnListOfEmployees()
        {
            var employees = _employeeHandler.GetEmployees();
            Type actual = employees[0].GetType();
            Type expected = typeof(EmployeeM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeHandler.UpdateEmployee(2, "Karine", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     "Advokat", 1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddSubjectToEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeHandler.AddSubjectToEmployee(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeHandler.CloseEmployee(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteSubjectFromEmployee()
        {

        }
    }
}
