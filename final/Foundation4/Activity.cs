public abstract class Activity
{
    protected double _distance;

    private DateTime _date;

    private double _durationMin;

    public Activity(double distance, double durationMin)
    {
        _distance = distance;
        _date = DateTime.Now;
        _durationMin = durationMin;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public string GetDate()
    {
        return _date.ToShortDateString();
    }

    public double GetDuration()
    {
        return _durationMin;
    }

    public abstract string Summary();
    public abstract double GetPace();
    public abstract double GetSpeed();
}