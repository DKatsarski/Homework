using ArmyOfCreatures.Logic.Battles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Tests.Fakes
{
    public class MockedBattleManager : BattleManager
    {
        private ICreaturesInBattle attacker;
        private ICreaturesInBattle deffender;

        public MockedBattleManager(
            ICreaturesInBattle attacker,
            ICreaturesInBattle deffender,
            ICreaturesFactory creaturesFactory, 
            ILogger logger) 
            : base(creaturesFactory, logger)
        {
            this.attacker = attacker;
            this.deffender = deffender;
        }

      


        protected override ICreaturesInBattle GetByIdentifier(
            CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 1)
            {
                return this.attacker;
            }
            else if (identifier.ArmyNumber == 2)
            {
                return this.deffender;
            }

            return null;
        }
    }
}
