using Cosmetics.Contracts;
using Cosmetics.Products;
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
    public class ShoppingCartTests
    {
        //AddProduct should add the passed product to the products list.
        //[Test]
        //public void se()
        //{
        //    var product = new Mock<IProduct>();

        //    ShoppingCart sc = new ShoppingCart();    EDIN NACHIN - PYRWIQ, KOJTO MI DOJDE


        //    sc.AddProduct(product.Object);

        //    Assert.IsTrue(sc.ContainsProduct(product.Object));
        //}

        [Test]
        public void AddProduct_WhenProductParamIsValid_ShouldAddProductToList()
        {
            // Arrange
            var mockedProduct = new Mock<IProduct>();
            var shoppingCart = new MockedShoppingCart();

            // Act
            shoppingCart.AddProduct(mockedProduct.Object);

            // Assert
            //Assert.AreEqual(true, shoppingCart.Products.Contains(mockedProduct.Object));   // IDWATA MISLQ, CHE STAWAT
            Assert.AreEqual(1, shoppingCart.Products.Count);
        }

        //RemoveProduct should remove the passed product from the products list.
        [Test]
        public void RemoveProduct_WhenProductParamIsValid_ShouldRemoveProductFromList()
        {
            // Arrange
            var mockedProduct = new Mock<IProduct>();
            var shoppingCart = new MockedShoppingCart();
            shoppingCart.Products.Add(mockedProduct.Object);

            // Act
            shoppingCart.RemoveProduct(mockedProduct.Object);

            // Assert
            Assert.AreEqual(false, shoppingCart.Products.Contains(mockedProduct.Object));
        }

        //ContainsProduct should return true if the passed product is contained within the products list.
        [Test]
        public void ContainsProduct_WhenProductParamIsValid_ShouldReturnTrue()
        {
            // Arrange
            var mockedProduct = new Mock<IProduct>();
            var shoppingCart = new MockedShoppingCart();
            shoppingCart.Products.Add(mockedProduct.Object);

            // Act
            var testIfTrue = shoppingCart.ContainsProduct(mockedProduct.Object);

            // Assert
            Assert.IsTrue(testIfTrue);
        }

        //TotalPrice should return the total sum of the prices of all products in the products list. (or 0 if there are no products)
        [Test]
        public void TotalPrice_WhenThereAreNoProductsInList_ShouldReturnZero()
        {
            // Arrange
            var shoppingCart = new MockedShoppingCart();

            // Act
            var executionResult = shoppingCart.TotalPrice();

            // Assert
            Assert.AreEqual(0M, executionResult);
        }
    }
}
