class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int durationActivity)
    {
        _name = name;
        _description = description;
        _duration = durationActivity;
    }

    public virtual void RunActivity()
    {
        DisplayStartingMessage();
        PauseWithSpinner(3);
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n"); // Shows the name of the activity when selected
        Console.WriteLine($"•{_description} \n"); //Shows the description of the activity when selected
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        PauseWithSpinner(3);
    }

    public void PauseWithSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        PauseWithSpinner(3);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        PauseWithSpinner(3);
    }
}
