namespace _4_2_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            PrintL("Welcome to the Factorial Calculator");
            string choice = "y";
            while (choice == "y") {
                while (true) {

                    string input = (GetString("\nEnter an integer that's greater than 0 and less than 10:"));
                        if (int.TryParse(input, out nbr) && nbr > 0 && nbr < 16) {
                            break; // Valid input, exit loop
                        }
                        PrintL("Invalid input. Please enter a number between 1 and 10.");
                    
                }
                int F = 1;
                for (int i = 1; i <= nbr; i++) {
                    F *= i;
                }
                PrintL("The factorial of " + nbr + " is " + F);
                choice = GetString("continue? (y/n)");
            }
            PrintL("Bye");

        }
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        private static void PrintL(string prompt, string endLine = "\n")
        {
            Console.WriteLine(prompt);
        }
        private static void Print(string prompt, string endLine = "\n")
        {
            Console.Write(prompt);
        }

    }
}
