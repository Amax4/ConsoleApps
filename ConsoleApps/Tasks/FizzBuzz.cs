namespace ConsoleApps.Tasks
{
    internal class FizzBuzz
    {
        static readonly int[] fizzBuzzLengths = { 10, 50, 100 };

        internal static void PlayFizzBuzz()
        {
            bool FizzBuzzRunning = true;
            while (FizzBuzzRunning)
            {
                FizzBuzzLogic(ref FizzBuzzRunning);
            }
        }

        private static void FizzBuzzLogic(ref bool running)
        {
            Utils.CleanUpConsole();
            ShowFizzBuzzIntro();

            int userInput = Utils.GetUserInput();

            if (userInput == 5)
            {
                running = false;
                return;
            }

            HandlePlayerInputLogic(userInput);
            running = Utils.AskToConfirm("\nShowcase FizzBuzz again?");
        }

        private static void ShowFizzBuzzIntro()
        {
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("This app is commonly used as a programming exercise, so I decided to include it in this project.\n");

            Console.WriteLine("Quick reminder on how it works:");
            Console.WriteLine("The FizzBuzz app prints numbers to the console (usually from 1 to 100).");
            Console.WriteLine("If the number is divisible by 3, app prints \"Fizz\" instead of the number.");
            Console.WriteLine("If the number is divisible by 5, app prints \"Buzz\" instead of the number.");
            Console.WriteLine("If the number is divisible by both 3 and 5, app prints \"FizzBuzz\" instead.");
            Console.WriteLine("And if the number is divisible by neither 3 nor 5, the console just prints the number.\n");

            Console.WriteLine("For clarity purposes, you can choose one of the following number range options:");
            Console.WriteLine($"1 - Numbers from 1 to {fizzBuzzLengths[0]}");
            Console.WriteLine($"2 - Numbers from 1 to {fizzBuzzLengths[1]}");
            Console.WriteLine($"3 - Numbers from 1 to {fizzBuzzLengths[2]}");
            Console.WriteLine("4 - Numbers from 1 to a custom amount");
            Console.WriteLine("5 - Quit FizzBuzz and return to the Main Menu\n");
        }

        private static void HandlePlayerInputLogic(int input)
        {
            switch (input)
            {
                case 1:
                    TypeFizzBuzz(fizzBuzzLengths[0]);
                    break;
                case 2:
                    TypeFizzBuzz(fizzBuzzLengths[1]);
                    break;
                case 3:
                    TypeFizzBuzz(fizzBuzzLengths[2]);
                    break;
                case 4:
                    Console.WriteLine("Enter a amount:\n");
                    int customAmount = Utils.GetUserInput();
                    TypeFizzBuzz(customAmount);
                    break;
                default:
                    Utils.InformAboutError();
                    break;
            }

        }

        private static void TypeFizzBuzz(int length)
        {
            Utils.CleanUpConsole();

            for (int i = 1; i <= length; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
    }
}