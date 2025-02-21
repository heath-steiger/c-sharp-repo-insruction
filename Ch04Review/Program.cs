using ConsoleLibrary;

namespace Ch04Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter\n");
            string choice = "y";
            while (choice == "y") {
                int NbrGrade = (MyConsole.PromptInt("Enter numerical grade: ", 0, 100));
                string grade = "";
                if (NbrGrade >= 88) {
                    grade = "A";
                }
                else if (NbrGrade >= 80) {
                    grade = "B";
                }
                else if (NbrGrade >= 68) {
                    grade = "C";
                }
                else if (NbrGrade >= 60) {
                    grade = "D";
                }
                else { grade = "F"; }
                MyConsole.PrintLine("Letter Grade: " + grade);
                choice = MyConsole.PromptString("\nContinue? (y/n): ").ToLower();
            }


        }
    }
}
