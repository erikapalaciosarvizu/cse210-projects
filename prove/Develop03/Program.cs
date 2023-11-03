using System;
using System.Collections.Generic;

public class Program
{
    static List<Scripture> scriptures = new List<Scripture>
    {
        new Scripture(new Reference("Alma", 32, 21), "And now as I said concerning faith, faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all fine heart; and read not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        new Scripture(new Reference("Moroni", 10, 23), "And Christ truly said unto our fathers: If ye have faith ye can do all things which are expedient unto me."),
        new Scripture(new Reference("D&C", 39, 22), "And he that receiveth these things receiveth me, and they shall be gathered unto me in time and in eternity."),
        new Scripture(new Reference("D&C", 61, 39), "Pray always that you enter not into temptation, that you may abide the day of his coming, whether in life or in death. Even so. Amen")
    };

    public static void Main(string[] args)
    {
        Console.WriteLine("Time to Memorize!");

        var scriptureRandom = ChooseRandomScripture(); //This chooses a random scripture from the list above.
        DisplayScripture(scriptureRandom); //This WILL show the random scripture in the console.

        while (!scriptureRandom.IsCompletelyHidden()) //My loop will run as long as NOT ALL WORD in the script are hidden.
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine(); // Here the user can write the word quit.

            if (input.ToLower() == "quit")//USED THE .ToLower() SO THAT THE USER CAN WRITE IN UPPERCASE OR LOWERCASE WITHOUT PROBLEMS, IMPORTANT-DON'T FORGET!
            {
                return;
            }

            scriptureRandom.HideWords(); // This calls the "HideWords" method of the Scripture class- will hide a random word.
            DisplayScripture(scriptureRandom); //This redisplays the scripture in the console, with the word that was just hidden.
        }

    }

    public static Scripture ChooseRandomScripture()//This chooses a random scripture from the scriptures list.
    {
        Random rand = new Random();
        int index = rand.Next(scriptures.Count);//This generates a random number between 0 and the number of elements in the scriptures list.
        return scriptures[index];//returns the element at position index of the scriptures list.
    }

    public static void DisplayScripture(Scripture scripture) //This displays a scripture in the console.
    {
        Console.Clear();
        Console.WriteLine(scripture.GetRenderedText()); //calls the method and writes in the console.
    }
}
