class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 60)
    {
    }

    public override void RunActivity()
    {
        base.RunActivity();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(5);
            Console.WriteLine("Now breathe out...\n");
            Countdown(5);
        }

        DisplayEndingMessage();
    }
}


