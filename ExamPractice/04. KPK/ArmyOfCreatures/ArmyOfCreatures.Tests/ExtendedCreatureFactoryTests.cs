using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Extended.Creatures;
using ArmyOfCreatures.Logic.Creatures;
using NUnit.Framework;
using System;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class ExtendedCreatureFactoryTests
    {
        [TestCase("AncientBehemoth")]
        [TestCase("CyclopsKing")]
        [TestCase("Goblin")]
        [TestCase("Griffin")]
        [TestCase("WolfRaider")]
        [TestCase("Angel")]
        [TestCase("Archangel")]
        [TestCase("ArchDevil")]
        [TestCase("Behemoth")]
        [TestCase("Devil")]
                                                                
        public void TheMethodCreateCreatureShouldReturnTheCorrespondingCreatureWhenStringIsvalid(string str)
        {
            var testCreature = new ExtendedCreaturesFactory();

            var theCreature = testCreature.CreateCreature(str);
            var theCreatureType = theCreature.GetType();

            Assert.AreSame(theCreature.GetType(), theCreatureType);
        }

        [Test]
        public void TestIfExtendedCreatureFactoryThrowsExceptionIfTheGivenStringIsInvalid()
        {
            var testCreatre = new ExtendedCreaturesFactory();
            var wrongString = "asdfasdf";

            var testException = Assert.Throws<ArgumentException>(() => testCreatre.CreateCreature(wrongString));

            StringAssert.Contains("Invalid", testException.Message);
        }


    }
}
