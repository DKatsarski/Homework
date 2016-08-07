using System;
using NUnit.Framework;
using Cosmetics.Common;
using Cosmetics.Products;

namespace Cosmetics.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfTheMethod_CheckIfNull_InTheValidator_WillThrow_NullReferenceExeption()
        {
        
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(null));
        }

        [Test]
        public void CheckIfTheMethod_CheckIfNull_InTheValidator_WillNOTThrow_NullReferenceExeption()
        {
            var shampoo = new Shampoo("Bochko", "Bochko AD", 0, GenderType.Men, 150, UsageType.EveryDay);

            Assert.DoesNotThrow(() => Validator.CheckIfNull(shampoo));
        }

        [Test]
        public void CheckIfTheMethod_CheckIfStringIsNullOrEmpty_InTheValidator_WillThrow_NullReferenceExeption_IfTheParameterTextIsNull()
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty("", "For your hair"));
        }

        [Test]
        public void CheckIfTheMethod_CheckIfStringIsNullOrEmpty_InTheValidator_WillNOTThrow_NullReferenceExeption_IfTheParameterTextIsNull()
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty("HeadAndSholders", "For your hair"));
        }

        [TestCase("a")]
        [TestCase("asdf asdf asdf asdf asdf d")]
        public void CheckIfTheValidatorForLenghtThrowsIndexOutOfRangeExceptionWhenNeeded(string str)
        {
           Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(str, 8, 3, "opa"));
        }

        [Test]
        public void CheckIfTheValidatorForLenghtDoesNOTThrowIndexOutOfRangeExceptionWhenNeeded()
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid("Shaoma", 8, 3, "product"));
        }
    }
}
