﻿namespace ConsoleLibrary
{
    public class MyConsole
    {
        public static int PromptInt(string prompt)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (int.TryParse(Console.ReadLine(), out result)) {
                    isValid = true;
                }
                else {
                    PrintLine("Error - invalid int. ");
                }
            }

            return result;
        }

        public static int PromptInt(string message, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                result = PromptInt(message);
                if (result >= min && result <= max) {
                    isValid = true;
                }
                else { PrintLine("Error - string must be between " + min + " or " + max); }

            }
                return result;
        }

            public static string PromptString(string prompt)
            {
                Print(prompt);
                return Console.ReadLine();
            }

            public static string PromptReqString(string prompt, string str1, string str2)
            {
                string result = " ";
                bool isValid = false;
                while (!isValid) {
                    result = PromptString(prompt);
                    if (result.Trim() != " ") {
                        if (result == str1 || result == str2) {
                            isValid = true;
                        }
                        else {
                            PrintLine("Error - string must be either " + str1 + " or " + str2);
                        }
                    }
                    else {
                        PrintLine("Error - entry is required.");
                    }
                }
                return result;
            }

            public static void PrintLine(string msg)
            {
                Console.WriteLine(msg);
            }
            public static void Print(string msg)
            {
                Console.Write(msg);
            }
        
    }
}

