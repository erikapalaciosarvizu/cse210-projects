using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int userOption; // Variable to store user option.

        do
        {
            // MENU 
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = int.Parse(Console.ReadLine());

            // Reminder: The conditional switch case is a structure that evaluates more than one case and is characterized by selecting one option among several until the corresponding case is found.
            Activity selectedActivity = null;
            switch (userOption)
            {
                case 1:
                    selectedActivity = new BreathingActivity();
                    break;
                case 2:
                    selectedActivity = new ReflectingActivity();
                    break;
                case 3:
                    selectedActivity = new ListingActivity();
                    break;
            }

            // Run the activity if a valid option was selected
            if (selectedActivity != null)
            {
                selectedActivity.RunActivity();
            }
        }
        while (userOption != 4); // Repeat until the user selects the exit option
    }
}