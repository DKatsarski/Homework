using NUnit.Framework;
using School.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class StudentsTest
    {
        [Test]
        public void CheckIfStudentHasJoinedTheCourseSuccessfuly()
        {
            
            var chemistry = new Course();
            var testStudent = new Student("Adfsd", 12345);

            testStudent.JoinCourse(chemistry);

            Assert.Greater(chemistry.Students.Count, 0);
        }

        [Test]
        public void CheckIfStudentHasLeftTheCourseSuccessfuly()
        {
            var chemistry = new Course();
            var testStudent = new Student("Adfsd", 12345);

            testStudent.LeaveCourse(chemistry);
            Assert.AreEqual(0, chemistry.Students.Count);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckIfTheNameGivenIsNullTheValidationWillRun()
        {
            var name = string.Empty;
            var testStudents = new Student(name, 50005);
            testStudents.Name = string.Empty;
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfTheNumberGivenIsNullTheValidationWillRun()
        {
            var testStudent = new Student("Pesho", 1515);
            testStudent.Number = 123;
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CheckIfTheNameGivenIsNullTheValidationInConstructorWorks()
        {
            var name = string.Empty;
            var testStudents = new Student(name, 50005);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckIfTheNumberGivenIsNullTheValidationWillRunInConstructor()
        {
            var testStudent = new Student("Pesho", 1515);
        }
    }
}
