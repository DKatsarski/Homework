using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Utils;
using System.Collections.Generic;

namespace School.Test.Utils
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_shouldReturnTrue_ifPassedAnEmptyString()
        {
            var testInputEmptyString = string.Empty;

            var actual = Validator.CheckIfStringIsNullOrEmpty(testInputEmptyString);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_shouldReturnTrue_ifPassedNullValue()
        {
            string testInputNullString = null;

            var actual = Validator.CheckIfStringIsNullOrEmpty(testInputNullString);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfStringIsNullOrEmpty_shouldReturnFalse_ifPassedNotNullOrEmptyString()
        {
            var testInputStudentNameString = "student name";

            var actual = Validator.CheckIfStringIsNullOrEmpty(testInputStudentNameString);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfNumberIsInRange_shouldReturnFalse_ifNumberIsBelowMinimumValue()
        {
            var minimumRangeValue = 1;
            var maximumRangeValue = 100;
            var testInputValue = 0;

            var actual = Validator.CheckIfNumberIsInRange(testInputValue, minimumRangeValue, maximumRangeValue);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfNumberIsInRange_shouldReturnFalse_ifNumberIsAboveMaximumValue()
        {
            var minimumRangeValue = 1;
            var maximumRangeValue = 100;
            var testInputValue = 999999;

            var actual = Validator.CheckIfNumberIsInRange(testInputValue, minimumRangeValue, maximumRangeValue);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckIfNumberIsInRange_shouldReturnTrue_ifPassedANumberWithinTheGivenRange()
        {
            var minimumRangeValue = 1;
            var maximumRangeValue = 100;
            var testInputValue = 10;

            var actualOutput = Validator.CheckIfNumberIsInRange(testInputValue, minimumRangeValue, maximumRangeValue);

            Assert.IsTrue(actualOutput);
        }

        [TestMethod]
        public void CheckIfNumberIsInRange_shouldReturnTrue_ifPassedANumberIsEqualToMinimumValue()
        {
            var minimumRangeValue = 1;
            var maximumRangeValue = 100;
            var testInputValue = minimumRangeValue;

            var actualOutput = Validator.CheckIfNumberIsInRange(testInputValue, minimumRangeValue, maximumRangeValue);

            Assert.IsTrue(actualOutput);
        }

        [TestMethod]
        public void CheckIfNumberIsInRange_shouldReturnTrue_ifPassedANumberIsEqualToMaximumValue()
        {
            var minimumRangeValue = 1;
            var maximumRangeValue = 100;
            var testInputValue = maximumRangeValue;

            var actualOutput = Validator.CheckIfNumberIsInRange(testInputValue, minimumRangeValue, maximumRangeValue);

            Assert.IsTrue(actualOutput);
        }

        [TestMethod]
        public void CheckIfObjectIsNull_shouldReturnTrue_ifPassedParameterIsNull()
        {
            object testInput = null;

            var actualResult = Validator.CheckIfObjectIsNull(testInput);

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void CheckIfObjectIsNull_shouldReturnFalse_ifPassedParameterIsNotNull()
        {
            var testInput = new List<string>() { "test" };

            var actualResult = Validator.CheckIfObjectIsNull(testInput);

            Assert.IsFalse(actualResult);
        }
    }
}
