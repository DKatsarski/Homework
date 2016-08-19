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

        [TestCase ("create resourses bronze(40) silver(30) gold(20)")]
        [TestCase("create resourses silver(30) bronze(40) gold(20)")]
        [TestCase("create resourses gold(20) bronze(40) silver(30)")]
        [TestCase("create resourses bronze(40) silver(30) gold(20)")]

        public void GetResources_ShouldReturnNewlyCreatedResourcesObject_WithTheCorrespondingPorperties(string str)
        {
            var testFactory = new ResourcesFactory();

            
            var testResources = testFactory.GetResources(str);

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

        [TestCase("create resourses bronze(400000000000000) silver(30) gold(20)")]
        [TestCase("create resourses bronze(21) silver(3000000000000000) gold(20)")]
        [TestCase("create resourses bronze(21) silver(30) gold(2000000000000000000)")]
        public void GetResourcesShouldThrowOverFlowException_WhenStringIsTooBig(string str)
        {
            var testRFactory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => testRFactory.GetResources(str));
        }
    }


}
