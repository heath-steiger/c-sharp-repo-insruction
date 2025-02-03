namespace ch05_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to chapter 5 demos");

            // p. 139
            int a = 5;
            int b = 7;
            Console.WriteLine(a == b);

            String name1 = "Bob";
            String name2 = "Bob";
            Console.WriteLine(name1 == name2);

            // p 141 logical operators
            int temp = 76;
            String skyColor = "blue";

            if (skyColor == "blue" && temp > 74) {
                Console.WriteLine("blue and above 74");
            }

            // p. 143 nested if - traggic light
            // simple r, y, g
            // yellow light rules: dist <20 yards, go
            string choice = "y";
            while (choice == "y") {
                Console.WriteLine("light color? (r,y,g): ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r") {
                    Console.WriteLine("Stop!");
                }
                else if (lightColor == "y") {
                    Console.Write("distance to light (yards)?");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist < 20) {
                        msg = ("Go!");
                    }
                    else if (dist < 30) {
                        msg = "Go, but hurry! Speed up!";
                    }
                    else {
                        msg = "slow down";
                    }
                    Console.WriteLine(msg);
                }
                else if (lightColor == "g") {
                    Console.WriteLine("Go!");
                }
                else { Console.WriteLine("Invalid light color: " + lightColor); }

                Console.Write("continue?");
                choice = Console.ReadLine();
            }

            // swith statement
            // CRUD operations
            Console.WriteLine("Movie tbale - which action to perform?");
            string action = "";
            while (action != "exit") {
                Console.WriteLine("Menu:");
                Console.WriteLine("============");
                Console.WriteLine("Get : Get all Movies");
                Console.WriteLine("GID : Get Movie By ID");
                Console.WriteLine("Add : Add Movie");
                Console.WriteLine("UpD : Update Movie");
                Console.WriteLine("Del : Delete Movie");
                Console.WriteLine("Exit : Exit");
                Console.WriteLine("Action: ");
                action = Console.ReadLine().ToLower();

                switch (action) {
                    case "get":
                        Console.WriteLine("Get was selected");
                        break;
                    case "gid":
                        Console.WriteLine("GID was selected");
                        break;
                    case "add":
                        Console.WriteLine("Add was selected");
                        break;
                    case "upd":
                        Console.WriteLine("UpD was selected");
                        break;
                    case "del":
                        Console.WriteLine("Del was selected");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }
            }

            // p. 147 case w/ operators
            // customer type: discountPct
            // R - 10%
            // C - 20%
            // else - 0%

            string custType = "R";
            decimal discPct = 0.0m;

            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => .0m
            };
            Console.WriteLine("discPct =" + discPct);

            // P. 151 conditional expression / tenary op
            // day of week: weekday/weekend conversion
            // day is 1-5: weekday, 6, or 7, weekend
            int dow = 4;
            //string msg = "";
            // if (dow < +5) {
            // msg = "weekDay";
            // }
            //  else {
            //   msg = "weekend";
            //} 
            string msg2 = (dow <= 5) ? "weekday" : "weekend";

            Console.WriteLine(msg2);
            //p. 155
            // while loop, coutner and sum
            int i = 0;
            int sum = 0;
            // sum all values from 0-10
            while (i <= 10) {
                sum += i;
                i++;

            }
            Console.WriteLine("sum = " + sum);

            // while loop for data validation
            bool succes = false;
            int month = 0;
            // promt user for month until they enter a valid month
            while (!succes) {
                Console.WriteLine("Enter month #: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12) {
                    Console.WriteLine("Invalid month # try again.");
                }
                else { succes = true; }
            }
            Console.WriteLine("Month entered: " + month);

            // while true
            // loop until even number is entered
            while (true) {
                Console.WriteLine("In a while true loop...");
                Console.WriteLine("Enter an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0) {
                    break;
                }

            }

            // p. 157 for loops
            // sum 0 to 10 w/ for loop
            sum = 0;
            string numberStr = " ";
            for (i = 0; i <= 10; i++) {
                sum += i;
                numberStr += i + " ";
            }
            Console.WriteLine(numberStr);
            Console.WriteLine("sum = " + sum);

            // count 0 to 100 by 5
            for (i = 0; i <= 100; i += 5) {
                Console.WriteLine("i:" + i);
            }

            // count 99 - 0 by 3
            for (i = 99; i >= 0; i -= 3) {
                Console.WriteLine("i:" + i);
            }







            Console.WriteLine("Bye");


        }
    }
}