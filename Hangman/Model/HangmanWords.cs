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

        }

        public string GetRandomWord()
        {

            Random rand = new Random();
            int Word = rand.Next(Words.Count);
            return Words[Word];
        }
        public string GetHiddenWord()
        {
            string randomWord = GetRandomWord();
            string x = "_ ";
            string letter = "";
            for (int i = 0; i < randomWord.Length; i++) {
                  letter += x;
            }
            return letter;
        }





    }
}
