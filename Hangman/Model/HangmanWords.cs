using ConsoleLibrary;

namespace Hangman.Model

{
    public class HangmanWords
    {
        public List<string> Words { get; set; }




        public HangmanWords()
        {
            Words = new List<string>();

            Words.Add("gravy");
            Words.Add("horse");
            Words.Add("tunnel");
            Words.Add("hotdog");
            Words.Add("missisipi");

        }

        public string GetRandomWord()
        {

            Random rand = new Random();
            int Word = rand.Next(Words.Count);
            return Words[Word];
        }
        public string GetHiddenWord(string word)
        {
          
            MyConsole.PrintLine(word);
            string hiddenWord = "";
            foreach (char c in word) {
                hiddenWord += "_";
            }
            
            return hiddenWord;
        }
        public void DisplayHiddenWord(string hiddenWord)
        {

            string display = "";
            foreach (char c in hiddenWord) {
                 display += (c + " ");
            }
            MyConsole.PrintLine($"Word: {display}");
        }
       
   




    }
}
