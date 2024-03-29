﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Contracts;
using UnitTesting.Models.Base;

namespace School.Test.Models
{
    [TestClass]
    public class BaseNameableObjectTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), AllowDerivedTypes = false)]
        public void NameSetter_shouldThrow_ifPassedValueIsANullString()
        {
            string testNameValue = null;

            INameable testBaseObject = new BaseNameableObject(testNameValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), AllowDerivedTypes = false)]
        public void NameSetter_shouldThrow_ifPassedValueIsAnEmptyString()
        {
            string testNameValue = string.Empty;

            INameable testBaseObject = new BaseNameableObject(testNameValue);
        }

        [TestMethod]
        public void NameSetter_objectNamePropertyShouldBeTheSameAsInput_ifThePassedStringIsNotNullOrEmpty()
        {
            string expectedNameValue = "course name";

            INameable testBaseObject = new BaseNameableObject(expectedNameValue);

            var actualNameValue = testBaseObject.Name;

            Assert.AreEqual(expectedNameValue, actualNameValue);
        }
    }

}
