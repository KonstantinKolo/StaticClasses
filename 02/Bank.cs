using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    static class Bank
    {
        public static void WithDrawMultiple(int id, List<BankAccount> list, double ammount)
        {
            bool accExists = false;
            foreach(var account in list)
            {
                if(account.Id == id)
                {
                    accExists = true;
                }
            }
            if (accExists == false)
            {
                throw new ArgumentException("Account doesn't exist!");
            }
            else
            {
                foreach (var account in list)
                {
                    if(account.Id == id)
                    {
                        if (account.Balance < ammount)
                        {
                            throw new ArgumentException("Money not available.");
                        }
                        else
                        {
                            account.Balance -= ammount;
                        }
                    }
                }                
            }
        }

        public static void MoneyAddMultiple(int id, List<BankAccount> list, double ammount)
        {
            bool accExists = false;
            foreach (var account in list)
            {
                if (account.Id == id)
                {
                    accExists = true;
                }
            }
            if (accExists == false)
            {
                throw new ArgumentException("Account doesn't exist!");
            }
            else
            {
                foreach (var account in list)
                {
                    if (account.Id == id)
                    {
                        account.Balance += ammount;
                    }
                }
            }
        }
    }
}
