using IntergalacticTravel.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntergalacticTravel.Tests
{
    [TestFixture]
    public class UnitsFactoryTests
    {
        //GetUnit should return new Procyon unit, when a valid corresponding command is passed (i.e. "create unit Procyon Gosho 1");
        [Test]
        public void TestIf_GetUnit_WillReturn_NewProcyon_IfCommandIsIn_ValidFormat()
        {
            //Arrange
            var testUnit = new UnitsFactory();

            //Act & Assert
            Assert.IsInstanceOf<Procyon>(testUnit.GetUnit("create unit Procyon Gosho 1"));
        }

        //GetUnit should return new Luyten unit, when a valid corresponding command is passed (i.e. "create unit Luyten Pesho 2");
        [Test]
        public void TestIf_GetUnit_WillReturn_NewLuyten_IfCommandIsIn_ValidFormat()
        {
            //Arrange
            var testUnit = new UnitsFactory();

            //Act & Assert
            Assert.IsInstanceOf<Luyten>(testUnit.GetUnit("create unit Luyten Gosho 1"));
        }

        //GetUnit should return new Lacaille unit, when a valid corresponding command is passed (i.e. "create unit Lacaille Tosho 3");
        [Test]
        public void TestIf_GetUnit_WillReturn_NewLacaille_IfCommandIsIn_ValidFormat()
        {
            //Arrange
            var testUnit = new UnitsFactory();

            //Act & Assert
            Assert.IsInstanceOf<Lacaille>(testUnit.GetUnit("create unit Lacaille Gosho 1"));
        }


        //GetUnit should throw InvalidUnitCreationCommandException, when the command passed is not in the valid format described above. (Check for at least 2 different cases)
        [TestCase("create unit Pesho Gosho 1")]
        [TestCase("")]
        [TestCase("create")]
        [TestCase("create unit Pesho Gosho 1 sdf  Ad di tio nal words")]
        [TestCase("create unit Pesho Gosho STRING")]
        [TestCase("create nit Pesho Gosho 1")]
        [TestCase(null)]
        public void TestIf_GetUnit_WillTrowAn_InvalidUnitCreatoinCommandException_WhenCommandPassedIs_Not_InValidFormat(string str)
        {
            //Assert
            var testUnit = new UnitsFactory();

            //Act & Assert
            Assert.Throws<InvalidUnitCreationCommandException>(() => testUnit.GetUnit(str));

        }
    }
}
