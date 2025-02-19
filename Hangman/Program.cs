using ConsoleLibrary;
using Hangman.Model;

namespace Hangman
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Hangman!");
            // rules of game
            PopulateImages();
            HangmanWords hangman = new HangmanWords();
            string randomWord = hangman.GetRandomWord();
            string hiddenWord = hangman.GetHiddenWord(randomWord);
            string letter = "";
            bool winner = false;
            int incorrectGuesses = 0;
            while (incorrectGuesses != 6 && !winner) {
                MyConsole.PrintLine(GetHangmanImage(incorrectGuesses));
                hangman.DisplayHiddenWord(hiddenWord);
                letter = MyConsole.PromptString("Guess a letter: ");
                char[] charsrandomWord = randomWord.ToCharArray();
                char[] charsHiddenWord = hiddenWord.ToCharArray();
                bool letterFound = false;
                for (int i = 0; i < charsrandomWord.Length; i++) {
                    char c = charsrandomWord[i];
                    if (letter.Equals(c.ToString())) {
                        //MyConsole.PrintLine($"Letter found!");
                        charsHiddenWord[i] = c;
                        letterFound = true;
                    }
                }
                hiddenWord = new string(charsHiddenWord);
                if (!letterFound) {
                    incorrectGuesses++;

                    MyConsole.PrintLine("Letter not found");
                }
                if (hiddenWord.IndexOf('_') == -1) {
                    winner = true;
                }
                hangman.DisplayHiddenWord(hiddenWord);
            }
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
    }
}