using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    public delegate void BalanceEventHandler(int amount);
    internal class BankPublisher
    {
        private int balance;
        public event BalanceEventHandler amountChanged;
        public int BankBalance
        {
            get
            {
                return balance;
            }
            set { 
                this.balance = value;
                this.amountChanged(balance);
            }
        }
    }
}
