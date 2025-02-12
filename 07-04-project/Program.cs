using ConsoleLibrary;

namespace _07_04_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to teh Dice Roller Game!\n");
            string choice = MyConsole.PromptString("Rolle the Dice? (y/n): ").ToLower();
            while (choice == "y") {
                Dice dice = new Dice();
                dice.Roll();
                MyConsole.PrintLine(dice.GetRollResults());
                choice = MyConsole.PromptString("Roll again? (y/n): ");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
