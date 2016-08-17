using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Engine;
using Cosmetics.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests.Engine
{
    [TestFixture]
    public class EngineCosmeticsFactoryTests
    {
        //CreateShampoo should throw NullReferenceException, when the passed "name" parameter is invalid. (Null or Empty)
        [TestCase("")]
        [TestCase(null)]
        public void CreateShampoo_ShouldThrow_NullReferenceException_WhenThe_Name_PassedParameterIsInvalid(string str)
        {
            //Arrange
            CosmeticsFactory testShampoo = new CosmeticsFactory();

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => testShampoo.CreateShampoo(str, "Shauma", 12, GenderType.Men, 23, UsageType.EveryDay));
        }

        // CreateShampoo should throw IndexOutOfRangeException, when the passed "name" parameter is invalid. (length out of range)
        [TestCase("1")]
        [TestCase("12")]
        [TestCase("1234567891011")]
        public void CreateShampoo_ShouldThrow_IndexOutOfRangeException_WhenThe_Name_PassedParameterIsInvalid(string str)
        {
            //Arrange
            CosmeticsFactory testShampoo = new CosmeticsFactory();

            //Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => testShampoo.CreateShampoo(str, "Shauma", 12, GenderType.Men, 23, UsageType.EveryDay));
        }

        //CreateShampoo should throw NullReferenceException, when the passed "brand" parameter is invalid. (Null or Empty)
        [TestCase("")]
        [TestCase(null)]


        public void CreateShampoo_ShouldThrow_NullReferenceException_WhenThe_Brand_PassedParameterIsInvalid(string str)
        {
            //Arrange
            CosmeticsFactory testShampoo = new CosmeticsFactory();

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => testShampoo.CreateShampoo("Shauma", str, 12, GenderType.Men, 23, UsageType.EveryDay));
        }

        //CreateShampoo should throw IndexOutOfRangeException, when the passed "brand" parameter is invalid. (length out of range)
        [TestCase("1")]
        [TestCase("111111111111111111111")]
        public void CreateShampoo_ShouldThrow_IndexOutOfRangeException_WhenThe_Brand_PassedParameterIsInvalid(string str)
        {
            //Arrange
            CosmeticsFactory testShampoo = new CosmeticsFactory();

            //Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => testShampoo.CreateShampoo("Shauma", str, 12, GenderType.Men, 23, UsageType.EveryDay));
        }

        //CreateShampoo should return a new Shampoo, when the passed parameters are all valid.
        [Test]
        public void CreateSHampoo_ShouldCreate_NewSHampoo_IfEverythingIsOK()
        {

            //Arrange
            CosmeticsFactory testShampoo = new CosmeticsFactory();
            var asdf = testShampoo.CreateShampoo("Shauma", "SDf", 12, GenderType.Men, 23, UsageType.EveryDay);

            //Act & Assert
            Assert.IsInstanceOf<Shampoo>(asdf);
        }

        //CreateCategory should throw NullReferenceException, when the passed "name" parameter is invalid. (Null or Empty)
        [TestCase("")]
        [TestCase(null)]

        public void TestCategoryName(string str)
        {
            CosmeticsFactory testCategory = new CosmeticsFactory();

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => testCategory.CreateCategory(str));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateCategory_WhenNameParamIsNullOrEmpty_ShouldThrowNullReferenceException(string nameParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateCategory(nameParam));
        }

        [Test]
        public void CreateCategory_WhenNameParamIsValid_ShouldReturnInstanceOfCategory()
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act
            var executionResult = cosmeticFactory.CreateCategory("Pesho");

            // Assert
            Assert.IsInstanceOf<ICategory>(executionResult);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenNameParamIsNullOrEmpty_ShouldThrowNullReferenceException(string nameParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateToothpaste(nameParam, "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("as")]
        [TestCase("20CharactersLongText")]
        public void CreateToothpaste_WhenNameParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string nameParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste(nameParam, "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenBrandParamIsNullOrEmpty_ShouldThrowNullReferenceException(string brandParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateToothpaste("Gosho", brandParam, 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("a")]
        [TestCase("20CharactersLongText")]
        public void CreateToothpaste_WhenBrandParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string brandParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste("Gosho", brandParam, 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [Test]
        public void CreateToothpaste_WhenNameParamIsValid_ShouldReturnInstanceOfToothpaste()
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act
            var executionResult = cosmeticFactory.CreateToothpaste("Gosho", "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" });

            // Assert
            Assert.IsInstanceOf<IToothpaste>(executionResult);
        }

        [TestCase("Luk", "Chesun")]
        [TestCase("ZelenchukovaSupa", "Chesun")]
        [TestCase("Chesun", "Luk")]
        [TestCase("Chesun", "ZelenchukovaSupa")]
        public void CreateToothpaste_WhenIngredientsHaveInvalidLenght_ShouldThrowIndexOutOfRangeException(params string[] ingredients)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste("Gosho", "example", 10M, GenderType.Unisex, ingredients.ToList()));
        }

        [Test]
        public void CreateShoppingCart_WhenInvoked_ShouldReturnInstanceOfShoppingCart()
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act
            var executionResult = cosmeticFactory.CreateShoppingCart();

            // Assert
            Assert.IsInstanceOf<IShoppingCart>(executionResult);
        }
    }
}
