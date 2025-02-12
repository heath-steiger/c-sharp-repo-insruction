namespace project5_3_demo
{
    public class MyConsole
    {
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        public static string DisplayWinnerMessage(int count)
        {
            string msg = ("\nYou got it in " + count + " tries.");
            if (count <= 3) { msg += ("\nGreat work! You are a mathematical wizard."); }
            else if (count <= 7) { msg += ("\nNot too bad! You've got some potential."); }
            else { msg += ("\nWhat took you so long? Maybe you should take some lessons."); }
            return msg;
        }
        public static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Print(string msg)
        {
            Console.Write(msg);
        }
        public static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                }
                
                catch (Exception e) {
                    Print("Error - entry must be a whole number.");                   
                    continue;
                }
                if (nbr >= MIN_VAL && nbr <= MAX_VAL) {
                    success = true;
                }
                else {
                    Print("Error - entry must be between " + MIN_VAL + " and " + MAX_VAL + ".");
                }

            }

            return nbr;
        }
        public static string GetRequiredString(string prompt, string val1, string val2)
        {
            string str = "";
            while (true) {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "") {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2) {
                    Print("Erorr - entry must be either " + val1 + " or " + val2);
                }
                else {
                    break;
                }
            }
            return str;
        }
    }
}
