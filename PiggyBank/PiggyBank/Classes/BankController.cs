using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Classes
{
    internal class BankController
    {
        public int DepositAmount { get; set; }
        public bool ValidDeposit { get; set; }
        public bool ContinueTransaktions { get; set; } = true;

        //Events Solution
        public void CheckBalance(int amount)
        {
            Console.WriteLine("The balance is: {0}", amount);
        }
        public void SavingsListener(int amount)
        {
            if(amount >= 500)
            {
                Console.WriteLine("Your goal is reached, you have: {0}", amount);
            }
        }
    }
}
