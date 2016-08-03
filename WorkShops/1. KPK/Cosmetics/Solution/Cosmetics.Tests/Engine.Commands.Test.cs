using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Cosmetics.Common;
using Cosmetics.Engine;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class EngineCommandsTest
    {
        [Test]
        public void TestIfCommandParseReturnsNewCommandIfTheGivenParameterIsInTheCorrectFormat()
        {
            var tCommand = Command.Parse("asdf");
            Assert.IsInstanceOf(typeof(Command), tCommand);
        }

        [Test]
        public void TestIfNameIsExtractedCorrectly()
        {
            var tCommand = Command.Parse("Name");
            Assert.AreEqual("Name", tCommand.Name);
        }

        [Test]
        public void TestIfParamtersAreExctractedCorrectly()
        {
            var tCommand = Command.Parse("Name param1 param2");
            Assert.AreEqual(2, tCommand.Parameters.Count);
        }

  //      [Test]
		//[ExpectedException(typeof(ArgumentNullException), )]
  //      public void CheckIfCOmmandParseWillThrowArumengtNullException()
  //      {
           
  //      }

        [Test]
        public void CheckIfCOmmandParseWillThrowArumengtNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Command.Parse(""));
        }

        [Test]
        public void CheckIfCOmmandParseWill1ThrowArumengtNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => Command.Parse(""));
            Assert.Contains("Name", exception.Message.Split(' '));
        }


        [Test]
        public void CheckIfCOmmandParseWill2ThrowArumengtNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => Command.Parse("Name "));
            Assert.Contains("List", exception.Message.Split(' '));
        }
    }
}
