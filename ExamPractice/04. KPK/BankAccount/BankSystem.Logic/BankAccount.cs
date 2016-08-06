using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Logic
{
    public class BankAccount
    {
        private ILogger logger;

        public BankAccount()
        {
            this.logger = new FileLogger();
        }

        public BankAccount(ILogger logger)
        {
            this.logger = logger;
        }
        public string Name { get; set; }

        public decimal Money { get; private set; }

        public void Withdraw(decimal money)
        {
            if (this.Money < money)
            {
                throw new ArgumentException("asdf");
            }

            this.logger.Log($"{this.Name} withdraw {money}.");
            this.Money -= money;
        }
        
        public void Deposit(decimal money)
        {
            this.logger.Log($"{this.Name} depisits {money}.");
            this.Money += money;
        }
    }
}
