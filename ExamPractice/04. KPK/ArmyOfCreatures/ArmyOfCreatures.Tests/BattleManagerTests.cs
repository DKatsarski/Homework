using System;
using NUnit.Framework;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Tests.Fakes;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class BattleManagerTests
    {
        [Test]
        public void TestIfTheConstructorIsReachingTheFieldsOfTheClass()
        {
            var fakeFacotyr = new Mock<ICreaturesFactory>();
            var fakeLogger = new Mock<ILogger>();
            var testBM = new BattleManager(
                fakeFacotyr.Object, fakeLogger.Object);
            var wrappedBM = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(testBM);

            var battleManagerCreatureFacotyr = 
                wrappedBM.GetField("creaturesFactory");
            var battleManagerLogger =
                wrappedBM.GetField("logger");

            Assert.AreSame(fakeFacotyr.Object, battleManagerCreatureFacotyr);
            Assert.AreSame(fakeLogger.Object, battleManagerLogger); ;
        }

        [Test]
        public void TestIf_AddCreature_WillThrowNullException_IfNullIsBeingGiven()
        {
            var fakeFactory = new Mock<ICreaturesFactory>();
            var fakeLogger = new Mock<ILogger>();
            var justSomeInt = 3;

            var testBattleManager = new BattleManager(
                fakeFactory.Object, fakeLogger.Object);

            Assert.Throws<ArgumentNullException>(() => testBattleManager.AddCreatures(null, justSomeInt));
        }

        [Test]
        public void Atttack_ShouldMakeAttackingAndDeffendingCreature_CallStartNewTurnMethodExcatlyOnceForeachCreature()
        {
            var fakeFactory = new Mock<ICreaturesFactory>();
            var fakeLogger = new Mock<ILogger>();
            var fakeAttacker = new Mock<ICreaturesInBattle>();
            fakeAttacker.Setup(x => x.Creature).Returns(new Angel());

            var fakeDefender = new Mock<ICreaturesInBattle>();
            fakeDefender.Setup(x => x.Creature).Returns(new ArchDevil());

            var testBattleManager = new MockedBattleManager(fakeAttacker.Object, fakeDefender.Object, fakeFactory.Object, fakeLogger.Object);

            var attackerIdentifier = CreatureIdentifier.CreatureIdentifierFromString("asd(1)");

            var deffenderIdentifier = CreatureIdentifier.CreatureIdentifierFromString("fds(2)");

            testBattleManager.Attack(attackerIdentifier, deffenderIdentifier);

            fakeAttacker.Verify(x => x.StartNewTurn(), Times.Once());
            fakeDefender.Verify(x => x.StartNewTurn(), Times.Once());


        }
    }
}
