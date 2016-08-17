using NUnit.Framework;
using School.Contracts;
using School.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.VerificatorTests
{
    [TestFixture]
    public class VerificatorTests
    {
        [Test]

        public void ChechTheNullOrEmptyValidation()
        {
            Assert.Throws<ArgumentNullException>(() => Validator.CheckIfItIsNullOrEmpty(string.Empty));
        }

        [TestCase(2)]
        [TestCase(1234567892)]

        public void ChechOutOfRangeValidation(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Validator.CheckIfItIsOutOfRange(num));
        }

        [Test]
        

        public void ChechTheCourseCapacityValidation()
        {
            var student = new Student("asd", 12345);
            var course = new Course();

            for (int i = 0; i < 30; i++)
            {
                student.JoinCourse(course);
            }

            student.JoinCourse(course);
            Assert.Throws<ArgumentOutOfRangeException>(() => Validator.CheckTheCourseCapacity(
                course.Students));
        }
    }
}
