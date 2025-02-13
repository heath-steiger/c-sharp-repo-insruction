namespace _1101Project
{
    public interface Countable
    {
        public int Count { get; set; }
        public abstract int IncrementCount();
        public abstract int ResetCount();
        public abstract string GetCountString();
    }
}
