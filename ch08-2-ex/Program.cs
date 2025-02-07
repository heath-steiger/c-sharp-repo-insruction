namespace ch08_2_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sales Report application");


            var columnNames = new List<string> { "Q1", "\tQ2", "\tQ3", "\tQ4" };
            var rowNames = new List<string> {  "1", "2", "3", "4" };
            
            decimal[,] sales = new decimal[4, 4]
            {
            { 1540.00m, 2010.00m, 2450.00m, 1845.00m },
            { 1130.00m, 1168.00m, 1847.00m, 1491.00m },
            { 1580.00m, 2305.00m, 2710.00m, 1284.00m },
            { 1105.00m, 4102.00m, 2391.00m, 1576.00m }
            };

           
            Console.Write("Region\t");
            foreach (var column in columnNames) {
                Console.Write($"{column}\t");
            }
            Console.WriteLine(); 
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write($"{rowNames[i]}\t"); 

                for (int j = 0; j < sales.GetLength(1); j++) 
                {
                    Console.Write($"${sales[i, j]:N2}\t"); 
                }
                Console.WriteLine();
            }

            








                Console.WriteLine("bye");
        }
    }
}
