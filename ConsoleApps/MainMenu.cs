using ConsoleApps.OOP;
using ConsoleApps.OOP.AbstractionInheritancePolymorphism;
using ConsoleApps.OOP.Encapsulation;
using ConsoleApps.Tasks;
using System;

namespace ConsoleApps
{
    class MainMenu
    {
        internal static bool HandleMainMenu()
        {
            Utils.CleanUpConsole();
            ShowMenu();
            int userChoice = Utils.GetUserInput();

            switch (userChoice)
            {
                case 1:
                    FizzBuzz.PlayFizzBuzz();
                    break;
                case 2:
                    Calculator.RunCalculator();
                    break;
                case 3:
                    GuessingGame.RunGuessingGame();
                    break;
                case 4:
                    if (Utils.AskToConfirm("NOTE: This To-Do List app will create a text file on your Desktop to store your tasks" +
                        "\nDo you wish to proceed?"))
                    {
                        ToDoList.RunToDoList();
                    }
                    break;
                //case 5:
                //    OOPMenu.RunOOPMenu();
                //    break;
                case 5:
                    Bank bank = new Bank();
                    break;
                case 6:
                    Animals.Act();
                    break;
                case 7:
                    return false;
                default:
                    Console.WriteLine("Selected option doesn't match any of the options above");
                    Console.WriteLine("Press any key and try again...\n");
                    Console.ReadKey(true);
                    break;
            }

            return true;
        }
        static void ShowMenu()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("This application demonstrates my programming skills");
            Console.WriteLine("Enter the number corresponding to the task and press Enter to run it");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Interactive Examples:");
            Console.WriteLine("1 - FizzBuzz");
            Console.WriteLine("2 - Calculator");
            Console.WriteLine("3 - Guess the Number");
            Console.WriteLine("4 - To-Do List Manager");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Examples demonstrating Object-Oriented Programming concepts:");
            Console.WriteLine("5 - Encapsulation");
            Console.WriteLine("6 - Abstraction, Inheritance & Polymorphism");

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("7 - Exit the Application\n");
        }
    }
}