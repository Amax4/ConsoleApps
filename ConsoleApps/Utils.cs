using System;
using ConsoleApps;

namespace ConsoleApps
{
    class Utils
    {
        public static void CleanUpConsole()
        {
            Console.Clear();
        }

        public static int GetUserInput()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Use only whole numbers");
                }
            }
        }

        public static bool AskToConfirm(string questionContent)
        {
            Console.WriteLine(questionContent);
            Console.WriteLine("y - Yes");
            Console.WriteLine("n = No\n");

            while (true)
            {
                string? input = Console.ReadLine();
                input = input?.ToLower();

                if (input == "t" || input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }

                Console.WriteLine("Please try again");
            }
        }

        public static void InformAboutError()
        {
            Console.WriteLine("\nSomething went wrong");
            Console.WriteLine("Please make sure to select a correct option");
            Console.WriteLine("Press any key to try again...");
            Console.ReadKey(true);
        }

        public static void WaitForAnyInput()
        {
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey(true);
        }
    }
}