namespace ch08_1_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the batting Average Calculator");

            string choice = "y";
            while (choice == "y") {
                int bats = GetBats("\nEnter number of times at bat: ");
                int[] atBat = new int[bats];
                int t = 1;
                int hits = 0;
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = homerun");
                Console.WriteLine("");
                for (int i = 0; i < atBat.Length; i++) {
                    atBat[i] = GetBases("Result for at-bat  " + t++ + ": ");
                }
                foreach (int result in atBat) {
                    if (result > 0) {
                        hits++;
                    }
                }
                double batAve = (double)hits / atBat.Length;
                double sum = atBat.Sum();
                Console.WriteLine("\nBatting Average: " + batAve.ToString("0.000"));
                Console.WriteLine("Slugging percent: " + (sum / bats));
                Console.Write("\nAnother player? (y/n)");
                choice = Console.ReadLine();
            }

            Console.WriteLine("bye");
        }
        static int GetBats(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Error - entry must be a whole number.");
                    continue;
                }
                if (nbr >= 1 && nbr <= 30) {
                    success = true;
                }
                else {
                    Console.WriteLine("Error - entry must be between " + 1 + " and " + 30);
                }
            }
            return nbr;
        }
        static int GetBases(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Error - entry must be a whole number.");
                    continue;
                }
                if (nbr >= 0 && nbr <= 4) {
                    success = true;
                }
                else {
                    Console.WriteLine("Error - entry must be between " + 0 + " and " + 4);
                }
            }
            return nbr;
        }


    }
}
