using System;

using NUnit.Framework;
using Cards.Logic;
using Cards.UI;

namespace UnitTestProject1
{
    [TestFixture]
    public class TestCards
    {
        [Test]
        public void TestIfEqualsWillThrowNull()
        {
            var testCard = new Card(CardSuit.Diamond, CardType.Ace);

            Assert.IsFalse(testCard.Equals(null));
        }

        [Test]
        public void TestIfCardsWillBeTheSame()
        {
            var testCard = new Card(CardSuit.Diamond, CardType.Jack);
            var testCard1 = new Card(CardSuit.Diamond, CardType.Jack);

            Assert.IsTrue(testCard.Equals(testCard1));
        }

       [TestCase(CardSuit.Diamond, CardType.Jack)]
        [TestCase(CardSuit.Heart, CardType.King)]
        [TestCase(CardSuit.Spade, CardType.Ten)]
        [TestCase(CardSuit.Club, CardType.Ace)]
        [TestCase(CardSuit.Diamond, CardType.Queen)]

        public void TestTheTestCase(CardSuit cardSuit, CardType cardType)
            {
            var card = new Card(cardSuit, cardType);
            Assert.IsFalse(card.Equals("asdf"));
            }
        [Test]
        public void AnotherTest()
        {
            var catchString = new Card(CardSuit.Club, CardType.Jack);

            StringAssert.Contains("J", catchString.ToString());

        }
    }
}
