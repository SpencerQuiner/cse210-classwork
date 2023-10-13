public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract int RecordEvent();
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual string GetDetailsString()
    {
        return "[ ] " + _shortName + " (" + _description + ")";
    }
    public abstract string GetStringRepresentation();
    public virtual bool IsComplete()
    {
        return true;
    }

}