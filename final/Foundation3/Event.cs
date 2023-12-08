// Base Event class
class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    // // Method- generate standard details for an event
    public string EventStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    //method - full details for an event
    public virtual string EventFullDetails()
    {
        return EventStandardDetails();
    }

    //method - generate short description for an event
    public virtual string EventShortDescription()
    {
        return $"Event type: Lecture\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}