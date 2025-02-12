namespace _07_2_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Convertor");
            string choice = "y";
            while (choice == "y") {
                int getNumber = MyConsole.PromptInt("\nEnter Grade: ");
           Grade grade = new Grade(getNumber);
                MyConsole.PrintLine(grade.GetLetter());
                Console.Write("Continue (y/n):");
                choice = Console.ReadLine();
            }



        }
    }
}
