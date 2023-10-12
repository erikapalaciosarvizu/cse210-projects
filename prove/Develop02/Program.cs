using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        //journal es un objeto que pertenece a la clase Journal// este objeto tiene sus propiedades y sus metodos 
        Journal journal = new Journal(); //Creación de objeto tipo journal. Variable/objeto de tipo Journal // Iniciacion de variable/objeto tipo Journal.
                                         //INSTANCIAR UNA CLASE (Cada que vea la palabra reservada new lo que estoy haciendo es una instancia/Ejemplarizacion)
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
            }
            if (chosenOption == "2")
            {
                journal.DisplayEntries();
            }
            if (chosenOption == "3")
            {
                Console.WriteLine("Insert name of the file: ");
                string name = Console.ReadLine();
                journal.LoadFile(name);
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