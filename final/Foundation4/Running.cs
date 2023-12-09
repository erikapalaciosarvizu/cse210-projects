class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()//Distance 
    {
        return distance;
    }

    public override double GetSpeed()//Speed
    {
        return (distance / _minutes) * 60;
    }

    public override double GetPace()//Pace
    {
        return _minutes / distance;
    }

    public override string GetSummary()
    {
        double distanceInKilometers = GetDistance();

        return $"{base.GetSummary()} - Running ({_minutes} min): Distance {distanceInKilometers:F2} km, Speed {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}