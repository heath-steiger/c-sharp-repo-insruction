using System.Xml.Linq;

namespace _15_2_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintL("The Wizard Inventory game");



            // creat command menu - PrintL
            //create loop for decision made - readline/switch


            List<string> items = new List<string> { "wooden staff", "wizard hat", "cloth shoes" };

            PrintL("COMMAND MENU");
            string action = "";
            PrintL("show - Show all items\ngrab - Grab an item\nedit - Edit an item\ndrop - Drop an item\nexit - Exit program");
            while (action != "exit") {
                action = getPrompt("\nCommand: ").ToLower();

                switch (action) {
                    case "show":
                        for (int i = 0; i < items.Count; i++) {
                            PrintL(i + 1 + "." + items[i]);
                        }
                        break;
                    case "grab":
                        if (items.Count >= 4) {
                            PrintL("You can't carry any more items. Drop something first.");
                        }else {
                            string item = getPrompt("Name: ");
                            items.Add(item);
                            PrintL($"{item} was added.");                                                    
                        }                        
                        break;
                    case "edit":
                        
                        int itemNbr = Int32.Parse(getPrompt("Number: "));

                        items[itemNbr-1] = getPrompt("Updated Name: ");
                        break;
                    case "drop":
                        int deleteitemNbr = Int32.Parse(getPrompt("Number: "));
                        items.Remove(items[deleteitemNbr - 1]);
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }
            }
            PrintL("Bye!");
        }
        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }

        static string getPrompt(string prompt)
        {
            Console.Write(prompt, " ");
            return Console.ReadLine();

        }
    }
}
