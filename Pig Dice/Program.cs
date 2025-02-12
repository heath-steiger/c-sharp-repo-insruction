using ConsoleLibrary;

namespace Pig_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcoem to the Pig Dice Game!");
            string choice = MyConsole.PromptString("Rolle the Dice? (y/n): ").ToLower();
            while (choice == "y") {
                Game dice = new Game();
                MyConsole.PrintLine(dice.DiceRoll());
                choice = MyConsole.PromptString("Roll again? (y/n): ");
            }
            MyConsole.PrintLine("Bye");
        }



    }
}

