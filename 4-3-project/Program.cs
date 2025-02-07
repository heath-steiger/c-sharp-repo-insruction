using System;

namespace _4_3_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            while (choice == "y") {
                Console.WriteLine("Welcome to the Tip Calculator");

                Console.Write("\nCost of Meal:");
                Decimal Cost = Decimal.Parse(Console.ReadLine());
                for (decimal d = d =.15m; d <= .25m; d += .05m) {
                    decimal tipAmt = Cost * d;  
                    decimal totalAmt = Cost + tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("15%");
                    Console.WriteLine("Tip amount: " + tipAmt.ToString("c"));
                    Console.WriteLine("Total amount: "+ totalAmt.ToString("c"));

                }


                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("bye");
        }
    }
}
