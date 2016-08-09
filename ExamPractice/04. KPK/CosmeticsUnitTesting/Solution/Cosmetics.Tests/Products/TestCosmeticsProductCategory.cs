using Cosmetics.Contracts;
using Cosmetics.Products.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests.Products
{
    [TestFixture]
    public class TestCosmeticsProductCategory
    {
        //AddCosmetics should add the passed cosmetic to the products list.
        [Test]
        public void AddProduct_ShouldAddProductInProductList()
        {
            var name = "Name";
            var fakeProduct = new Mock<IProduct>();

            var fakeCategory = new MockedCategory(name);
            fakeCategory.AddProduct(fakeProduct.Object);

            Assert.AreEqual(1, fakeCategory.Products.Count);
            Assert.IsTrue(fakeCategory.Products.Contains(fakeProduct.Object));
        }

        //AddCosmetics should add the passed cosmetic to the products list.
        [Test]
        public void RemoveProduct_ShouldRemoveProductInProductList()
        {
            var name = "Name";
            var fakeProduct = new Mock<IProduct>();

            var fakeCategory = new MockedCategory(name);
            fakeCategory.AddProduct(fakeProduct.Object);
            fakeCategory.RemoveProduct(fakeProduct.Object);


            Assert.AreEqual(0, fakeCategory.Products.Count);
            Assert.IsFalse(fakeCategory.Products.Contains(fakeProduct.Object));
        }


    }
}
