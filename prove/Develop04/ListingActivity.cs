class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60)
    {
    }

    public override void RunActivity()
    {
        base.RunActivity();

        string prompt = _prompts[_random.Next(_prompts.Length)];
        Console.WriteLine(prompt);
        Countdown(5);
        Console.WriteLine("Start listing items now:");

        int itemCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable) // Verifica si hay entrada del usuario
            {
                Console.ReadLine();
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items!");
        DisplayEndingMessage();
    }
}

