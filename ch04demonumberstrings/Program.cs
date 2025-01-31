using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace ch04demonumberstrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers and Strings Demo!");
            int dayOfWeek = 5;
            decimal price = 11.99m;
            int quantity = 3;
            char letter = 'A';
            bool isValid = false;
            double interestRate = .0367;

            //constants
            const int DaysinWeek = 7;
            const int DaysInNovember = 30;
            const int DAYS_IN_YEAR = 365;

            //arithmetic operators
            decimal LineItemTotal = price * quantity;
            int count = 0;
            Console.WriteLine("count =" + count);
            count = count + 1;
            Console.WriteLine("count =" +count);
            count++;
            Console.WriteLine("count =" + count);

            int a = 9;
            int b = 2;
            int quotient = 9 / 2;
            int remainder = 9 % 2;
            Console.WriteLine("quotient = " + quotient);
            Console.WriteLine("remainder ="+remainder);

            double result = a / b;
            Console.WriteLine("result =" + result);
            double c = 9.0;
            double d = 2.0;
            result = c / d;
            Console.WriteLine("result ="+result);

            int counter = 10;
            // increment by 1
            counter = counter + 1;
            counter++;
            counter += 1;
            Console.WriteLine("counter = "+counter);

            // add 5 to counter
            counter = counter + 5;
            counter += 5;

            //subtract 2 from counter
            counter -= 2;

            // casting
            int e = 5;
            double f = e;

            double g = 6.7;
            int h = (int)g;
            Console.WriteLine("h = "+h); // h is 6

            // Math class
            interestRate = .0347825;
            Console.WriteLine("interestRate="+interestRate);
            // rounded to 4 decimal places
            interestRate = Math.Round(interestRate, 4);
            Console.WriteLine("interestRate=" + interestRate);
      
            //RNG
            Random rand = new Random();
            int r1 = rand.Next();
            Console.WriteLine("r1=" + r1);
            int dieRoll = rand.Next(1, 7);
            Console.WriteLine("dieRoll=" + dieRoll);

            // strings
            string firstName = "bob";
            string lastName = "Marley";
            //string fullName = firstName + " " + lastName;
            string fullName = firstName;
            fullName += " ";
            fullName+= lastName;

            // escape sequences - tab, newline, backslash
            string sentence = "abc\tdef\nghi";
            string reposFolder = "c:\\repos";
            Console.WriteLine(reposFolder);
            Console.WriteLine(sentence);

            string rawMessage = """
                hello there
                how are you?

                I'm fine, how are you??
                """;
            Console.WriteLine(rawMessage);

            // get input from console
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // basic while loop:
            //execute the 2 numbers and sum until user is done

            string choice = "y";
            while (choice == "y") {

                Console.WriteLine("Enter a whole number: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sum= " + (n1 + n2));
                Console.WriteLine("Continue (y/n)");
                choice = Console.ReadLine();
            }

            // if statement
            // discount %:
            // if amount > 1000, discPct = .10
            // else if amount > 800, discPct = .08
            // else if amount > 500, discPct = .05
            // otherwise discPct = .00
            double amount = 900;
            double discPct = 0.0;
            if (amount >= 1000) {
                discPct = .1;
                    }
            else if (amount >= 800) {
                discPct = .08;
            }
            else if (amount >= 500) {
                discPct = .05;

            }
            else {
                discPct = 0.0;
            }

            Console.WriteLine("Bye");
        }   
    }
}
