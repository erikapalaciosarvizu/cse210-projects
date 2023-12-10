public class SimpleGoal : Goal
{
    // Constructor 
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // método RecordEvent para SimpleGoal
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    // método IsComplete para SimpleGoal
    public override bool IsComplete()
    {
        return false;
    }
}