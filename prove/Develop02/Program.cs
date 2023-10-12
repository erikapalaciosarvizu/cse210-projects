using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        DisplayWelcomeMessage(); //

        Random rnd = new Random();

        string chosenOption = "0";
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            chosenOption = Console.ReadLine();
            int number = int.Parse(chosenOption);
            if (chosenOption == "1")
            {
                journal.AddEntry();
                //Console.WriteLine("1. Write");
            }
            if (chosenOption == "2")
            {
                journal.displayEntries();
                //Console.WriteLine("1. Write");
            }
            if (chosenOption == "3")
            {
                Console.WriteLine("Insert name of the file: ");
                string name = Console.ReadLine();
                journal.loadFile(name);
            }
            if (chosenOption == "4")
            {
                Console.WriteLine("Insert name of the file: ");
                string file_name = Console.ReadLine();
                journal.saveFile(file_name);
            }
        }
        while (chosenOption != "5");
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }
}