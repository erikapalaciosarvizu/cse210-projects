using System;

class Program
{
    static void Main(string[] args)
    {

        Random oli = new Random();
        int magicNumber = oli.Next(1, 101);

        int guess = 0;
        int guesses_made = 0;

        while (guess != magicNumber)
        {
            guesses_made = guesses_made + 1;
            Console.Write("What is your guess? ");
            string useranswer = Console.ReadLine();
            int number = int.Parse(useranswer);
            guess = number; //guess va a tomar el valor de number
            /*guess = int.Parse(Console.ReadLine());*/

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {guesses_made} guesses!");
                Console.Write("Do you want to play again? (yes/no) ");
                string echale = Console.ReadLine();
                if (echale.ToLower() == "yes")
                {
                    Console.WriteLine("Okis");

                    guess = 0;  //Para reiniciar el juego debo reestablecer las variables que intervienen en el while principal.
                    guesses_made = 0;
                    magicNumber = oli.Next(1, 101); //El .next generó un nuevo valor random del 1 al 100

                }

                else
                {
                    Console.WriteLine("Bueno bais.");
                }
            }
        }
    }
}


