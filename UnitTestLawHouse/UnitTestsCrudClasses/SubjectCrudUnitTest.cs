using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class SubjectCrudUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestSubjectCrudVedInitializationDbSubjectIsNotNull()
        {
            SubjectCrud _sut = new SubjectCrud();
            var o = _sut._dbSubject;
            Assert.IsNotNull(o);
        }
        [TestMethod]
        public void TestNewSubjectReturnOne()
        {
            SubjectCrud _sut = new SubjectCrud();
            int expected = 1;
            int actual = _sut.NewSubject("Retssager", 30, 365, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnTwoSubjects()
        {
            SubjectCrud _sut = new SubjectCrud();
            int expected = 2;
            int actual = _sut.GetSubjects().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnAListOfSubjects()
        {
            SubjectCrud _sut = new SubjectCrud();
            var subjects = _sut.GetSubjects();
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnTwoSubjects()
        {
            SubjectCrud _sut = new SubjectCrud();
            int expected = 2;
            int actual = _sut.GetEmployeeSubjectsById(1).Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnAListOfSubjects()
        {
            SubjectCrud _sut = new SubjectCrud();
            var subjects = _sut.GetEmployeeSubjectsById(1);
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateSubjectReturnOne()
        {
            SubjectCrud _sut = new SubjectCrud();
            int expected = 1;
            int actual = _sut.UpdateSubject(2, "Retssager/retshjælp", 20, 180, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteSubjectReturnOne()
        {
            SubjectCrud _sut = new SubjectCrud();
            int expected = 1;
            int actual = _sut.DeleteSubject(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
