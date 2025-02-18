using ConsoleLibrary;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Hangman!");



            MyConsole.PrintLine(gallows);
            MyConsole.PrintLine(gallowsHead);
            MyConsole.PrintLine(gallowsTorso);
            MyConsole.PrintLine(gallowsRArm);
            MyConsole.PrintLine(gallowsLArm);
            MyConsole.PrintLine(gallowsRLeg);
            MyConsole.PrintLine(gallowsLLeg);





        }

        static string GetHangmanImage() {

                string[] images = new string[7];
                images[0] = "_____\n|    |\n|\n|\n|\n|_______";
                images[1] = "_____\n|    |\n|    O\n|\n|\n|_______";
                images[2] = "_____\n|    |\n|    O\n|    |\n|\n|_______";
                images[3] = "_____\n|    |\n|    O\n|    |\\\n|\n|_______";
                images[4] = "_____\n|    |\n|    O\n|   /|\\\n|\n|_______";
                images[5] = "_____\n|    |\n|    O\n|   /|\\\n|     \\\n|_______";
                images[6] = "_____\n|    |\n|    O\n|   /|\\\n|   / \\\n|_______";
            for (int i = 0; i < 7; i++) {
            
            }
        }

            //get random word
            // if guess is correct - print letter
            // if guess is wrong - get image 7 incorrect guesses
    }
}
