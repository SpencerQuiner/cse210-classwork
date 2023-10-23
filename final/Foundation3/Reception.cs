public class Reception : Event
{
    private string _rsvpEmail;
    private int _maxCap;

    public Reception(string title, string description, string date, string time, Address address, string email, int maxcapacity) : base(title, description, date, time, address)
    {
        SetType("Reception");
        _rsvpEmail = email;
        _maxCap = maxcapacity;
    }

    public string GetRSVP()
    {
        return _rsvpEmail;
    }

    public int GetMax()
    {
        return _maxCap;
    }

    public override string FullDetails()
    {
        return "Event Type: " + GetEventType() + "\nEvent Title: " + GetTitle() + "\n" + "Event Description: " + GetDesc() + "\n" + "Date: " + GetDate() + " at " + GetTime() + "\n" + "Venue: " + GetAddressString() + "\n" + "Attendance at this event is limited to " + _maxCap + ".\n" + "Please RSVP to " + _rsvpEmail + " as soon as possible to reserve your place.";
    }
}