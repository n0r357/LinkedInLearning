using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private string _firstname;
        private string _lastname;

        public decimal Balance
        {
            get; set;
        }

        public Account(string firstname, string lastname, decimal balance = 0.0m)
        {
            _firstname = firstname;
            _lastname = lastname;
            Balance = balance;
        }

        public string AccountOwner
        {
            get => $"{_firstname} {_lastname}";
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount) 
        {
            Balance -= amount;
        }
    }
}
