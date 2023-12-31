class Swimming : Activity
{
    private int _laps;

    // Constructor
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this._laps = laps;
    }


    // Overrides the base class methods 
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming ({_minutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}