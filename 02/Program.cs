using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(123456, 250.60);
            BankAccount acc2 = new BankAccount(098765, 890.46);
            BankAccount acc3 = new BankAccount(102938, 10.20);

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(acc1);
            bankAccounts.Add(acc2);
            bankAccounts.Add(acc3);


            //to test if the methods in BankAccount.cs work
            Console.WriteLine(acc1);
            acc1.WithdrawSingle(150.60);
            Console.WriteLine(acc1);
            acc1.Deposit(100);
            Console.WriteLine(acc1);


            //to test if the methods in Bank.cs work
            foreach(var account in bankAccounts)
            {
                Console.Write("||| " + account + " ");
            }
            Console.WriteLine();

            Bank.WithDrawMultiple(098765, bankAccounts, 490.46);
            Bank.WithDrawMultiple(102938, bankAccounts, 10);
            foreach (var account in bankAccounts)
            {
                Console.Write("||| " + account + " ");
            }
            Console.WriteLine();

            Bank.MoneyAddMultiple(102938, bankAccounts, 19.80);
            foreach (var account in bankAccounts)
            {
                Console.Write("||| " + account + " ");
            }
            Console.WriteLine();
        }
    }
}
