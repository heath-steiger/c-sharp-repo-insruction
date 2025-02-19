using ConsoleLibrary;

namespace ListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to List/Arrays Pracitce");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DisplayList(numbers);


            List<int> evenNumbers = new List<int>();
            foreach (int i in numbers) {
                if (i % 2 == 0) {
                    evenNumbers.Add(i);
                }
            }
            DisplayList(evenNumbers);

            List<int> doubleNumbers = new List<int>();
            foreach (int i in numbers) {
                int v = (i * 2);
                    doubleNumbers.Add(v);
                
            }
            DisplayList(doubleNumbers);
        }

        public static void DisplayList(List<int> list)
        {
            string result = " ";
            foreach (var value in list) {
                result += value.ToString() + " ";
            }
            MyConsole.PrintLine(result);
        }
    }
}
