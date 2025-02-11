namespace ch08_1_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the batting Average Calculator");
            string choice = "y";
            while (choice == "y") {
                int bats = GetInt("\nEnter number of times at bat: ", 1, 30);
                int[] atBat = new int[bats];
                int hits = 0;
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = homerun");
                Console.WriteLine("");
                for (int i = 0; i < atBat.Length; i++) {
                    atBat[i] = GetInt("Result for at-bat  " + (i+1) + ": ", 0, 4);
                }
                foreach (int result in atBat) {
                    if (result > 0) {
                        hits++;
                    }
                }
                double batAve = (double)hits / atBat.Length;
                double sum = atBat.Sum();
                Console.WriteLine("\nBatting Average: " + batAve.ToString(("f3")));
                Console.WriteLine("Slugging percent: " + (sum / bats).ToString("f3"));
                Console.Write("\nAnother player? (y/n)");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("bye");
        }
        static int GetInt(string prompt, int min, int max)
        {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(), out nbr)) {
                    if (nbr >= min && nbr <= max) {
                        success = true;
                    }
                    else {
                        Console.WriteLine("Error - entry must be between " + min + " and " + max);
                    }
                }
                else {
                    Console.WriteLine("Error - entry must be between an integer.");
                }
            }
            return nbr;
        }
    

    }
}
