namespace _1101Project
{
    internal class Alligator : Animal
    {
        public Alligator(int count) :
            base(count){ }

    public override string GetCountString()
    {
        return $"{IncrementCount()} Alligator";
    }

}
}
