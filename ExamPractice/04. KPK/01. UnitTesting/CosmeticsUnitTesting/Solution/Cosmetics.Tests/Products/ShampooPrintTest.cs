using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using Cosmetics.Products;
using Cosmetics.Common;

namespace Cosmetics.Tests.Products
{
    /// <summary>
    /// Summary description for ShampooPrintTest
    /// </summary>
    [TestFixture]
    public class ShampooPrintTest
    {
        //Shampoo.Print() should return a string with the shampoo details in the required format.
        [Test]
        public void TestPrintMethodShampoo()
        {
            //Arrange
            Shampoo shamp = new Shampoo("sdf", "Garnier", 23, GenderType.Men, 23, UsageType.EveryDay);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0} - {1}:", shamp.Brand, shamp.Name));
            sb.AppendLine(string.Format("  * Price: ${0}", shamp.Price));
            sb.AppendLine(string.Format("  * For gender: {0}", shamp.Gender));
            sb.AppendLine(string.Format("  * Quantity: {0} ml", shamp.Milliliters));
            sb.Append(string.Format("  * Usage: {0}", shamp.Usage));

            //Act
            Assert.AreEqual(sb.ToString(), shamp.Print());

        }
    }
}
