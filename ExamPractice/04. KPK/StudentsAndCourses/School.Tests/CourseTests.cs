using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckTheCourseCapacityInProperteis()
        {
            var testCourse = new Course();
            var testStudent = new Student("Petko", 12345);
            for (int i = 0; i < 35; i++)
            {
                testCourse.AddStudent(testStudent);
            }
         
        }

        [Test]
        public void CheckTheRemoveMethod()
        {
            var testStudent = new Student("Petko", 12345);
            var testCourse = new Course();
            testCourse.AddStudent(testStudent);
            testCourse.RemoveStudent(testStudent);
            Assert.AreEqual(0, testCourse.Students.Count);
        }
    }
}
