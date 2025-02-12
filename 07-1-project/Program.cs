namespace _07_1_project
{
    internal class Program
    {
        static List<Contact> Contacts = new List<Contact>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List App!");


            string choice = "y";
            while (choice == "y") {
                // capture input for contact
                string FirstName = MyConsole.PromptString("Enter first name: ");
                string LastName = MyConsole.PromptString("Enter last name:");
                string Email = MyConsole.PromptString("Enter email: ");
                string Phone = MyConsole.PromptString("Enter phone:");
                // create contact instance
                Contact c = new Contact(FirstName, LastName, Email, Phone);
                //display contact
                MyConsole.PrintLine(c.DisplayContact());
                choice = MyConsole.PromptString("Continue? (y/n): ");
            }


        }
    }
}
