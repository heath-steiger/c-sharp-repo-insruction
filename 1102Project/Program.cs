using ConsoleLibrary;
namespace _1102Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Account application");
            MyConsole.PrintLine("Starting Balances");
            // init checking account, saving account
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance = 1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance = 1000.0m;
            DisplayBalances(ca, sa);
            //display starting balances
            MyConsole.PrintLine("Enter transactions for the month:\n");

            string choice = "y";
            while (choice == "y") {
                Account a;
                string action = MyConsole.PromptReqString("Withdrawal or Deposit? (w/d): ", "w", "d");
                string account = MyConsole.PromptReqString("Checking or Savings? (c/s): ", "c", "s");
                decimal amount = MyConsole.PromptDecimal("Amount? ");
                if (account == "c") {
                    a = ca;
                }
                else {
                    a = sa;
                }
                if (action == "w") {
                    a.Withdraw(amount);
                }
                else { 
                     a.Deposit(amount);
                }
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }
            // ProcessEndOfMonth - interest and fees
            sa.ApplyInterestPaymentToBalance();
            ca.SubtractFeeFromBalance();
            MyConsole.PrintLine("\nMonthly Payments and Fees:");
            MyConsole.PrintLine("Checking Fee: " + ca.MonthlyFee.ToString("c"));
            MyConsole.PrintLine("Savings Interest Payment: " + sa.MonthlyInterestPayment.ToString());
            // Display final balances
            MyConsole.PrintLine("\nFinal Balances:");
            DisplayBalances(ca, sa);




            MyConsole.PrintLine("Bye");
        }
        static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
        {
            MyConsole.PrintLine("Checking: "+ ca.Balance.ToString("c"));
            MyConsole.PrintLine("Savings: " + sa.Balance.ToString("c"));
        }
    }
}
