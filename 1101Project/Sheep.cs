namespace _1101Project
{
    internal class Sheep : Animal
    {
        public string Name { get; set; }
        
        public Sheep(int count, string name) :
            base(count)
        {
            this.Name = name;   
        }

       

        public override string GetCountString()
        {
            return $"{IncrementCount()} {this.Name}";
        }
    }
}
