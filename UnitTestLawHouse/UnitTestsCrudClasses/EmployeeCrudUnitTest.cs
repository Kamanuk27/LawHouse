using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class EmployeeCrudUnitTest
    {
        private EmployeeCrud _employeeCrud = new EmployeeCrud();
        [TestMethod]
        public void TestEmployeeCrudVedInitializationDbEmployeeIsNotNull()
        {
            var o = _employeeCrud._dbEmployee;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestNewEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeCrud.NewEmployee("1234567890", "Karin", "Olsen", "Florasvej 1", 
                                                     6000, "Karin@gmail.com", "22222222",
                                                     DateTime.Now, "Advokat", 750);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeesReturnTwoEmployees()
        {
            var employees = _employeeCrud.GetEmployees();
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void TestGetEmployeesReturnListOfEmployees()
        {
            var employees = _employeeCrud.GetEmployees();
            Type actual = employees[0].GetType();
            Type expected = typeof(EmployeeM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeCrud.UpdateEmployee(2, "Karine", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     "Advokat", 1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddSubjectToEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeCrud.AddSubjectToEmployee(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseEmployeeReturnOne()
        {
            int expected = 1;
            int actual = _employeeCrud.CloseEmployee(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
