using ConsoleLibrary;

namespace CH08Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the SortedLists Demo");

            // p. 262
            // create a sortedList of usStates
            SortedList<string, string> usStates = new SortedList<string, string>();
            usStates.Add("OH", "Ohio");
            usStates.Add("IN", "Indiana");
            usStates.Add("MI", "Michigan");
            usStates.Add("CO", "Colorado");

            foreach (KeyValuePair<string, string> state in usStates) {
                MyConsole.PrintLine($"{state.Key}:{state.Value}");
            }

            // get all keys
            foreach (string s in usStates.Keys) {
                MyConsole.PrintLine(s + "|");
            }
            MyConsole.PrintLine(" ");

            foreach (string s in usStates.Values) {
                MyConsole.PrintLine(s + "|");
            }
            MyConsole.PrintLine(" ");

            //p. 263 collection initializer

            usStates = new SortedList<string, string> { {"OH", "Ohio" }, { "IN", "Indiana" },
                {"CO", "Colorado" },{"MI", "Michigan" }, {"HI", "Hawaii" } };


            //using chat gpt
            usStates = new SortedList<string, string>
            {
            { "AK", "Alaska" }, { "AL", "Alabama" }, { "AR", "Arkansas" },
            { "AZ", "Arizona" }, { "CA", "California" }, { "CO", "Colorado" },
            { "CT", "Connecticut" }, { "DE", "Delaware" }, { "FL", "Florida" },
            { "GA", "Georgia" }, { "HI", "Hawaii" }, { "IA", "Iowa" },
            { "ID", "Idaho" }, { "IL", "Illinois" }, { "IN", "Indiana" },
            { "KS", "Kansas" }, { "KY", "Kentucky" }, { "LA", "Louisiana" },
            { "MA", "Massachusetts" }, { "MD", "Maryland" }, { "ME", "Maine" },
            { "MI", "Michigan" }, { "MN", "Minnesota" }, { "MO", "Missouri" },
            { "MS", "Mississippi" }, { "MT", "Montana" }, { "NC", "North Carolina" },
            { "ND", "North Dakota" }, { "NE", "Nebraska" }, { "NH", "New Hampshire" },
            { "NJ", "New Jersey" }, { "NM", "New Mexico" }, { "NV", "Nevada" },
            { "NY", "New York" }, { "OH", "Ohio" }, { "OK", "Oklahoma" },
            { "OR", "Oregon" }, { "PA", "Pennsylvania" }, { "RI", "Rhode Island" },
            { "SC", "South Carolina" }, { "SD", "South Dakota" }, { "TN", "Tennessee" },
            { "TX", "Texas" }, { "UT", "Utah" }, { "VA", "Virginia" },
            { "VT", "Vermont" }, { "WA", "Washington" }, { "WI", "Wisconsin" },
            { "WV", "West Virginia" }, { "WY", "Wyoming" }
            };

            MyConsole.PrintLine("=== all 50 states ===");
            string sa = "";
            while (sa != "EX") {
                sa = MyConsole.PromptString("State Abbrev: ").ToUpper();
                if (sa == "EX") break;
                string sn = "";
                try { 
                    sn = usStates[sa];
                }
                catch (Exception) {
                    MyConsole.PrintLine($"Error - no state for '{sa}'.");
                    continue;
                }
                MyConsole.PrintLine(sn);
            }

            MyConsole.PrintLine("bye");
        }
    }
}
