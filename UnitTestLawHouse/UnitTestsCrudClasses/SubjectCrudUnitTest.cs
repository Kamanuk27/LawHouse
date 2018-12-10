using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using LawHouseLibrary.Models;

namespace UnitTestLawHouse.UnitTestsCrudClasses
{
    [TestClass]
    public class SubjectCrudUnitTest
    {
        private SubjectCrud _subjectCrud = new SubjectCrud();

        [TestMethod]
        public void TestSubjectCrudVedInitializationDbSubjectIsNotNull()
        {
            var o = _subjectCrud._dbSubject;
            Assert.IsNotNull(o);
        }
        [TestMethod]
        public void TestNewSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectCrud.NewSubject("Retssager", 30, 365, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnTwoSubjects()
        {
            int expected = 2;
            int actual = _subjectCrud.GetSubjects().Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSubjectsReturnAListOfSubjects()
        {
            var subjects = _subjectCrud.GetSubjects();
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnTwoSubjects()
        {
            int expected = 2;
            int actual = _subjectCrud.GetEmployeeSubjectsById(1).Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetEmployeeSubjectsByIdReturnAListOfSubjects()
        {
            var subjects = _subjectCrud.GetEmployeeSubjectsById(1);
            Type expected = typeof(SubjectM);
            Type actual = subjects[0].GetType();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUpdateSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectCrud.UpdateSubject(2, "Retssager/retshjælp", 20, 180, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDeleteSubjectReturnOne()
        {
            int expected = 1;
            int actual = _subjectCrud.DeleteSubject(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
