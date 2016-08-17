using Cosmetics.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests.Products
{
    [TestFixture]
    public class CategoryToPrintTest
    {
        //Category.Print() should return a string with the category details in the required format.
        [Test]
        public void CategoryToPrintMethodTest()
        {
            var category = new Category("asdf");

            // Act
            var executionResult = category.Print();

            // Assert
            Assert.AreEqual("asdf category - 0 products in total", executionResult);
        }
    }
}
