class Reception : Event //class derived from Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    public override string EventFullDetails()//from event
    {
        return $"{base.EventFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string EventShortDescription()
    {
        return $"Event type: Reception\nTitle: {GetTitle()}\nDate: {GetDate().ToShortDateString()}";
    }
}

