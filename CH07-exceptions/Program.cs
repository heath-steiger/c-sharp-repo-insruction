namespace CH07_exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, chapter 7 - exceptions and data validation");

            int nbr1 = 0;
            while (true) {
                Console.Write("Enter an interger: ");
                if (!Int32.TryParse(Console.ReadLine(), out nbr1)) {
                    Console.WriteLine("Error- enter whole number.");
                }
                else { break; }
            }


            Console.WriteLine("You entered: " + nbr1);



            Console.WriteLine("bye");
        }
    }
}
