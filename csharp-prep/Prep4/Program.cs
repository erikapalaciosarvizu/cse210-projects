using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //declarar una lista (coleccion de tipo lista)

        Console.WriteLine("Enter a list of numbers, type '0' when finished: ");

        int element = 1; //da igual el valor en el que la inicie

        while (element != 0) //mientras element sea diferente a cero, debe agregar elemntor uno tras otro.
        {
            element = Int32.Parse(Console.ReadLine()); //lo que el usuario introduzca por consola.
            numbers.Add(element); //le digo que agregue a la coleccion el elemento introducido.
            //Estaremos en un bulce infinito hasta que el usuario escriba 0
        }

        //numbers.RemoveAt sirve para no almacenar el cero que es el numero que utilizamos para salir, el ultimo numero de la lista
        numbers.RemoveAt(numbers.Count - 1); //.Count es para que nos diga cuantos elementos tiene mi lista pero todo iniciando con un indice cero
        //por eso le decimos que sea count-1 : por ejemplo si tengo 27 cosas en mi lista con el 0 incluido, eliminara el 26

        int sum = 0;
        foreach (int number in numbers) //int (declaramos dentro del foreach una variable de tipo entero a la cual puede llamar como quieras) in numbers)
        //por cada elemento que haya en la coleccion numbers:
        {
            sum += number; //suma los elementos
        }
        Console.WriteLine($"The sum is {sum}");

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
        Console.WriteLine($"The max number is: {maxnumber}");


    }
}


