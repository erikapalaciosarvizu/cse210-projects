public class EternalGoal : Goal
{
    // Constructor 
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // método RecordEvent para EternalGoal
    public override int RecordEvent()
    {
        Console.WriteLine($"You recorded progress on your eternal goal '{_GoalName}'.");
        return _points;
    }

    // método IsComplete para EternalGoal
    public override bool IsComplete()
    {
        return false;
    }
}