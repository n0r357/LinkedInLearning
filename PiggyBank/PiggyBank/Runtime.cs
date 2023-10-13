using PiggyBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    internal class Runtime
    {
        public void Start()
        {
            BankController bc = new BankController();
            BankPublisher bp = new BankPublisher();

            //Events Solution
            //bp.amountChanged += bc.CheckBalance;
            //bp.amountChanged += bc.SavingsListener;

            //Lambda Solution
            bp.amountChanged += (amount) => Console.WriteLine("The balance is: {0}", amount);
            bp.amountChanged += (amount) => { if (amount >= 500) Console.WriteLine("Your goal is reached, you have: {0}", amount); };

            do
            {
                UI.Deposit(bc);
                if (bc.ValidDeposit)
                {
                    bp.BankBalance += bc.DepositAmount;
                } 
                else
                {
                    Console.WriteLine("Enter valid amount or write 'exit' to quit.");
                }
            } while (bc.ContinueTransaktions);
        }
    }
}
