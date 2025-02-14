namespace _1102Project
{
    internal class Account : Balanceable, Withdrawable, Depositable
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount; 
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
