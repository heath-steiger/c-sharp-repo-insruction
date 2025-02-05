﻿
using System.ComponentModel.Design;
using System.Net.NetworkInformation;

namespace project5_3_demo
{
    internal class Program
    {   // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            Print("Welcome to the guessing Game!");
            Print("+++++++++++++++++++++++++++++");
            Print("");
            string choice = "y";
            Random rand = new Random();
            while (choice == "y") {
                //Play Game
                int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;
                Print("I'm thinking of a number from "+MIN_VAL+" to "+MAX_VAL+ ".\n Try to guess it.");
                //Print("** DUBUG: theNumber = " + theNumber);
                while (guess != theNumber) {
                    guess = GetNumber("\nEnter Number: ");
                    count++;
                    int diff = guess - theNumber;
                    if (diff == 0) {
                       DisplayWinnerMessage(count);                    
                    }
                    else if (diff < -10) { Print("Way too low! Guess again."); }
                    
                    else if (diff < 0) { Print("Too low! Guess again."); }
                    
                    else if (diff > 10) { Print("Way too high! Guess again."); }
                    
                    else if (diff > 0) { Print("Too high! Guess again."); }
                    
                }
                // Prompt choice
                Print("");
                choice = GetRequiredString("Try again/ (y/n)", "y", "n");
                Print("");
            }






            Print("Bye - come back soon!");
        }

        static void DisplayWinnerMessage(int count)
        {
            Print("You got it in " + count + " tries.");
            if (count <= 3) { Print("Great work! You are a mathematical wizard."); }
            else if (count <= 7) { Print("Not too bad! You've got some potential."); }
            else { Print("What took you so long? Maybe you should take some lessons"); }
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                nbr = Int32.Parse(Console.ReadLine());
                if (nbr >= 1 && nbr <= 100) {
                    success = true;
                }
                else {
                    Print("Error - entry must be between " +MIN_VAL+" and "+MAX_VAL+".");
                }
            }

            return nbr;
        }
        static string GetRequiredString(string prompt, string val1, string val2)
        {
            string str = "";
            while (true) {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "") {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2) {
                    Print("Erorr - entry must be either " + val1 + " or " + val2);
                }
                else {
                    break;
                }
            }
            return str;
        }


    }
}
