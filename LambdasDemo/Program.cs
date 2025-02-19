using ConsoleLibrary;

namespace LambdasDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Lambda demo!\n");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayListAsString(numbers, "Origianl list");

            List<int>squares1 = new List<int>();
            foreach (int value in numbers) {
                squares1.Add(Square(value));
            }
            DisplayListAsString(squares1, "Squared List (1)");
            // do this again using a method as a parameter
            List<int> squares2 = numbers.Select(Square).ToList();
            DisplayListAsString(squares2, "Squared List (2)- using method as parameter");

            // do this again using a method as a lambda expression
            List<int> squares3 = numbers.Select(x => x * x).ToList();
            DisplayListAsString(squares3, "Squared List (3)- using a lmabda expression");

            List<int>divThree1 = new List<int>();
            foreach (int value in numbers) {
                if (IsDivisbleByThree(value)) {
                    divThree1.Add(value);
                }
            }
            DisplayListAsString(divThree1, "DivThree List");

            //var numbersSquared = 
            // create a new list called squaredNums1
            //store the squared versions of all numbers

                // create a new list called divThree1
                // store the nums from numbers that are evenly divisible by 3

            List<int> divThree2 = numbers.FindAll(IsDivisbleByThree).ToList();
            DisplayListAsString(divThree2, "DivThree List (2):");

            List<int> divThree3 = numbers.FindAll(x => x % 3 == 0).ToList();
            DisplayListAsString(divThree3, "DivThree List (2):");

            MyConsole.PrintLine("Bye");
        }

        private static bool IsDivisbleByThree(int x)
        {
            return x % 3 == 0;
        }
        private static int Square(int nbr)
        {
            return nbr * nbr;
        }

        private static void DisplayListAsString(List<int> numbers, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in numbers) {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintLine(result);
        }
    }
}
