public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points)
    {
        _isComplete = completed;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        return "Simple Goal: " + name + "; " + description + "; " + points + "; " + _isComplete;
    }
    public override string GetDetailsString()
    {
        if (_isComplete == true)
        {
            return "[x] " + GetName() + " (" + GetDescription() + ")";
        }
        else
        {
            return "[ ] " + GetName() + " (" + GetDescription() + ")";
        }
    }

}