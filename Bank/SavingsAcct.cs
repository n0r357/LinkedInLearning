namespace Bank
{
    public class SavingsAcct : Account
    {
        private int _count = 0;
        private const decimal CHARGE = 2.0m;
        private const int Limit = 3;

        public SavingsAcct(string firstname, string lastname, decimal balance, decimal interest) : base(firstname, lastname, balance) 
        {
            InterestRate = interest;
        }

        public decimal InterestRate
        {
            get; set;
        }

        public void ApplyInterest()
        {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("DENIED!");
            }
            else
            {
                base.Withdraw(amount);
                _count++;

                if(_count > Limit)
                {
                    Console.WriteLine("EXTRA CHARGE!");
                    base.Withdraw(CHARGE);
                }
            }
        }
    }
}