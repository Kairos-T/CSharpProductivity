using System;

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();
        DecisionMaker decisionMaker = new DecisionMaker();

        while (true)
        {
            Console.WriteLine("Main Menu\n==========");
            Console.WriteLine("1. To-Do List");
            Console.WriteLine("2. Decision Maker");
            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option: ");

            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    TodoListMenu(todoList);
                    break;

                case 2:
                    DecisionMakerMenu(decisionMaker);
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }

    static void TodoListMenu(TodoList todoList)
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do List\n");
            Console.WriteLine("Task Menu\n==========");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Select an option: ");

            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice! Try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter task to add: ");
                    string task = Console.ReadLine();
                    todoList.AddTask(task);
                    Console.WriteLine("");
                    break;

                case 2:
                    todoList.DisplayTasks();
                    break;

                case 3:
                    if  (todoList.tasks.Count == 0)
                    {
                      Console.WriteLine("\nNo tasks to remove.\n");
                      break;
                    }
              
                    todoList.DisplayTasks();
                    Console.Write("\nChoose a Task to Remove: ");
                    if (int.TryParse(Console.ReadLine(), out int taskIndex))
                    {
                        todoList.RemoveTask(taskIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid format! Please enter only the task number.");
                    }
                    break;

                case 0:
                    Console.WriteLine("");
                    return;

                default:
                    Console.WriteLine("Invalid Option!\n");
                    break;
            }
        }
    }

    static void DecisionMakerMenu(DecisionMaker decisionMaker)
    {
      Console.WriteLine("\nDecision Maker\n");

        while (true)
        {
            Console.Write("Enter an option (or 0 to generate a decision): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                string decision = decisionMaker.GenerateDecision();
                Console.WriteLine($"Decision: {decision}\n");
                break;
            }
            else
            {
                decisionMaker.AddOption(input);
            }
        }
    }
}
