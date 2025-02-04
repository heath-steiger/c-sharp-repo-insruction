using System.Reflection.Metadata.Ecma335;

namespace Ch05_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            string choice = "y";
            while (choice == "y" || choice == "Y") {
                Console.Write("Enter degrees in Fahrenheit: ");
                double Fahrenheit = double.Parse(Console.ReadLine());
                double F = Convert.ToInt32(Fahrenheit);
                Console.WriteLine("Degrees in Celsius:" + (F - 32) * 5 / 9);
                Console.WriteLine("Continue ?");
                choice = Console.ReadLine();
            }



            // exercise 2
            Console.WriteLine("Welcome to the Travel Time Calculator");
            string choice1 = "y";
            while (choice1 == "y" || choice1 == "Y") {
                Console.Write("Enter Miles: ");
                double miles = double.Parse(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                double speed = double.Parse(Console.ReadLine());
                double time = miles / speed;
                int hours = (int)time;
                int minutes = (int)((time - hours) * 60);

                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minutes);
                Console.WriteLine("Continue ?");
                choice1 = Console.ReadLine();
            }
           
            
            // exercise 3 
            string choice2 = "y";
            while (choice2 == "y" || choice2 == "Y") {
                Console.WriteLine("Welcome to the Interest Calculator");
                Console.Write("Enter loan amount: ");
                decimal price = Convert.ToInt32(decimal.Parse(Console.ReadLine()));
                Console.Write("Enter interest rate: ");
                decimal interestRate = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Loan amount: " + price.ToString("c"));
                Console.WriteLine("InterestRate: " + interestRate.ToString("p3"));
                Console.WriteLine("Interest: " + (price * (interestRate / 1)).ToString("c"));
                Console.WriteLine("Continue ?");
                choice2 = Console.ReadLine();
            }


            // exercise 4

            string choice3 = "y";
            while (choice3 == "y" || choice3 == "Y") {
                Console.WriteLine("Welcome to the Change Calculator");
                
                Console.Write("\nEnter number of cents (0-99): ");
                
                int coins = Int32.Parse(Console.ReadLine());
                int Q = coins / 25;
                coins = coins % 25;
                int D = coins / 10;
                coins %= 10;
                int N = coins / 5;
                int P = coins % 5;

                Console.WriteLine("Quarters:" + Q);
                Console.WriteLine("Dimes:" + D);
                Console.WriteLine("Nickels:" + N);
                Console.WriteLine("\nPennies:" + P);
                Console.WriteLine("Continue ?");
                choice3 = Console.ReadLine();
            }

            Console.WriteLine("Bye");



        }
    }
}
