using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;

namespace UnitTestLawHouse.UnitTestsControllers
{
    // Andriy
    [TestClass]
    public class SubjectHandlerUnitTest
    {
        // Navnet _sut  står for System Under Test
        [TestMethod]
        public void TestSubjectHandlerReturnSameInstance()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            SubjectHandler actual = new SubjectHandler();
            object.ReferenceEquals(_sut, actual);

        }

        [TestMethod]
        public void TestNewSubjectReturnOne()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            int expected = 1;
            int actual = _sut.NewSubject("Retssager", 30, 365, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnTwoSubjects()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            int expected = 2;
            int actual = _sut.GetSubjects().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnAListOfSubjects()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            var subjects = _sut.GetSubjects();
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnTwoSubjects()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            int expected = 2;
            int actual = _sut.GetEmployeeSubjectsById(1).Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnAListOfSubjects()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            var subjects = _sut.GetEmployeeSubjectsById(1);
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateSubjectReturnOne()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            int expected = 1;
            int actual = _sut.UpdateSubject(2, "Retssager/retshjælp", 20, 180, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteSubjectReturnOne()
        {
            SubjectHandler _sut = SubjectHandler.Instance;
            int expected = 1;
            int actual = _sut.DeleteSubject(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
