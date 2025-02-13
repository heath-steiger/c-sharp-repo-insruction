namespace _1101Project
{
    public abstract class Animal : Countable
    {
       
        public int Count { get; set; }

        public Animal(int count)
        {
            this.Count = count;
        }
        public int IncrementCount()
        {
            return Count++;
           

        }

        public int ResetCount()
        {
            return Count = 0;
           
        }

        public abstract string GetCountString();
        
    }
}
