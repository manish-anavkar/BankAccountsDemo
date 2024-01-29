using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsDemo
{
    public interface IAccount
    {
        // Requirement: Account has a owner and balance
        string Owner { get; set; }
        decimal Balance { get; set; }

        // Requirement: Transactions are made on account and transaction types - Deposit, Withdraw and Transer
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void Transfer(IAccount account, decimal amount);
    }
}
