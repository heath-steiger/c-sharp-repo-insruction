namespace cho4_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");
            Console.WriteLine("Enter your name:");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname);
            Console.WriteLine("Enter your last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine(lastname);
            Console.WriteLine("Enter year of birth:");
            string birthdate = Console.ReadLine();
            Console.WriteLine(birthdate);
            Console.WriteLine("Welcome " + firstname + " " + lastname + "!");
            Console.WriteLine("your registration is complete.");
            Console.WriteLine("your temporary password is: " + firstname + "*" + birthdate);

            //exercise 2

            Console.WriteLine("Welcome to the Letter Grade Converter");
            string choice = "y";
            while (choice == "y") { 
            Console.WriteLine("Enter numerical grade:");
            string Grade = Console.ReadLine();
            int N1 = Convert.ToInt32(Grade);
            if (N1 >= 88) { Grade = "A"; }
            else if (N1 >= 80) { Grade = "B"; }
            else if (N1 >= 67) { Grade = "C"; }
            else if (N1 >= 60) { Grade = "D"; }
            else if (N1 <= 59) { Grade = "F"; }
            Console.WriteLine(Grade);
                Console.WriteLine("Continue (y/n)");
            choice = Console.ReadLine(); }

            //exercise 3
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            string choice1 = "y";
            while (choice1 == "y") {
                Console.WriteLine("Enter length:");
            string length = Console.ReadLine();
            int A1 = Convert.ToInt32(length);
            Console.WriteLine("Enter width:");
            string width = Console.ReadLine();
            int P1 = Convert.ToInt32(width);
            Console.WriteLine("Area:" + P1 * A1);
            Console.WriteLine("Perimeter:" +((2 * P1) + (2 * A1)));
            Console.WriteLine("Continue (y/n)");
            choice1 = Console.ReadLine();
        }

        Console.WriteLine("bye");
        }
    }
}
