using Cosmetics.Engine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests.Engine
{
    [TestFixture]
    class EngineCommandTest
    {
        [Test]
        public void ParseMethod_ShouldReturnNewCommand_WhenTheInputIsInValidForm()
        {
            var testInput = "CreateShampoo";

            var testCommand = Command.Parse(testInput);

            Assert.IsInstanceOf<Command>(testCommand);
        }

        [Test]
        public void ParseMethod_ShouldSetCorrectValuesToNewlyReturnCommandObjectsProperties_NameAndParameters_WhenInputIsInTheValidForm()
        {
            var testInput = "Name params0 params1 params2";

            var testCommand = Command.Parse(testInput);


            Assert.IsTrue(
                testCommand.Name == "Name");
            Assert.IsTrue(
                testCommand.Parameters[0] == "params0");
            Assert.IsTrue(
                testCommand.Parameters[1] == "params1");
            Assert.IsTrue(
                testCommand.Parameters[2] == "params2");
        }

        [Test]
        public void ParseMethod_ShouldThrow_NullReferenceException_WhenInutIsNull()
        {
            string testInput = null;

            Assert.Throws<NullReferenceException>(() => Command.Parse(testInput));
        }


        [Test]
        public void ParseMethod_ShouldThrow_ArgumentNulLException_WhenInputFor_Name_IsNull()
        {
            string testInput = string.Empty;

            var testName = Assert.Throws<ArgumentNullException>(() => Command.Parse(testInput));

            StringAssert.Contains("Name", testName.Message);
        }

        public void ParseMethod_ShouldThrow_ArgumentNulLException_WhenInputFor_List_IsNull()
        {
            string testInput = "Name ";

            var testName = Assert.Throws<ArgumentNullException>(() => Command.Parse(testInput));

            StringAssert.Contains("List", testName.Message);
        }


    }
}
