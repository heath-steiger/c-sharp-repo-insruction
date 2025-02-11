namespace ch08_2_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintL("The Sales Report application");



            
            decimal sum = 0.0m;
            decimal[,] sales =  {
                    { 1540.00m, 2010.00m, 2450.00m, 1845.00m },
                    { 1130.00m, 1168.00m, 1847.00m, 1491.00m },
                    { 1580.00m, 2305.00m, 2710.00m, 1284.00m },
                    { 1105.00m, 4102.00m, 2391.00m, 1576.00m }
            };

            // step one dump data to console by region and quarter
            PrintL("Region\tQ1\t\tQ2\t\tQ3\t\tQ4");
            for (int i = 0; i < sales.GetLength(0); i++) {
                Print((i + 1) + "\t"); 
                for (int j = 0; j < sales.GetLength(1); j++) {
                    Print(sales[i,j].ToString("c") + "\t");
                }
                PrintL("");
            }
            PrintL("");
                // sum sales by region
            PrintL("Sales by region: ");
            for (int i = 0; i < sales.GetLength(0); i++) {
                Print("Region " +(i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
                PrintL(sum.ToString("c"));
            }
            PrintL(" ");
            // sum sales by quarter
            PrintL("Sales by quarter: ");
            for (int i = 0; i < sales.GetLength(0); i++) {
                Print("Q" + (i + 1) + ": ");
                sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[j, i];
                }
                PrintL(sum.ToString("c"));
            }
            PrintL(" ");
            // total sales
            sum = 0.0m;
            Print("Total Sales: ");
            for (int i = 0; i < sales.GetLength(0); i++) {
                for (int j = 0; j < sales.GetLength(1); j++) {
                    sum += sales[i, j];
                }
            }
            PrintL(sum.ToString("c"));
            PrintL("\nbye");
        }
        
        static void PrintL(string message)
        {
            Console.WriteLine(message);

        }
        static void Print(string message)
        {
            Console.Write(message);

        }
    }
}
