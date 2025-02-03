namespace cho4_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.Write("Enter your name:");
            string firstname = Console.ReadLine();            
            Console.Write("Enter your last name:");
            string lastname = Console.ReadLine(); 
            Console.Write("Enter year of birth:");
            string birthdate = Console.ReadLine();
            Console.WriteLine("Welcome " + firstname + " " + lastname + "!");
            Console.WriteLine("your registration is complete.");
            Console.WriteLine("your temporary password is: " + firstname + "*" + birthdate);

            //exercise 2

            Console.WriteLine("Welcome to the Letter Grade Converter");
            string choice = "y";
            while (choice == "y") { 
              Console.Write("Enter numerical grade:");
                string Grade = Console.ReadLine();
                int N1 = Convert.ToInt32(Grade);
                    if (N1 >= 88) { Grade = "A"; }
                    else if (N1 >= 80) { Grade = "B"; }
                    else if (N1 >= 67) { Grade = "C"; }
                    else if (N1 >= 60) { Grade = "D"; }
                    else if (N1 <= 59) { Grade = "F"; }
                Console.Write(Grade);
             Console.Write("Continue (y/n):");
            choice = Console.ReadLine(); }

            //exercise 3
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            string choice1 = "y";
            while (choice1 == "y" || choice1 == "Y") {
                Console.Write("Enter length:");
            double length = double.Parse(Console.ReadLine());
            double A1 = Convert.ToInt32(length);
            Console.Write("Enter width:");
            double width = double.Parse(Console.ReadLine());
            double P1 = Convert.ToInt32(width);
            Console.WriteLine("Area:" + P1 * A1);
            Console.WriteLine("Perimeter:" +((2 * P1) + (2 * A1)));
            Console.WriteLine("Continue (y/n):");
            choice1 = Console.ReadLine();
        }

        Console.WriteLine("bye");
        }
    } 
}
