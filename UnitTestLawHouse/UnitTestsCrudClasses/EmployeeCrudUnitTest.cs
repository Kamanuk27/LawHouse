using System;
using BusinessLogic;
using LawHouseLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    // Andriy
    [TestClass]
    public class EmployeeCrudUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestEmployeeCrudVedInitializationDbEmployeeIsNotNull()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            var o = _sut._dbEmployee;
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void TestNewEmployeeReturnOne()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            int expected = 1;
            int actual = _sut.NewEmployee("1234567890", "Karin", "Olsen", "Florasvej 1", 
                                                     6000, "Karin@gmail.com", "22222222",
                                                     DateTime.Now, "Advokat", 750);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeesReturnTwoEmployees()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            var employees = _sut.GetEmployees();
            Assert.AreEqual(2, employees.Count);
        }

        [TestMethod]
        public void TestGetEmployeesReturnListOfEmployees()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            var employees = _sut.GetEmployees();
            Type actual = employees[0].GetType();
            Type expected = typeof(EmployeeM);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateEmployeeReturnOne()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            int expected = 1;
            int actual = _sut.UpdateEmployee(2, "Karine", "Olsen", "Florasvej 1",
                                                     6000, "Karin@gmail.com", "22222222",
                                                     "Advokat", 1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAddSubjectToEmployeeReturnOne()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            int expected = 1;
            int actual = _sut.AddSubjectToEmployee(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCloseEmployeeReturnOne()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            int expected = 1;
            int actual = _sut.CloseEmployee(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DeleteSubjectFromEmployeeReturnOne()
        {
            EmployeeCrud _sut = new EmployeeCrud();
            int expected = 1;
            int actual = _sut.DeleteSubjectFromEmployee(1, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
