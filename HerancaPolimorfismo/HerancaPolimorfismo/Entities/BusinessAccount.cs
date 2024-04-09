namespace HerancaPolimorfismo.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        BusinessAccount() { }

        BusinessAccount(int number, string? holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }


        public void loan(double amount)
        {
            if (amount <= LoanLimit)
            {

                Balance += amount;
            }
        }

    }
}
