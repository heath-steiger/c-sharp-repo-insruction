using ConsoleLibrary;
namespace _07_2_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Convertor");
            string choice = "y";
            while (choice == "y") {
                // ** ChangeRequeset: Need MyConsole.PromptInt(string prompt, int min , int max)
                int getNumber = MyConsole.PromptInt("\nEnter Grade: ",0,100);
                Grade grade = new Grade(getNumber);
                MyConsole.PrintLine("Letter grade: " + grade.GetLetter());
                choice = MyConsole.PromptReqString("Continue (y/n): ", "y", "n");
            }



        }
    }
}
