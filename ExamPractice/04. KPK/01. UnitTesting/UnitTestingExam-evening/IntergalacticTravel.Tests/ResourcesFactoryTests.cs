using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class ResourcesFactoryTests
    {
        //GetResources should return a newly created Resources object with correctly set up properties(Gold, Bronze and Silver coins), no matter what the order of the parameters is, when the input string is in the correct format. (Check with all possible cases):

        [Test]
        public void GetResources_ShouldReturnNewlyCreatedResourcesObject_WithTheCorrespondingPorperties()
        {
            var testFactory = new ResourcesFactory();

            
            var testResources = testFactory.GetResources("sdf sdf bronze(40) silver(30) gold(20) sdf sdf");

            var amount = (uint)20;

            Assert.AreEqual(amount, testResources.GoldCoins);


        }

        //GetResources should throw InvalidOperationException, which contains the string "command", when the input string represents an invalid command. (Check with at least 2 different cases).

        [TestCase("sdf sdf bronze(40) silver(30) gold(20) sdf sdf")]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("bronze(40) silver(30) gold(20)")]
        public void GetResources_ShouldReturnInvalidOperationException_WhenCommandIsInvalid(string str)
        {
            var testFactory = new ResourcesFactory();

            Assert.Throws<InvalidOperationException>(() => testFactory.GetResources(str));
        }

        //GetResources should throw OverflowException, when the input string command is in the correct format, but any of the values that represent the resource amount is larger than uint.MaxValue. (Check with at least 2 different cases)

        [Test]
        public void asdf()
        {
            //DIDNT FIGURED OUT WHAT THE CORRECT COMMAND IS.
            //TODO: Figure it out!
        }
    }


}
