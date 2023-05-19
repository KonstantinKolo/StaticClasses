using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class BankAccount
    {
        private int id;
        private double balance;

        public BankAccount(int id,double balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public int Id { get; set; }
        public double Balance { get; set; }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }
        public void WithdrawSingle(double ammount)
        {
            Balance -= ammount;
        }
        public override string ToString()
        {
            return $"{this.Id} -> {this.Balance:F2}";
        }
    }
}
