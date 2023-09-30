using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string name = Promptname();
        int number = PromptUserNumber();

        int squared = SquareNumber(number);

        DisplayResult(name, squared);
    }

    static void DisplayWelcomeMessage() //void se utiliza cuando la funcion debe devolver algo
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Promptname() //void aqui no se usa porque la funcion debe devolver algo
    {
        Console.Write("Please enter your name: "); //solo uso Write para que me salga la opcion de a;adir respuesta en la misma linea
        //si pongo write line, el input quedaria en la sioguiente linea
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square) //mis resultados deben estar dentro de una funcion tambien
    {
        Console.Write($"{name}, the square of your number is {square}");
    }
}



