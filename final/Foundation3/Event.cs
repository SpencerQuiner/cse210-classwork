using System.Net.Sockets;

public abstract class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetType(string type)
    {
        _eventType = type;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDesc()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddressString()
    {
        return _address.GetAddress();
    }

    public string StandardDetails()
    {
        return "Event: " + _title + "\n" + "Event Description: " + _description + "\n" + "Date: " + _date + " at " + _time + "\n" + "Venue: " + GetAddressString() + "\n";
    }

    public string ShortDescription()
    {
        return _eventType + ": " + _title + " - " + _date;
    }

    public abstract string FullDetails();


}