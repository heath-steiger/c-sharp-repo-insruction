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
            Words.Add("cactus");
            Words.Add("lantern");
            Words.Add("marble");
            Words.Add("otter");
            Words.Add("pancake");
            Words.Add("shovel");
            Words.Add("whistle");
            Words.Add("tornado");

        }

        public string GetRandomWord()
        {

            Random rand = new Random();
            int Word = rand.Next(Words.Count);
            return Words[Word];
        }
        public string GetHiddenWord(string word)
        {
          
            
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
