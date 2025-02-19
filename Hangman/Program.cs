using ConsoleLibrary;
using Hangman.Model;

namespace Hangman
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            HangmanWords hangman = new HangmanWords();
            MyConsole.PrintLine("Welcome to Hangman!");
            PopulateImages();
            MyConsole.PrintLine(hangman.GetRandomWord());

            for (int i = 0; i < images.Length; i++) {
                MyConsole.PrintLine($"Image{i}");
                MyConsole.PrintLine(images[i]);
                MyConsole.PrintLine("=========");

            }
            MyConsole.PrintLine();
        }
        static string GetHangmanImage(int incorrectGuesses)
        {
            return images[incorrectGuesses];


        }
        static void PopulateImages()
        {
            images[0] = "_____\n|    |\n|\n|\n|\n|_______";
            images[1] = "_____\n|    |\n|    O\n|\n|\n|_______";
            images[2] = "_____\n|    |\n|    O\n|    |\n|\n|_______";
            images[3] = "_____\n|    |\n|    O\n|    |\\\n|\n|_______";
            images[4] = "_____\n|    |\n|    O\n|   /|\\\n|\n|_______";
            images[5] = "_____\n|    |\n|    O\n|   /|\\\n|     \\\n|_______";
            images[6] = "_____\n|    |\n|    O\n|   /|\\\n|   / \\\n|_______";
        }
        //get random word

        // if guess is correct - print letter
        // if guess is wrong - get image 7 incorrect guesses

    }
}
