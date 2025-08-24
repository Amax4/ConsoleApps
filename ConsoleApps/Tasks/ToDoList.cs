namespace ConsoleApps.Tasks
{
    internal class ToDoList
    {
        static string ToDoPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "todo.txt");

        internal static void RunToDoList()
        {

            if (!File.Exists(ToDoPath))
            {
                CreateToDoOnDesktop();
            }

            bool ToDoListRunning = true;
            while (ToDoListRunning)
            {
                WorkOnToDo(ref ToDoListRunning);
            }
        }

        static void WorkOnToDo(ref bool running)
        {
            Utils.CleanUpConsole();
            ShowToDoMenu();

            int choice = Utils.GetUserInput();

            if (choice == 5)
            {
                running = false;
                return;
            }

            HandleInputLogic(choice);

            running = true;
        }

        static void CreateToDoOnDesktop()
        {
            File.WriteAllText(ToDoPath, "Become a professional programmer" + Environment.NewLine);
        }

        static void ShowToDoMenu()
        {
            Console.WriteLine("Welcome to the To-Do List!");
            Console.WriteLine("This app creates a notepad called \"ToDo\" on your desktop and let's you modify it\n");

            Console.WriteLine("Please, choose one of the following options:");
            Console.WriteLine("1 - Show list of contents");
            Console.WriteLine("2 - Add a new To-Do");
            Console.WriteLine("3 - Remove a specific To-Do");
            Console.WriteLine("5 - Go back to Main Menu\n");
        }

        static void HandleInputLogic(int chosenAction)
        {
            Utils.CleanUpConsole();

            switch (chosenAction)
            {
                case 1:
                    ShowContents(true);
                    break;
                case 2:
                    AddNewToDo();
                    break;
                case 3:
                    RemoveToDo();
                    break;
                default:
                    Utils.InformAboutError();
                    break;
            }
        }

        static void ShowContents(bool waitForInput)
        {
            Console.WriteLine("Current To-Dos in notepad:");
            string[] toDo = File.ReadAllLines(ToDoPath);
            for (int i = 0; i < toDo.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {toDo[i]}");
            }

            if (waitForInput)
            {
                Utils.WaitForAnyInput();
            }
        }

        static void AddNewToDo()
        {
            Console.WriteLine("Enter a new To-Do:");
            string? newToDo = Console.ReadLine();
            if (!string.IsNullOrEmpty(newToDo))
            {
                File.AppendAllText(ToDoPath, newToDo + Environment.NewLine);
            }
        }

        static void RemoveToDo()
        {
            Console.WriteLine("Which To-Do would you like to remove?");
            ShowContents(false);

            Console.Write("Type in a corresponding number: ");
            int indexToRemove = Utils.GetUserInput();
            indexToRemove--;

            var todos = File.ReadAllLines(ToDoPath).ToList();

            if (indexToRemove >= 0 && indexToRemove < todos.Count)
            {
                todos.RemoveAt(indexToRemove);
                File.AppendAllText(ToDoPath, Environment.NewLine);
                File.WriteAllLines(ToDoPath, todos);
            }
            else Utils.InformAboutError();
        }
    }
}