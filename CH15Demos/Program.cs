using ConsoleLibrary;
namespace CH15Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to interfaces!!!\n");
            List<Summarizable> things = new List<Summarizable>();
            //creat some products
            Product p1 = new Product("c#", "Murachs c#", 53.99m);
            Product p2 = new Product("mysql", "Murachs MySQL", 44.99m);
            Product p3 = new Product("andr", "Murachs Android", 59.99m);
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);
            // creat some customers
            Customer c1 = new Customer("Adrian", "Johnson", "AJ001");
            Customer c2 = new Customer("Celina", "Saksith", "CS0020");
            things.Add(c1);
            things.Add(c2);
            // print summary
            MyConsole.PrintLine("Summary:");
            foreach (var item in things) {
                MyConsole.PrintLine($"{item.GetSummaryDetail()}");
            }
            //sort list of products
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            MyConsole.PrintLine("=== All Products ===");
            foreach (Product p in products) {
                MyConsole.PrintLine(p.GetSummaryDetail());
            }

            // sort products
            products.Sort();
            MyConsole.PrintLine("=== Sorted Products ===");
            foreach (Product p in products) {
                MyConsole.PrintLine(p.GetSummaryDetail());
            }



            MyConsole.PrintLine("Bye");
        }
    }
}
