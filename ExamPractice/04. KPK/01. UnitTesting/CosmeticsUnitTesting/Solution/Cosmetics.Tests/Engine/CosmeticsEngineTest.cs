using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Tests.Fakes;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests.Engine
{
    [TestFixture]
    public class CosmeticsEngineTest
    {
        [Test]
        /*
         - Start should read, parse and execute "CreateCategory" command, when the passed input string is in the format that represents a CreateCategory command, which should result in adding the new Category in the list of categories.
        */
        public void Start_Should_Read_Parse_AndExecute_CreateCategoryCommand_WhenThePassedStringIsInTheValidFormatRepresentingCreateCategoryCommand_WichShouldResultIn_AddingTheNewCategoryInThe_ListOfCategories()
        {
            //sthe trqbwa i category type
            var categoryName = "ForWomen";

            var mockedFactory = new Mock<ICosmeticsFactory>(); //TODO: IMplement?
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();

            mockedCommand.SetupGet(
                x => x.Name).Returns("CreateCategory");
            mockedCommand.SetupGet(
                x => x.Parameters).Returns(new List<string>() { categoryName });

            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(categoryName)).Returns(mockedCategory.Object);

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);

            mockedEngine.Start();

            Assert.IsTrue(mockedEngine.Categories.ContainsKey(categoryName));
            Assert.AreSame(mockedCategory.Object, mockedEngine.Categories[categoryName]);
        }

        /* 
         * Start should read, parse and execute "AddToCategory" command, when the passed input string is in the format that represents a AddToCategory command, which should result in adding the selected product in the respective category
        */
        [Test]
        public void Start_Should_Read_Parse_AndExecute_AddToCategory_WhenThePassedStringIsInTheValidFormatRepresentingCreateCategoryCommand_WichShouldResultIn_AddingTheNewCategoryInThe_ListOfCategories()
        {
            var categoryName = "ForWomen";
            var productName = "NotEasy";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();
            var mockedShampoo = new Mock<IShampoo>();

            mockedCommand.SetupGet(
                x => x.Name).Returns("AddToCategory");
            mockedCommand.SetupGet(
                x => x.Parameters).Returns(new List<string>() { categoryName, productName });

            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(categoryName)).Returns(mockedCategory.Object);

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Products.Add(productName, mockedShampoo.Object);

            mockedEngine.Start();

            mockedCategory.Verify(x => x.AddProduct(mockedShampoo.Object), Times.Once);

        }

        /* 
    * Start should read, parse and execute "RemoveFromCategory" command, when the passed input string is in the format that represents a RemoveFromCategory command, which should result in removing the selected product from the respective category.
   */
        [Test]
        public void Start_Should_Read_Parse_AndExecute_RemoveFromCategory_WhenThePassedStringIsInTheValidFormatRepresentingCreateCategoryCommand_WichShouldResultIn_AddingTheNewCategoryInThe_ListOfCategories()
        {
            var categoryName = "ForWomen";
            var productName = "NotEasy";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();
            var mockedShampoo = new Mock<IShampoo>();

            mockedCommand.SetupGet(
                x => x.Name).Returns("RemoveFromCategory");
            mockedCommand.SetupGet(
                x => x.Parameters).Returns(new List<string>() { categoryName, productName });

            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(categoryName)).Returns(mockedCategory.Object);

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Products.Add(productName, mockedShampoo.Object);

            mockedEngine.Start();

            mockedCategory.Verify(x => x.RemoveProduct(mockedShampoo.Object), Times.Once);

        }

        /* 
* Start should read, parse and execute "ShowCategory" command, when the passed input string is in the format that represents a ShowCategory command, which should result in calling the Print() method of the respective cateogry.
*/
        [Test]
        public void Start_Should_Read_Parse_AndExecute_ShowCategory_WhenThePassedStringIsInTheValidFormatRepresentingCreateCategoryCommand_WichShouldResultIn_AddingTheNewCategoryInThe_ListOfCategories()
        {
            var categoryName = "ForWomen";
            var productName = "NotEasy";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();
            var mockedShampoo = new Mock<IShampoo>();

            mockedCommand.SetupGet(
                x => x.Name).Returns("ShowCategory");
            mockedCommand.SetupGet(
                x => x.Parameters).Returns(new List<string>() { categoryName, productName });

            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedCategory.SetupGet(x => x.Name).Returns(categoryName);
            mockedFactory.Setup(x => x.CreateCategory(categoryName)).Returns(mockedCategory.Object);

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Products.Add(productName, mockedShampoo.Object);

            mockedEngine.Start();

            mockedCategory.Verify(x => x.Print(), Times.Once);

        }

        /* 
Start should read, parse and execute "CreateShampoo" command, when the passed input string is in the format that represents a CreateShampoo command, which should result in adding the newly created shampoo in the list of products.
*/
        [Test]
        public void Start_Should_Read_Parse_AndExecute_CreateShampoo_WhenThePassedStringIsInTheValidFormatRepresentingCreateCategoryCommand_WichShouldResultIn_AddingTheNewCategoryInThe_ListOfCategories()
        {
            var shampooName = "Cool";
            var shampooBrand = "Nivea";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedCategory = new Mock<ICategory>();
            var mockedShampoo = new Mock<IShampoo>();

            mockedCommand.SetupGet(
                x => x.Name).Returns("CreateShampoo");
            mockedCommand.SetupGet(
                x => x.Parameters).Returns(new List<string>() { shampooName, shampooBrand, "0.50", "men", "500", "everyday" });

            mockedCommandParser.Setup(x => x.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedCategory.SetupGet(x => x.Name).Returns(shampooName);

            mockedFactory
                       .Setup(x => x.CreateShampoo(shampooName, shampooBrand, 0.50M, GenderType.Men, 500, UsageType.EveryDay))
                       .Returns(mockedShampoo.Object);

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
      

            mockedEngine.Start();

            Assert.IsTrue(mockedEngine.Products.ContainsKey(shampooName));
            Assert.AreSame(mockedShampoo.Object, mockedEngine.Products[shampooName]);

        }

        //Start should read, parse and execute "CreateToothpaste" command, when the passed input string is in the format that represents a CreateToothpaste command, which should result in adding the newly created toothpaste in the list of products.
        [Test]
        public void Start_WhenInputStringIsValidCreateCreateToothpasteCommand_ToothpasteShouldBeAddedToProducts()
        {
            // Arrange
            var toothpasteName = "White+";
            var toothpasteBrand = "Colgate";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedCommand = new Mock<ICommand>();
            var mockedToothpaste = new Mock<IToothpaste>();

            mockedCommand.SetupGet(x => x.Name).Returns("CreateToothpaste");
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { toothpasteName, toothpasteBrand, "15.50", "men", "fluor,bqla,golqma" });
            mockedCommandParser.Setup(p => p.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedFactory
                .Setup(x => x.CreateToothpaste(toothpasteName, toothpasteBrand, 15.50M, GenderType.Men, new List<string>() { "fluor", "bqla", "golqma" }))
                .Returns(mockedToothpaste.Object);

            var engine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);

            // Act
            engine.Start();

            // Assert
            Assert.IsTrue(engine.Products.ContainsKey(toothpasteName));
            Assert.AreSame(mockedToothpaste.Object, engine.Products[toothpasteName]);
        }


        //Start should read, parse and execute "AddToShoppingCart" command, when the passed input string is in the format that represents a AddToShoppingCart command, which should result in adding the selected product to the shopping cart.
        [Test]
        public void Start_WhenInputStringIsValidAddToShoppingCartCommand_ProductShouldBeAddedToShoppingCart()
        {
            // Arrange
            var productName = "White+";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedProduct = new Mock<IProduct>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns("AddToShoppingCart");
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { productName });
            mockedCommandParser.Setup(p => p.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            var engine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            engine.Products.Add(productName, mockedProduct.Object);

            // Act
            engine.Start();

            // Assert
            mockedShoppingCart.Verify(x => x.AddProduct(mockedProduct.Object), Times.Once);
        }


        //Start should read, parse and execute "RemoveFromShoppingCart" command, when the passed input string is in the format that represents a RemoveFromShoppingCart command, which should result in removing the selected product from the shopping cart.
        [Test]
        public void Start_WhenInputStringIsValidRemoveFromShoppingCartCommand_ProductShouldBeRemovedFromShoppingCart()
        {
            // Arrange
            var productName = "White+";

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedShoppingCart = new Mock<IShoppingCart>();
            var mockedCommandParser = new Mock<ICommandParser>();

            var mockedProduct = new Mock<IProduct>();
            var mockedCommand = new Mock<ICommand>();

            mockedCommand.SetupGet(x => x.Name).Returns("RemoveFromShoppingCart");
            mockedCommand.SetupGet(x => x.Parameters).Returns(new List<string>() { productName });
            mockedCommandParser.Setup(p => p.ReadCommands()).Returns(() => new List<ICommand>() { mockedCommand.Object });

            mockedShoppingCart.Setup(x => x.ContainsProduct(mockedProduct.Object)).Returns(true);

            var engine = new MockedCosmeticsEngine(mockedFactory.Object, mockedShoppingCart.Object, mockedCommandParser.Object);
            engine.Products.Add(productName, mockedProduct.Object);

            // Act
            engine.Start();

            // Assert
            mockedShoppingCart.Verify(x => x.RemoveProduct(mockedProduct.Object), Times.Once);
        }


    }
}
