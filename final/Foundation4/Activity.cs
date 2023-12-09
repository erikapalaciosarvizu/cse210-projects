class Activity
{
    private DateTime _date;
    protected int _minutes;


    // Constructor
    public Activity(DateTime date, int minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }


    // Virtual methods
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

    // Virtual method - get a summary of the activity
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy}";
    }
}
