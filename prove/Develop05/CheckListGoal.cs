using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountComplete) : base(name, description, points)
    {
        _amountComplete = amountComplete;
        _target = target;
        _bonus = bonus;

    }
    public override string GetDetailsString()
    {
        string name = GetName();
        string description = GetDescription();
        if (_amountComplete == _target)
        {
            return "[X]" + name + "(" + description + ") -- Currently Completed:" + _amountComplete + "/" + _target;
        }
        else
        {
            return "[ ]" + name + "(" + description + ") -- Currently Completed:" + _amountComplete + "/" + _target;
        }
    }
    public override int RecordEvent()
    {
        _amountComplete++;
        if (_amountComplete == _target)
        {
            return _bonus;
        }
        else
        {
            return GetPoints();
        }
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetStringRepresentation()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        return "Checklist Goal: " + name + "; " + description + "; " + points + "; " + _target + "; " + _bonus + "; " + _amountComplete;
    }

}
