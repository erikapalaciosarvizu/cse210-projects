class Cycling : Activity
{
    private double _speed;

    // Constructor
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this._speed = speed;
    }

    // Overrides the base class Methods.
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()//Pace
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling ({_minutes} min): Speed {_speed:F2} kph, Pace: {GetPace():F2} min per km";
    }
}