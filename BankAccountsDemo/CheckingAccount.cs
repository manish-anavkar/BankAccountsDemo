using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsDemo
{
    // Requirement: Checking Account
    public class CheckingAccount:IAccount
    {
        public string? Owner {  get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient balance.");
            }
        }

        public void Transfer(IAccount toAccount, decimal amount)
        {
            if(Balance >= amount)
            {
                this.Withdraw(amount);
                toAccount.Deposit(amount);
            }
            else
            {
                throw new Exception("Insufficient balance for transfer.");
            }
        }
    }
}
