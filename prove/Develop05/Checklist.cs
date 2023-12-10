public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _completedCount;

    // Constructor 
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        this._targetCount = targetCount;
        this._bonusPoints = bonusPoints;
        this._completedCount = 0;
    }

    // método RecordEvent para ChecklistGoal
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _completedCount++;

        // Verificar si se alcanzó el objetivo para el bonus
        if (_completedCount == _targetCount)
        {
            Console.WriteLine($"Bonus! You've completed the goal {_targetCount} times, earning an additional {_bonusPoints} points!");
            return _points + _bonusPoints;
        }

        return _points;
    }

    // método IsComplete para ChecklistGoal
    public override bool IsComplete()
    {
        return _completedCount == _targetCount;
    }
}
