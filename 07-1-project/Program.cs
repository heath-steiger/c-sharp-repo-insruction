namespace _07_1_project
{
    internal class Program
    {
        static List<Contact> Contacts = new List<Contact>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact List App!");


            Contact newContact = new Contact();
            string choice = "y";
            while (choice == "y") {
                // capture input for contact
                string FirstName = MyConsole.PromptString("Enter first name: ");
                string LastName = MyConsole.PromptString("Enter last name:");
                string Email = MyConsole.PromptString("Enter email: ");
                string Phone = MyConsole.PromptString("Enter phone:");
                
                //store this movie and capture a new one
                newContact = new Contact(FirstName, LastName, Email, Phone);
                Contacts.Add(newContact);
                MyConsole.PrintLine("\n=======================================");
                MyConsole.PrintLine("=====Current Contact===================");
                MyConsole.PrintLine("=======================================");
                foreach (Contact contact in Contacts) {
                    MyConsole.PrintLine($"Name:              {contact.FirstName + contact.LastName}  ");
                    MyConsole.PrintLine($"Email Address:     {contact.Email}  ");
                    MyConsole.PrintLine($"Phone Number:      {contact.Phone}  ");
                }
                MyConsole.PrintLine("=======================================\n");

                choice = MyConsole.PromptString("Continue? (y/n): ");
            }


        }
    }
}
