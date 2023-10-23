public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(double distance, double durationMin, int laps) : base(distance, durationMin)
    {
        _numLaps = laps;
        _distance = _numLaps * 50 / 1000;
    }

    public override double GetPace()
    {
        double roundedPace = Math.Round(GetDuration() / GetDistance(), 2);
        return roundedPace;
    }

    public override double GetSpeed()
    {
        double roundedSpeed = Math.Round(GetDistance() / GetDuration() * 60, 2);
        return roundedSpeed;
    }

    public override string Summary()
    {
        return GetDate() + " Swimming (" + GetDuration() + " min)-" + " Distance " + GetDistance() + " KM or " + _numLaps + " laps, Speed " + GetSpeed() + " kmph, Pace: " + GetPace() + " min per KM.";
    }
}