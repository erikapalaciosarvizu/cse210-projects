class ReflectingActivity : Activity
{
    private string[] _randomPrompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 60)
    {
    }

    public override void RunActivity()
    {
        base.RunActivity();

        string prompt = _randomPrompts[_random.Next(_randomPrompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        Console.WriteLine("You begin in:");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        for (int i = 0; i < 2; i++)
        {
            string question = _questions[_random.Next(_questions.Length)];
            Console.WriteLine(question);
            PauseWithSpinner(10);
        }

        DisplayEndingMessage();
    }
}
