using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Test the program
        Player player = new Player("John");

        // Create goals
        SimpleGoal simpleGoal = new SimpleGoal("Run a marathon", 1000);
        EternalGoal eternalGoal = new EternalGoal("Read scriptures", 100);
        ChecklistGoal checklistGoal = new ChecklistGoal("Attend the temple", 50, 10, 500);

        // Add goals to player
        player.AddGoal(simpleGoal);
        player.AddGoal(eternalGoal);
        player.AddGoal(checklistGoal);

        // Record events
        player.RecordEvent(simpleGoal);
        player.RecordEvent(eternalGoal);
        player.RecordEvent(checklistGoal);

        // Display player's score and goals
        player.DisplayScore();
        player.DisplayGoals();

        // Save and load player's progress
        player.SaveProgress("save.txt");
        player.LoadProgress("save.txt");

        // Display player's score and goals after loading
        player.DisplayScore();
        player.DisplayGoals();
    }
}