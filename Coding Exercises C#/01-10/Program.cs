using System;
using System.Security.Cryptography.X509Certificates;

namespace tipcalculator
{
    /*
     * Challenge:
     * - Write a C# function that calculates and returns three different tip percentages for a meal.
     * 
     * Criteria:
     * - Return all tip three percentages as a single type (Easy).
     * - Calculate tipping fees using delegates (Hard).
     */
    public delegate void TipDelegate(int inputPrice, ref string outputTip);
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            var tippingFees = CalculateTipEasy(input);
            PrintTippingFees(tippingFees.lowTip, tippingFees.midTip, tippingFees.highTip);
            CalculateTipHard(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        // Easy solution
        public static (string lowTip, string midTip, string highTip) CalculateTipEasy(int cost)
        {
            string _lowTip = CalculateTip(cost, 0.1);
            string _midTip = CalculateTip(cost, 0.175);
            string _highTip = CalculateTip(cost, 0.25);

            return (_lowTip, _midTip, _highTip);
        }

        // Hard solution
        public static void CalculateTipHard(int cost)
        {
            string lowTippingFee = String.Empty, 
                midTippingFee = String.Empty, 
                highTippingFee = String.Empty;

            TipDelegate tipdelegate;
            LowTip lowTip = new LowTip();
            MidTip midTip = new MidTip();
            HighTip highTip = new HighTip();

            tipdelegate = lowTip.CalculateTippingFee;
            tipdelegate(cost, ref lowTippingFee);

            tipdelegate = midTip.CalculateTippingFee;
            tipdelegate(cost, ref midTippingFee);

            tipdelegate = highTip.CalculateTippingFee;
            tipdelegate(cost, ref highTippingFee);

            PrintTippingFees(lowTippingFee, midTippingFee, highTippingFee);
        }

        public static string CalculateTip(int cost, double fee)
        {
            return Math.Round(cost * fee, 2).ToString("#.00");
        }

        public static void PrintTippingFees(string lowTip, string midTip, string highTip)
        {
            Console.WriteLine($"\nLow (10%) -> ${lowTip}");
            Console.WriteLine($"Mid (17,5%) -> ${midTip}");
            Console.WriteLine($"High (25%) -> ${highTip}");
        }
    }

    abstract class TipCalculation
    {
        public virtual void CalculateTippingFee(int inputPrice, ref string outputTip) { }
    }

    internal class LowTip : TipCalculation
    {
        public override void CalculateTippingFee(int inputPrice, ref string outputTip)
        {
            outputTip = Math.Round(inputPrice * 0.1, 2).ToString("#.00");
        }
    }

    internal class MidTip : TipCalculation
    {
        public override void CalculateTippingFee(int inputPrice, ref string outputTip)
        {
            outputTip = Math.Round(inputPrice * 0.175, 2).ToString("#.00");
        }
    }

    internal class HighTip : TipCalculation
    {
        public override void CalculateTippingFee(int inputPrice, ref string outputTip)
        {
            outputTip = Math.Round(inputPrice * 0.25, 2).ToString("#.00");
        }
    }
}
