using System;
using System.Diagnostics.Metrics;

public class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;

    public static void AddTask()
    {
        Console.WriteLine("How many tasks you want? (max 10).");
        int numOfTasks = int.Parse(Console.ReadLine());
        if (numOfTasks == 0 || numOfTasks + taskCount > 10)
        {
            Console.WriteLine("Invalid number of tasks.");
        }
        else
        {
            for (int i = 0; i < numOfTasks; i++)
            {
                Console.Write("Enter task " + (taskCount + 1) + ". ");
                tasks[taskCount] = Console.ReadLine();
                taskCount++;
            }
        }
    }

    public static void ViewList()
    {
        if (taskCount == 0)
        {
            Console.WriteLine("Empty list.");

        }
        else
        {
            Console.WriteLine("Your tasks are:");
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i]);
            }
        }

    }

    public static void CompleteTask()
    {
        ViewList();
        if (taskCount == 0)
        {
            return;
        }
        else
        {
            Console.WriteLine("Enter the number of the task to mark as complete:");
            int taskNumber = int.Parse(Console.ReadLine()) - 1;
            string status = " (completed)";

            if (taskNumber >= 0 && taskNumber < taskCount)
            {
                if (tasks[taskNumber].Contains(status))
                    Console.WriteLine("Task already completed.");
                else
                {
                    tasks[taskNumber] = tasks[taskNumber] + status;
                }
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }

    public static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWhat would you like to do? \n1. Add a task \n2. View  list \n3. Mark a task as complete \n4. Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewList();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}