using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Lista - almacenar las metas del usuario
        List<Goal> goals = new List<Goal>();

        // Puntos del usuario
        int userPoints = 0;

        while (true)
        {
            Console.WriteLine($"You have {userPoints} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal(goals);
                    break;
                case 2:
                    ListGoals(goals);
                    break;
                case 3:
                    SaveGoals(goals, ref userPoints);
                    break;
                case 4:
                    LoadGoals(goals, ref userPoints);
                    break;
                case 5:
                    RecordEvent(goals, ref userPoints);
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Método - crear una nueva meta
    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (goalType)
        {
            case 1:
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be completed for bonus points? ");
                int targetCount = Convert.ToInt32(Console.ReadLine());

                Console.Write("How many bonus points are awarded upon completion of the checklist goal? ");
                int bonusPoints = Convert.ToInt32(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    // Método - listar las metas actuales
    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Your current goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            // El método DisplayGoal - toma un parámetro adicional que indica si la meta está completada
            goals[i].DisplayGoal(i + 1, goals[i].IsComplete());
        }
    }

    // Método - guardar las metas en un archivo txt --- CAMBIE AQUI
    static void SaveGoals(List<Goal> goals, ref int userPoints)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter($"{fileName}.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"UserPoints:{userPoints}");
        }

        Console.WriteLine("Goals saved successfully!");
    }

    // Método para cargar metas desde un archivo txt / CAMBIE AQUI
    static void LoadGoals(List<Goal> goals, ref int userPoints)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines($"{fileName}.txt");

            goals.Clear();

            foreach (string line in lines)
            {
                if (line.StartsWith("UserPoints:"))
                {
                    userPoints = int.Parse(line.Substring("UserPoints:".Length));
                }
                else
                {
                    Goal loadedGoal = Goal.CreateFromString(line);
                    if (loadedGoal != null)
                    {
                        goals.Add(loadedGoal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{fileName}.txt' not found.");
        }
    }


    // Método - registrar un evento y ganar puntos
    static void RecordEvent(List<Goal> goals, ref int userPoints)
    {
        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].ToString()}");
        }

        Console.Write("Enter the number of the goal: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine());

        if (goalNumber >= 1 && goalNumber <= goals.Count)
        {
            // Obtener la meta seleccionada
            Goal selectedGoal = goals[goalNumber - 1];

            // Registrar la meta y mostrar puntos
            userPoints += selectedGoal.RecordEvent();

            Console.WriteLine($"You now have {userPoints} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}
