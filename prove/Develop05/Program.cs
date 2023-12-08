using System;
using System.Collections.Generic;

// Base class for goals
public class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    // Constructor
    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    // RecordEvent method (to be overridden by derived classes)
    public virtual int RecordEvent()
    {
        Console.WriteLine($"Event recorded for {Name} - You earned {Points} points!");
        return Points;
    }

    // IsComplete method (to be overridden by derived classes)
    public virtual bool IsComplete()
    {
        return false;
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"{Name}: {Description} - Points: {Points}");
    }
}

// Derived class for Eternal Goals
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // Override IsComplete method
    public override bool IsComplete()
    {
        // Eternal goals are never complete
        return false;
    }
}

// Derived class for Checklist Goals
public class ChecklistGoal : Goal
{
    private int completionCount;
    private int bonusPoints;
    private int targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
    }

    // Override RecordEvent method
    public override int RecordEvent()
    {
        completionCount++;

        if (completionCount == targetCount)
        {
            Console.WriteLine($"Congratulations! Checklist goal {Name} completed - Bonus: {bonusPoints} points!");
            return Points + bonusPoints;
        }

        Console.WriteLine($"Event recorded for {Name} - You earned {Points} points!");
        return Points;
    }

    // Override IsComplete method
    public override bool IsComplete()
    {
        return completionCount >= targetCount;
    }

    // Override Display method
    public new void Display()
    {
        Console.WriteLine($"{Name}: {Description} - Points: {Points} - Completed {completionCount}/{targetCount} times");
    }
}

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int userPoints = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine($"You have {userPoints} points");
            Console.WriteLine("Menu Options:\n1. Create a New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;

                case "2":
                    ListGoals();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new Goal(name, description, points));
                break;

            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }
    }

    static void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        // Implement saving goals to a file (you can use serialization or any other method)
        // For simplicity, we'll just print them to the console in this example
        Console.WriteLine($"Goals saved to {fileName}.txt");
    }

    static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        // Implement loading goals from a file (you can use deserialization or any other method)
        // For simplicity, we'll just print a message in this example
        Console.WriteLine($"Goals loaded from {fileName}.txt");
    }

    static void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].Display();
        }

        Console.Write("What goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            userPoints += goals[goalIndex].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}

































// using System;


// class Program
// {
//     static void Main(string[] args)
//     {
//         int userOption; // Variable to store user option.

//         do
//         {
//             // MENU 
//             Console.WriteLine("You have 0 points\n");
//             Console.WriteLine("Menu Options:");
//             Console.WriteLine("  1. Create a New Goal");
//             Console.WriteLine("  2. List Goals");
//             Console.WriteLine("  3. Save Goals");
//             Console.WriteLine("  4. Quit");
//             Console.WriteLine("  5. Record Event");
//             Console.WriteLine("  6. Quit");
//             Console.Write("Select a choice from the menu: ");
//             userOption = int.Parse(Console.ReadLine());

//             // Reminder: The conditional switch case is a structure that evaluates more than one case and is characterized by selecting one option among several until the corresponding case is found.
//             //             Activity selectedActivity = null;
//             //             switch (userOption)
//             //             {
//             //                 case 1:
//             //                     selectedActivity = new BreathingActivity();
//             //                     break;
//             //                 case 2:
//             //                     selectedActivity = new ReflectingActivity();
//             //                     break;
//             //                 case 3:
//             //                     selectedActivity = new ListingActivity();
//             //                     break;
//             //             }

// //             // Run the activity if a valid option was selected
// //             if (selectedActivity != null)
// //             {
// //                 selectedActivity.RunActivity();
// //             }
// //         }
// //         while (userOption != 4); // Repeat until the user selects the exit option
// //     }
// // }

