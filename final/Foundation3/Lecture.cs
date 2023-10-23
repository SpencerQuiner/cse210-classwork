using System.Diagnostics.Contracts;

public class Lecture : Event
{
    private string _speaker;
    private int _maxCap;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxcapacity) : base(title, description, date, time, address)
    {
        SetType("Lecture");
        _speaker = speaker;
        _maxCap = maxcapacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetMax()
    {
        return _maxCap;
    }

    public override string FullDetails()
    {
        return "Event Type: " + GetEventType() + "\nEvent Title: " + GetTitle() + "\n" + "Speaker: " + GetSpeaker() + "\n" + "Event Description: " + GetDesc() + "\n" + "Maximum Capacity: " + _maxCap + " Date: " + GetDate() + " at " + GetTime() + "\n" + "Venue: " + GetAddressString() + "\n";
    }

}