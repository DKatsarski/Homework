using IntergalacticTravel.Contracts;
using IntergalacticTravel.Exceptions;
using IntergalacticTravel.Tests.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class TeleportStationTests
    {
        //Constructor should set up all of the provided fields (owner, galacticMap & location), when a new TeleportStation is created with valid parameters passed to the constructor.
        [Test]
        public void TestIfTheConstructorIsSettingUpTheCorrectParameters()
        {
            var fakeOwner = new Mock<IBusinessOwner>();
            var fakeGalacticMap = new Mock<IEnumerable<IPath>>();
            var fakeLocation = new Mock<ILocation>();
          //var fakeResources = new Mock<IResources>();

            var teleportStation = new TeleportStation(fakeOwner.Object, fakeGalacticMap.Object, fakeLocation.Object);

            var wrappedTS = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(teleportStation);

            var teleportStatoionOwner = wrappedTS.GetField("owner");
            var teleportStatoionMap = wrappedTS.GetField("galacticMap");
            var teleportStatoionLocation = wrappedTS.GetField("location");

            Assert.AreSame(fakeOwner.Object, teleportStatoionOwner);
            Assert.AreSame(fakeGalacticMap.Object, teleportStatoionMap);
            Assert.AreSame(fakeLocation.Object, teleportStatoionLocation);
        }

        //TeleportUnit should throw ArgumentNullException, with a message that contains the string "unitToTeleport", when IUnit unitToTeleport is null.
        [Test]
        public void TeleportUnit_ShouldTHrow_ArgumentNullException_whithMessageContaining_UnitTOTeleport()
        {
            var fakeOwner = new Mock<IBusinessOwner>();
            var fakeGalacticMap = new Mock<IEnumerable<IPath>>();
            var fakeLocation = new Mock<ILocation>();

            var fakeTargetLocation = new Mock<ILocation>();

            IUnit unit = null;
            
            var teleportStation = new TeleportStation(fakeOwner.Object, fakeGalacticMap.Object, fakeLocation.Object);

            var messageNull = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(unit, fakeTargetLocation.Object));

            StringAssert.Contains("unitToTeleport", messageNull.Message);
        }

        //TeleportUnit should throw ArgumentNullException, with a message that contains the string "destination", when ILocation destination is null.
        [Test]
        public void TeleportUnit_ShouldTHrow_ArgumentNullException_whithMessageContaining_destination_WhenLocationIsNull()
        {
            var fakeOwner = new Mock<IBusinessOwner>();
            var fakeGalacticMap = new Mock<IEnumerable<IPath>>();
            var fakeLocation = new Mock<ILocation>();

            var fakeUnit = new Mock<IUnit>();

            ILocation location = null;

            var teleportStation = new TeleportStation(fakeOwner.Object, fakeGalacticMap.Object, fakeLocation.Object);

            var messageNull = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(fakeUnit.Object, location));

            StringAssert.Contains("destination", messageNull.Message);
        }

        //TeleportUnit should throw TeleportOutOfRangeException, with a message that contains the string "unitToTeleport.CurrentLocation", when а unit is trying to use the TeleportStation from a distant location (another planet for example).
        [Test]
        public void TeleportUnit_ShouldTHrow_TeleportOutOfRange_whithMessageContaining_unitToTeleportCurrentLocationt()
        {
            var fakeOwner = new Mock<IBusinessOwner>();
            var fakeGalacticMap = new Mock<IEnumerable<IPath>>();

            var fakeTargetLocation = new Mock<ILocation>();
            var fakeUnit = new Mock<IUnit>();
            fakeUnit.Setup(x => x.CurrentLocation.Planet.Galaxy.Name).Returns("UAUA");

            fakeUnit.Setup(x => x.CurrentLocation.Planet.Name).Returns("FDFD");

            fakeTargetLocation.Setup(x => x.Planet.Name).Returns("AASD");
            fakeTargetLocation.Setup(x => x.Planet.Galaxy.Name).Returns("asdf");

            var teleportStation = new MockTeleportStation(
                fakeOwner.Object, fakeGalacticMap.Object, fakeTargetLocation.Object);

            var messageNull = Assert.Throws<TeleportOutOfRangeException>(
                () => teleportStation.TeleportUnit(fakeUnit.Object, fakeTargetLocation.Object));

            StringAssert.Contains("unitToTeleport.CurrentLocation", messageNull.Message);
        }

    }
}
