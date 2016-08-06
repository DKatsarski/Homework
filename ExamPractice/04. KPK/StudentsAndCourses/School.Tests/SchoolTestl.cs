using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class SchoolTest
    {
        [Test]
        public void CheckTheAddMethodInSchool()
        {
            var testSchool = new School();
            Student testStudent = new Student("GOsho", 12354);

            testSchool.AdmitStudent(testStudent);

            Assert.AreEqual(1, testSchool.Students.Count);
        }
    }
}
