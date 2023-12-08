class Outdoor : Event // clase derivada de Event
{
    private string _weatherStatement;

    public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this._weatherStatement = weatherStatement;
    }

    public override string EventFullDetails()
    {
        return $"{base.EventFullDetails()}\nEvent type: Outdoor gathering\nWeather: {_weatherStatement}";
    }

    public override string EventShortDescription()
    {
        return $"Event type: Outdoor gathering\nTitle: {GetTitle()}\nDate: {GetDate().ToShortDateString()}";
    }
}


