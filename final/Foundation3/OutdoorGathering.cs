public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        SetType("Outdoor Gathering");
        _weather = weather;
    }

    public string Getweather()
    {
        return _weather;
    }

    public override string FullDetails()
    {
        return "Event Type: " + GetEventType() + "\nEvent Title: " + GetTitle() + "\n" + "Event Description: " + GetDesc() + "\n" + "Date: " + GetDate() + " at " + GetTime() + "\n" + "Venue: " + GetAddressString() + "\n" + "Weather on the date of the event is expected to be " + _weather;
    }
}