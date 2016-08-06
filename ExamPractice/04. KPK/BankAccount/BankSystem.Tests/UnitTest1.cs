using System;
using NUnit.Framework;

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
            var mockedLogger = new IsLogMethodCalledLogger();
            var bankAccount = new BankAccount(mockedLogger);
            bankAccount.Deposit(1000);
            Assert.IsTrue(mockedLogger.LogIsCalled);
        }
    }

    public class IsLogMethodCalledLogger : ILogger
    {
        public bool LogIsCalled { get; private set; }
        public void Log(string message)
        {
            this.LogIsCalled = true;
        }
    }
}
