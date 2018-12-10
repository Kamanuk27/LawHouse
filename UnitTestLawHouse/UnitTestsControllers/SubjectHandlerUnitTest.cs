using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;

namespace UnitTestLawHouse.UnitTestsControllers
{
    [TestClass]
    public class SubjectHandlerUnitTest
    {
        private SubjectHandler _subjectHandler = SubjectHandler.Instance;

        [TestMethod]
        public void TestSubjectHandlerReturnSameInstance()
        {
            SubjectHandler actual = new SubjectHandler();
            object.ReferenceEquals(_subjectHandler, actual);

        }

        [TestMethod]
        public void TestNewSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectHandler.NewSubject("Retssager", 30, 365, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnTwoSubjects()
        {
            int expected = 2;
            int actual = _subjectHandler.GetSubjects().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnAListOfSubjects()
        {
            var subjects = _subjectHandler.GetSubjects();
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnTwoSubjects()
        {
            int expected = 2;
            int actual = _subjectHandler.GetEmployeeSubjectsById(1).Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnAListOfSubjects()
        {
            var subjects = _subjectHandler.GetEmployeeSubjectsById(1);
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectHandler.UpdateSubject(2, "Retssager/retshjælp", 20, 180, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectHandler.DeleteSubject(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
