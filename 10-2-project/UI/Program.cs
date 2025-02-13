using _10_2_project.Model;
using ConsoleLibrary;
namespace _10_2_project.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Person Manager\n");
            string choice = "y";
            while (choice == "y")
            {
                    string personType = MyConsole.PromptReqString("Create customer or employee? (c/e) ", "c", "e");
                    string firstName = MyConsole.PromptString("First Name: ");
                    string lastName = MyConsole.PromptString("Last Name: ");
              
                    Person p;
                    if (personType == "c") {
                        string customerNumber = MyConsole.PromptString("Customer number: ");
                        Customer c = new Customer(firstName, lastName, customerNumber);
                        p = c;
                    }
                    else {
                        string ssn = MyConsole.PromptString("SSN: ");
                        Employee e = new Employee(firstName, lastName, ssn);
                        p = e;
                    }
                    MyConsole.PrintLine(" ");
                    MyConsole.PrintLine("You entereed a new " + p.GetType().Name + ":");
                    MyConsole.PrintLine(p.ToString());
                   
                
                choice = MyConsole.PromptReqString("Continue (y/n): ", "y", "n");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
