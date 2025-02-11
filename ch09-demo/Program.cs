using System.Text;

namespace ch09_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintL("Welcome to strings and dates!");

            // p. 275
            // whats the current date/time?
            DateTime currentDateTime = DateTime.Now;
            // whats the current date
            DateTime today = DateTime.Today;
            

            // string contatentation
            PrintL("Current Date = "+ currentDateTime+ ".");
            // string interpolation
            PrintL($"Today = {today}.");

            //p. 277
            PrintL($"longDate: {currentDateTime.ToLongDateString()} ");
            PrintL($"longDate: {currentDateTime.ToLongTimeString()} ");
            PrintL($"longDate: {currentDateTime.ToShortDateString()} ");
            PrintL($"longDate: {currentDateTime.ToShortTimeString()} ");
         
            // p 279 info abt date
            PrintL($"Month: {currentDateTime.Month}");
            PrintL($"Day: {currentDateTime.Day}");
            PrintL($"DayOfWeek: {currentDateTime.DayOfWeek}");
            PrintL($"year: {currentDateTime.Year}");
            PrintL($"Days in month: {DateTime.DaysInMonth(2025,2)}");
            PrintL($"LeapYear - 2025: {DateTime.IsLeapYear(2025)}");

            // p. 281 manipulate date/time
            // due date in 2 months
            DateTime dueDate = currentDateTime.AddMonths(2);
            PrintL($"dueDate:{dueDate}");


            //Halloween 2025
            DateTime halloween = new DateTime(2025, 10, 31);
            PrintL($"Halloween {halloween}");
            PrintL($"halloween > today? {halloween  > currentDateTime}");
            TimeSpan timeTillHalloween = halloween.Subtract(currentDateTime);
            PrintL($"days till halloween: {timeTillHalloween.Days}");
            // string - p. 285 - loop through characters in string
            string sentence = "woohoo so glad today is friday";
            foreach(char c in sentence) {
                Print(c + " ");
            }
            PrintL("");

            // hangman - creating a underscore version of a word
            // word is superman, the hidden version would be ________
            string word = "superman";
            string hiddenVersion = " ";
            foreach (char c in word) {
                hiddenVersion += "_ ";
            }
            hiddenVersion = hiddenVersion.Trim();
            PrintL($"The word is {word}.");
            PrintL($"hiddenVersion is: {hiddenVersion}");

            // p.293 string builder
            StringBuilder sb = new StringBuilder();

            PrintL("Bye");
        }
        static void Print(string message)
        {
            Console.Write(message);
        }
        static void PrintL(string message)
        {
            Console.WriteLine(message);
        }
    }
}
