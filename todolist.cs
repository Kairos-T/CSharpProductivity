using System;
using System.Collections.Generic;

class TodoList
{
    public List<string> tasks;

    public TodoList()
    {
        tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        tasks.Add(task);
    }

    public void DisplayTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("\nNo tasks to display.\n");
            return;
        }

        Console.WriteLine("\nTasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{tasks[i]}");
        }
        Console.WriteLine("");
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task removed.\n");
        }
        else
        {
            Console.WriteLine("Invalid task number!\n");
        }
    }
}

