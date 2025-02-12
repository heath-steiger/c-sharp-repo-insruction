namespace project5_3_demo
{
    public class Game
    {
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        public Random RandomNumber {  get; set; }  
       public Game()
        {
            this.RandomNumber = new Random();
        }
        public string Guess()
        {
            int theNumber =this.RandomNumber.Next(MIN_VAL, MAX_VAL + 1);
            int count = 0;
            int guess = 0;
            while (guess != theNumber) {
                guess = MyConsole.GetNumber("\nEnter Number: ");
                count++;
                int diff = guess - theNumber;
                if (diff == 0) {
                    return MyConsole.DisplayWinnerMessage(count); 
                }
                else if (diff < -10) { MyConsole.Print("Way too low! Guess again."); }
                else if (diff < 0) { MyConsole.Print("Too low! Guess again."); }
                else if (diff > 10) { MyConsole.Print("Way too high! Guess again."); }
                else if (diff > 0) { MyConsole.Print("Too high! Guess again."); }
            }
            return "Unexpected error";
        }


    }
}
