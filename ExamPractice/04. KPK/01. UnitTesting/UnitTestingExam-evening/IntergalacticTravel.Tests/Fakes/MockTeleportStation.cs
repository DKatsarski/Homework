using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntergalacticTravel.Contracts;

namespace IntergalacticTravel.Tests.Fakes
{
    public class MockTeleportStation : TeleportStation
    {
        public MockTeleportStation(IBusinessOwner owner, IEnumerable<IPath> galacticMap, ILocation location) : base(owner, galacticMap, location)
        {
        }

      
    }
}
