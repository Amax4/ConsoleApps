// using System.Security.Cryptography;

namespace ConsoleApps.Tasks
{
    internal class GuessingGame
    {
        internal static void RunGuessingGame()
        {
            bool guessGameRunning = true;

            while (guessGameRunning)
            {
                PlayGuessingGame(ref guessGameRunning);
            }
        }

        static void PlayGuessingGame(ref bool guessGameRunning)
        {
            Utils.CleanUpConsole();

            ShowGuessingGameMenu();

            if (!Utils.AskToConfirm("Start the game?"))
            {
                guessGameRunning = false;
                return;
            }

            bool playing = true;

            while (playing)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                // int randomNumber = RandomNumberGenerator.GetInt32(1, 101);

                EnterGuessingLoop(randomNumber);

                playing = Utils.AskToConfirm("Play again?");
            }

            guessGameRunning = false;
        }

        static void ShowGuessingGameMenu()
        {
            Console.WriteLine("Welcome to the Guessing Game");
            Console.WriteLine("1. The game will choose a random number between 1 and 100");
            Console.WriteLine("2. Try to guess the number by entering your guess");
            Console.WriteLine("3. After each guess, you'll be told whether the hidden number is higher, lower or equal to your guess");
            Console.WriteLine("4. The game ends once you guess the correct number\n");
        }

        static void EnterGuessingLoop(int numberToCompareTo)
        {
            Utils.CleanUpConsole();
            int attempts = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                int guessedInt = Utils.GetUserInput();
                attempts++;

                if (guessedInt < numberToCompareTo) Console.WriteLine("The number you're looking for is higher");
                else if (guessedInt > numberToCompareTo) Console.WriteLine("The number you're looking for is lower");
                else
                {
                    Console.WriteLine("Congratulations! You found the number!");
                    Console.WriteLine($"Attempts: {attempts}");
                    return;
                }
            }
        }
    }
}