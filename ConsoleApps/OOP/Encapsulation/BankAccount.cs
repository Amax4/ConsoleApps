using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.OOP.Encapsulation
{
    internal class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposite amount must be positive");
                //Console.WriteLine("Deposit amount must be greater than zero");
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) Console.WriteLine("Withdrawl amount must be greater than zero");
            else if (amount > balance) Console.WriteLine("Withdraw unsuccessful: Insufficient funds");
            else balance -= amount;
        }
    }
}