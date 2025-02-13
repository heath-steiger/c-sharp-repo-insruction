using ConsoleLibrary;
namespace _1101Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Countable> count = new List<Countable>();
            Alligator a1 = new Alligator(1);

            MyConsole.PrintLine("Counting alligators...\n");
            for
                (int i = 0; i < 3; i++) {
               MyConsole.PrintLine(a1.GetCountString());
            }

            Sheep s1 = new Sheep(1, "Blackie");
            MyConsole.PrintLine("\nCounting sheep...\n");
            for (int i = 0; i < 2; i++) {
                MyConsole.PrintLine(s1.GetCountString());
            }


        }
    }
}
