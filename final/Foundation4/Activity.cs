class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy}";
    }
}
