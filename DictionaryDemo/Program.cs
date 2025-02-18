using ConsoleLibrary;
namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hello, World!");

            Dictionary<string, string> usStates = new Dictionary<string, string>();
            //add - adds an entry throws expetion if already exits
            usStates.Add("OH", "Ohio");
            //[] Indexer - sets this position in the dictionary, replaces entry if already exists
            usStates["IN"]=("Indiana");
            MyConsole.PrintLine("Enter some US States. Enter EX to exit");
            MyConsole.PrintLine("======================================");
            string stateAbbreviation = "";
            while (stateAbbreviation != "EX") {
                stateAbbreviation = MyConsole.PromptString("US State Abbreviation: ").ToUpper();
                if (stateAbbreviation == "EX")
                    break;
                string stateName = MyConsole.PromptString("State Name:");
                usStates[stateAbbreviation] = stateName;
            }

            MyConsole.PrintLine("GetAdd states: ");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");
            MyConsole.PrintLine("Display all keys: ");
            //List<string> states = new List<string>(usStates.Keys);
            foreach (string s in usStates.Keys) {
                MyConsole.Print(s + ", ");
            }
            MyConsole.PrintLine(" ");

            MyConsole.PrintLine("Display all values: ");
            foreach (string s in usStates.Values) {
                MyConsole.Print(s + ", ");
            }
            MyConsole.PrintLine(" ");

            MyConsole.PrintLine("\n Key Value Pairs");
            foreach (KeyValuePair<string, string> entry in usStates) {
                MyConsole.Print($"{entry.Key} - {entry.Value}");
            }
            MyConsole.PrintLine(" ");

            MyConsole.PrintLine("Remove an entry: \n");
            usStates.Remove("OH");

            MyConsole.PrintLine("\n Key Value Pairs");
            foreach (KeyValuePair<string, string> entry in usStates) {
                MyConsole.Print($"{entry.Key} - {entry.Value}");
            }
            MyConsole.PrintLine(" ");

            MyConsole.PrintLine("Bye");
        }
    }
}
