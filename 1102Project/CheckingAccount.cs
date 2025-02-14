namespace _1102Project
{
    internal class CheckingAccount : Account
    {
        public decimal MonthlyFee { get; set; }

        public CheckingAccount(decimal monthlyFee)
        {
            this.MonthlyFee = monthlyFee;
        }


        public void SubtractFeeFromBalance()
        {
            Balance -= MonthlyFee;
        }


    }
}
