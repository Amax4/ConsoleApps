using System;

namespace ConsoleApps
{

    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                isRunning = MainMenu.HandleMainMenu();
            }

            CloseConsoleApp();
        }

        static void CloseConsoleApp()
        {
            //Console.WriteLine("Shutting down");
            //Thread.Sleep(500);

            string shutdownNoti = "Shutting down";
            foreach (char c in shutdownNoti)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
        }
    }
}