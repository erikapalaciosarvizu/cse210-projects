using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numbertyped = -1;
        while (numbertyped != 0)
        {
            Console.Write("Enter a list of numbers, type '0' when finished. ");

            string response = Console.ReadLine();
            numbertyped = int.Parse(response);


            if (numbertyped != 0)
            {
                numbers.Add(numbertyped);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxnumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxnumber)
            {
                maxnumber = number;
            }
        }
        Console.WriteLine($"The max is {maxnumber}");

    }
}