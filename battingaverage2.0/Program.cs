using ConsoleLibrary;

namespace battingaverage2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Batting Averagees!\n");
            string choice = "y";
            while (choice == "y") {
                int bats = MyConsole.PromptInt("\nEnter times at bat: ", 1, 30);
                double[] atbats = new double[bats];
                MyConsole.PrintLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                for (int i = 0; i < bats; i++) {
                    atbats[i] = MyConsole.PromptInt("Result at bat " + (i + 1) + ": ", 0, 4);

                }
                double hits = 0;
                foreach (int i in atbats) {
                    if (i > 0) {
                        hits++;
                    }
                }
                double battingAverage = hits / bats;
                double sluggingAverage = atbats.Sum() / bats;
                MyConsole.PrintLine($"Batting average: {battingAverage.ToString("f3")}");
                MyConsole.PrintLine($"Slugging average: {sluggingAverage.ToString("f3")}");
                MyConsole.PrintLine();
                choice = MyConsole.PromptString("Continue (y/n): ");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
