using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsDemo
{
    // Requirement: Investment Account
    public class InvestmentAccount:IAccount
    {
        public string? Owner { get; set; }
        public decimal Balance { get; set; }

        // Requirement: Two types of investment accounts - Individual and Corporate
        public Constants.InvestmentAccountTypes AccountType {  get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            // Requirement: Individual investment account has a withdrawal limit of $500
            // Assumption: Limit applies only to withdrawals and not to transfers, at least not mentioned in the requirements
            if(AccountType == Constants.InvestmentAccountTypes.Individual && amount > Constants.withdrawalLimit)
            {
                throw new Exception("Withdrawal limit exceeded for Individual Investment account.");
            }

            if(Balance >= amount)
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
                throw new Exception("Insufficient balance for transer.");
            }
        }
    }
}
