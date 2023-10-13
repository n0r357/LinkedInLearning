namespace Bank
{
    public class CheckingAcct : Account
    {
        private const decimal CHARGE = 35.0m;

        public CheckingAcct(string firstname, string lastname, decimal initial)
            : base(firstname, lastname, initial)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if(amount > Balance)
            {
                amount += CHARGE;
            }
            base.Withdraw(amount);
        }
    }
}