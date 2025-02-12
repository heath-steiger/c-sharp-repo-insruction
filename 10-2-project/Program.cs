using ConsoleLibrary;
namespace _10_2_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice1 = "y";
            while (choice1 == "y") {
                MyConsole.PrintLine("Welcome to the Person Manager");
                string choice = MyConsole.PromptReqString("Create customer or employee? (c/e) ", "c", "e");
                while (choice == "c") {
                    string FirstName = MyConsole.PromptString("First Name: ");
                    string LastName = MyConsole.PromptString("Last Name: ");
                    string CustomerNbr = MyConsole.PromptString("Customer number: ");
                    MyConsole.PrintLine($"First name: {FirstName}");
                    MyConsole.PrintLine($"Last name: {LastName}");
                    MyConsole.PrintLine($"Customer Number: {CustomerNbr}");
                }
                while (choice == "e") {
                    string FirstName = MyConsole.PromptString("First Name: ");
                    string LastName = MyConsole.PromptString("Last Name: ");
                    string SSN = MyConsole.PromptString("SSN: ");
                    MyConsole.PrintLine($"First name: {FirstName}");
                    MyConsole.PrintLine($"Last name: {LastName}");
                    MyConsole.PrintLine($"SSN: {SSN}");
                }
                choice = MyConsole.PromptString("Continue (y/n): ");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
