using System.Diagnostics.Contracts;

public class StationaryBike : Activity
{
    private double _speed;

    public StationaryBike(double distance, double durationMin) : base(distance, durationMin)
    {
        _speed = Math.Round(GetDistance() / GetDuration() * 60, 2);
    }

    public override double GetPace()
    {
        double roundedPace = Math.Round(GetDuration() / GetDistance(), 2);
        return roundedPace;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string Summary()
    {
        return GetDate() + " Stationary Bike (" + GetDuration() + " min)-" + " Distance " + GetDistance() + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile.";
    }
}