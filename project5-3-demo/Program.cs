namespace project5_3_demo
{
    internal class Program
    {  static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the guessing Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++");
            MyConsole.PrintLine("");
            string choice = "y";
            while (choice == "y") {
                Game game = new Game();
                MyConsole.Print("I'm thinking of a number from " + 1 + " to " + 100 + ".\nTry to guess it.\n");
                MyConsole.PrintLine(game.Guess());
                MyConsole.PrintLine("");
                choice = MyConsole.GetRequiredString("Try again/ (y/n): ", "y", "n");
                MyConsole.PrintLine("");
            }
            MyConsole.Print("Bye - come back soon!");
        }
    }
}
