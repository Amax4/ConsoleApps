using ConsoleApps.OOP.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApps.OOP.Encapsulation
{
    internal class Bank
    {
        public Bank()
        {
            Utils.CleanUpConsole();

            BankAccount bankAccount = new BankAccount(1000);
            Console.WriteLine(bankAccount.GetBalance());

            bankAccount.Withdraw(250);
            Console.WriteLine(bankAccount.GetBalance());

            bankAccount.Deposit(500);
            Console.WriteLine(bankAccount.GetBalance());

            Utils.WaitForAnyInput();
        }
    }
}