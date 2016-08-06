using System;
using NUnit.Framework;
using Moq;

namespace BankSystem.Logic.Tests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void ConstructorShoulstSetMoneyToZero()
        {
            var bankAccount = new BankAccount();
            Assert.AreEqual(0, bankAccount.Money);
        }

        [Test]
        public void DepostiShouldAddToMoney()
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(1333);
            Assert.AreEqual(1333, bankAccount.Money);
        }

        [Test]
        public void WithdrawShouldAddToMoney()
        {
            var bankAccount = new BankAccount();
            bankAccount.Deposit(1333);
            bankAccount.Withdraw(1333);
            Assert.AreEqual(0, bankAccount.Money);
        }

        [Test]
        public void DepostiShouldLogTransaction()
        {
            var mockedLogger = new Mock<ILogger>();
            var bankAccount = new BankAccount(mockedLogger.Object);
            bankAccount.Deposit(1000);
            mockedLogger.Verify(
                x => x.Log(It.IsNotNull<string>()), Times.Once());

        }

        [Test]
        public void DepostiShouldthrowException()
        {
            var loggerMock = new Mock<ILogger>();
            loggerMock.Setup(
                x => x.Log(It.IsAny<string>()))
                .Throws(new ArgumentException()); // tuk moje da go nakarame, ako wryshta stojnost, da wyrne syotwetnata stojnost. ili sys Callback neshto i tn. i t.n,
        }

        [Test]
        public void AnotherMockTestWithCallBackThisTime()
        {
            var message = string.Empty;
            var loggerMock = new Mock<ILogger>();
            loggerMock.Setup(
                x => x.Log(It.IsAny<string>()))
                .Callback<string>(x => message = x);
            var bankAccount = new BankAccount(loggerMock.Object);
            bankAccount.Deposit(234);
            Console.WriteLine(message);
        }

        //public class IsLogMethodCalledLogger : ILogger
        //{
        //    public bool LogIsCalled { get; private set; }
        //    public void Log(string message)
        //    {
        //        this.LogIsCalled = true;
        //    }
        //}
    }
}
