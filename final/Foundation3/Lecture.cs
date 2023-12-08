class Lecture : Event  //class derived from Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string EventFullDetails() //from event
    {
        return $"{base.EventFullDetails()}\nEvent type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}