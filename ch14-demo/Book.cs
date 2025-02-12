namespace ch14_demo
{
    internal sealed class Book : Product
    {
        public string Author { get; set; }

        public Book(string code, string description, decimal price, string author) :
            base(code, description, price) {  
            this.Author = author;
        }

        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)} ({Author})";
        }
    }
}
