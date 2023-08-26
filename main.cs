using System;
using System.Collections.Generic;

class Program {
  static void Main (string[] args) {

    while (true)
    {
      Console.WriteLine("Main Menu\n==========");
      Console.WriteLine("1. To-Do List");
      Console.WriteLine("2. Decision Maker");
      Console.WriteLine("0. Exit");
      Console.Write("\nSelect an option: ");

      int choice;

      if (!int.TryParse(Console.ReadLine(), out choice)) // TryParse is an inbuilt method to attempt to convert str to int. `out` parameter used to store converted integer if conversion is successful
      {
        Console.WriteLine("Invalid input! Please try again.");
        continue; // Skip rest of loop, start over
        
      }
      
      switch (choice)
      {
        case 1:
          TodoList();
          break;

        case 2:
          DecisionMaker();
          break;

        case 0:  
          return;
        
        default:
          Console.WriteLine("Invalid Choice!");
          break;
      }
    }
  }      
  
  static void TodoList()
  {
    Console.WriteLine("\nTo-Do List\n");
    
    List<string> tasks = new List<string>(); // List to store tasks
    
    while (true){
      Console.WriteLine("Task Menu\n==========");

      Console.WriteLine("1. Add Task");
      Console.WriteLine("2. View Tasks");
      Console.WriteLine("3. Remove/Complete Tasks");
      Console.WriteLine("0. Back to Main Menu");
      Console.Write("Select an option: ");

      int choice; 
      if (!int.TryParse(Console.ReadLine(), out choice))
      {
        Console.WriteLine("Invalid choice! Try again. ");
        continue;
      }      

      switch (choice)
      {
      case 1:
        Console.Write("\nEnter task to add: ");
        string task  = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("");
        break;

      case 2:

        if (tasks.Count == 0) {
          Console.WriteLine("\nNo tasks to display.\n");
          break;
          }

        Console.WriteLine("\nTasks:");

        int index = 1;
        foreach (string item in tasks)
          {
            Console.WriteLine($"{index}.{item}");
            index++;
          }
        Console.WriteLine("");
        break;

      case 3:
        if (tasks.Count == 0) {
          Console.WriteLine("\nNo tasks to display.\n");
          break;
          }
        
        int i = 1;
        foreach (string item in tasks)
          {
            Console.WriteLine($"{i}.{item}");
            i++;
          }
        Console.Write("\nChoose a Task to Remove/Mark as Complete: ");

        int taskIndex;

        if (!int.TryParse(Console.ReadLine(), out taskIndex))
        {
          Console.WriteLine("Invalid format! Please enter only the task number.");
          continue;
          }
        
        taskIndex -= 1;

        if (taskIndex < tasks.Count && taskIndex >= 0)
        {
          tasks.RemoveAt(taskIndex);
          Console.WriteLine("Task removed.\n");
        }
        else
        {
          Console.WriteLine("Invalid task number!\n");
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

    static void DecisionMaker()
  {
    Console.WriteLine("\nDecision Maker\n");
    List<string> options = new List<string>();

    while(true)
    {
      Console.Write("Enter an option (or 0 to generate a decision): ");
      string input = Console.ReadLine();

      if (input == "0")
      {
        if (options.Count == 0)
        {
          Console.WriteLine("No options entered.");
        }

        else 
        {
          Random random = new Random(); // Creates instance of random class
        int randomIndex = random.Next(0, options.Count); // Next method generates random integer within range
        string selected = options[randomIndex];

        Console.WriteLine($"Decision: {selected}\n");
        break;
        }
      }

      else
      {
        options.Add(input);
        Console.WriteLine("Option added.");
      }
    }
  }
}
