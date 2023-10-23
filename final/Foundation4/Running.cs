public class Running : Activity
{
    private double _pace;

    public Running(double distance, double durationMin) : base(distance, durationMin)
    {
        _pace = durationMin / distance;
    }

    public override string Summary()
    {
        return GetDate() + " Running (" + GetDuration() + " min)-" + " Distance " + GetDistance() + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile.";
    }

    public override double GetSpeed()
    {
        double roundedSpeed = Math.Round(GetDistance() / GetDuration() * 60, 2);
        return roundedSpeed;
    }

    public override double GetPace()
    {
        double roundedPace = Math.Round(GetDuration() / GetDistance(), 2);
        return roundedPace;
    }
}

