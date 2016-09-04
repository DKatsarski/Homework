using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControlFlowAndStuff.Task_2;
using ControlFlowAndStuff;

namespace TestTask2
{
    [TestClass]
    public class TestTask2
    {
        [TestMethod]
        public void RefactorIfStatementTest()
        {
            RefactorIfStatement test = new RefactorIfStatement();
            Potato testPotato = new Potato();

            Assert.IsTrue(test.Cook(testPotato));
        }
    }
}
