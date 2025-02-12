namespace Pig_Dice
{
    internal class Game
    {

        public Die Die { get; set; }



        public Game() { 
            this.Die = new Die();
        }

        public int Nbr() {
            this.Die.Roll();
            return this.Die.Value;
        }


        // get numeber of times to roll
        // get sum of dice
        public string DiceRoll() {
            int count = 0;
            int total = 0;
            int roll;
            while (true) {
                roll = Nbr();
                count++;
                total += roll;
                if (roll == 1)
                    break;
            }
            return $" Total score: {total} \nRolls: {count}";
        
        
        }
    }
}
