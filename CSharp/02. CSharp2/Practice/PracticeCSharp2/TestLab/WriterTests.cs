using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using School;
using Bazik;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab
{
    [TestClass]
    public class WriterTests
    {
        [TestMethod]
        public void ListOfTeachersShouldAddTeacher()
        {
            var teacher = new Mock<IListOfTeachers>();


            var list = new List<string>();

            for (int i = 0; i < 3; i++)
            {
                list.Add("ssd" + i.ToString());
            }
            
            teacher.Setup(x => x.Teachers).Returns(list);


            var notSure = teacher.Object;
            
            

            Assert.AreEqual(notSure.Teachers.Count(), 3);
            
            
        }

       
    }
}


