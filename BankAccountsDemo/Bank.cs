using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsDemo
{
    public class Bank
    {
        // Requirement: Bank has a name and several accounts
        public string? Name { get; set; }
        public List<IAccount> Accounts { get; set; } = new List<IAccount>();
    }
}
