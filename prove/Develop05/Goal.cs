public abstract class Goal
{
    protected string _GoalName;
    protected string _description;
    protected int _points;

    // Constructor 
    public Goal(string name, string description, int points)
    {
        this._GoalName = name;
        this._description = description;
        this._points = points;
    }

    // Método - mostrar información de la meta
    public void DisplayGoal(int goalNumber, bool isComplete)
    {
        Console.WriteLine($"{goalNumber}. [{(isComplete ? "X" : " ")}] {_GoalName} ({_description})");
    }

    // Métodos
    public abstract int RecordEvent();

    public abstract bool IsComplete();


    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_GoalName},{_description},{_points}";
    }

    public static Goal CreateFromString(string data)
    {
        string[] parts = data.Split(':');
        if (parts.Length == 2)
        {
            string[] details = parts[1].Split(',');
            if (details.Length == 3)
            {
                string _typeName = parts[0];
                string _name = details[0];
                string _description = details[1];
                int _points = int.Parse(details[2]);

                switch (_typeName)
                {
                    case nameof(SimpleGoal):
                        return new SimpleGoal(_name, _description, _points);
                    case nameof(EternalGoal):
                        return new EternalGoal(_name, _description, _points);
                    case nameof(ChecklistGoal):
                        return new ChecklistGoal(_name, _description, _points, 0, 0);
                    default:
                        Console.WriteLine($"Unknown goal type: {_typeName}");
                        break;
                }
            }
        }
        Console.WriteLine($"Invalid goal data: {data}");
        return null;
    }
}