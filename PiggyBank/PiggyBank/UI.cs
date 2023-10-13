using PiggyBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    internal class UI
    {
        public static void Deposit(BankController bc)
        {
            Console.Write("Deposit amount: ");
            string input = Console.ReadLine();

            if (input == "exit")
            {
                bc.ContinueTransaktions = false;
            }
            bc.ValidDeposit = Int32.TryParse(input, out int amount);
            bc.DepositAmount = amount;
        }
    }
}
