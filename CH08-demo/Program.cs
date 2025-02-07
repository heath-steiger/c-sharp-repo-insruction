namespace CH08_demo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to chapter 8 - arrays");

            // p. 231
            //array of strings for names
            string[] names = new string[9];
            names[0] = "Jim"
            names[1] = "Andy";
            names[2] = "Nick";
            names[3] = "Chirstian";
            names[4] = "Adrian";
            names[5] = "Sean";
            names[6] = "Celina";
            names[7] = "Heath";
            names[8] = "Joe";

            Console.WriteLine("");
            Console.WriteLine("position 0:" + names[0]);

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine("i: " + i + ", name: " + names[i]);
            }

            //names[9] = "new person";  produces error b/c cannot add to array

            decimal[] prices = { 1.99m, 2.25m, 4.5m };
            for (int i = 0; i < prices.Length; i++) {
                Console.WriteLine("i:" + i + ", price:" + prices[1]);
            }

            // infer the type of an array:
            var grades = new[] { 95.0, 89.0, 91.0, 98.0 };
            double sum = 0;
            for (int i = 0; i < grades.Length; i++) {
                sum += grades[i];
            }
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: " + sum / grades.Length);
            // var  stuff = new[] {"A", 4}

            string fullName = "Bob Nesta Marley";
            for (int i = 0; i < fullName.Length; i++) {
                Console.Write(fullName[i] + " ");
            }
            Console.WriteLine();


            // for each loop
            // loop through names and print on one line
            foreach (string name1 in names) {
                Console.Write(name1 + " ");
            }
            Console.WriteLine();


            // p.239 3 x 4 grid
            int[,] grid = new int[3, 4];
            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[0, 2] = 3;
            grid[0, 3] = 4;
            grid[1, 0] = 5;
            grid[1, 1] = 6;
            grid[1, 2] = 7;
            grid[1, 3] = 8;
            grid[2, 0] = 9;
            grid[2, 1] = 10;
            grid[2, 2] = 11;
            grid[2, 3] = 12;
            //print grid - nested for loop
            // i loop - rows
            string gridString = "";
            for (int i = 0; i < grid.GetLength(0); i++) {
                // j loop - columns
                for (int j = 0; j < grid.GetLength(1); j++) {
                    gridString += grid[i, j] + "\t";
                }
                gridString += "\n";
            }

            Console.WriteLine(gridString);

            //array clas
            Array.Sort(names);
            foreach (string name1 in names) {
                Console.WriteLine(name1);
            }



            //just for refrence
            Random rand = new Random();   // createas a new instance of the Random class
            int dieRoll = rand.Next(1, 7);

            // p. 257
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int i in numbers) {
                Console.Write(i + " ");
            }

            List<string> name = new List<string>();
            name.Add("jim");
            name.Add("joe");
            name.Add("nick");

            name.Insert(3, "test");

            foreach (string n in name) {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(name.Contains("jim"));
            name.Remove("test");
            foreach (string n in name) {
                Console.Write(n + " ");
            }

            /// indec position for joe?
            Console.WriteLine("joe in position: " + name.BinarySearch("joe"));
            Console.WriteLine("joe in position: " + name.IndexOf("joe"));






            Console.WriteLine("Bye");
        }
    }
}
