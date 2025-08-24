namespace ConsoleApps.Tasks
{
    internal class Calculator
    {
        internal static void RunCalculator()
        {
            bool calcRunning = true;
            while (calcRunning)
            {
                CalculateForUser(ref calcRunning);
            }
        }
        static void CalculateForUser(ref bool calcRunning)
        {
            Utils.CleanUpConsole();
            ShowCalculatorIntro();

            int userChoice = Utils.GetUserInput();

            if (userChoice == 5)
            {
                calcRunning = false;
                return;
            }
            else if (userChoice > 5 || userChoice < 1)
            {
                Utils.InformAboutError();
                return;
            }

            Utils.CleanUpConsole();

            Console.Write("Enter the first number: ");
            float num1 = GetCalcInput();

            Console.Write("Enter the second number: ");
            float num2 = GetCalcInput();

            float? result = Calculate(userChoice, num1, num2);

            if (result.HasValue) Console.WriteLine($"The result is: {result}");

            calcRunning = Utils.AskToConfirm("Would you like to calculate the next operation?");
        }

        static void ShowCalculatorIntro()
        {
            Console.WriteLine("Welcome to the calculator app, here are the rules:");
            Console.WriteLine("1. The user selects the operation: addition, subtraction, multiplication, division");
            Console.WriteLine("2. User enters two numbers");
            Console.WriteLine("3. The program returns the result\n");

            Console.WriteLine("Select the number corresponding to the operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Close calculator\n");
        }

        static float GetCalcInput()
        {
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out float ParseOutput))
                {
                    return ParseOutput;
                }

                Console.WriteLine("Invalid value entered");
                Console.Write("Please enter a number: ");
            }
        }

        static float? Calculate(int userChoice, float num1, float num2)
        {
            switch (userChoice)
            {
                case 1: return num1 + num2;
                case 2: return num1 - num2;
                case 3: return num1 * num2;
                case 4:
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("You can't divide by zero!");
                        return null;
                    }
                default:
                    Console.WriteLine("Invalid value entered");
                    return null;
            }
        }
    }
}