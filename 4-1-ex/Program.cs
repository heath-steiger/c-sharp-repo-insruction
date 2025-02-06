namespace _4_1_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintL("Welcome to the Squares and Cubes table");

            string choice = "y";
            while (choice == "y") {
                int nbr1 = 0;
                int nbr = 0;
                while (true) {
                    if (!Int32.TryParse(GetString("\nEnter an integer:"), out nbr1)) {
                        PrintL("Error- enter whole number.");
                    }
                    else { break; }
                }
                PrintL(" Number\tSquared\tCubed");
                PrintL(" ======\t=======\t=====");
                while (nbr != nbr1) {
                    nbr++;
                    PrintL(" " + nbr + "\t" + (nbr * nbr) + "\t" + (nbr * nbr * nbr));
                }
                choice = GetString("\nContinue? (y/n)");
            }

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
