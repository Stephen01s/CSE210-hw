using System.Reflection;

public abstract class Goal
{
    protected bool _completed;
    protected int _points;
    private string _goalDescription;
    private string _goalName;
    public int getPoints()
    {
        return _points;
    }
    public abstract int RecordEvent();
    public virtual string DisplayGoal()
    {
        string check;
        if (_completed == true)
        {
            check = "X";
        }
        else
        {
            check = " ";
        }
        string goal = $"[{check}] {_goalName}: {_goalDescription}";
        return goal;
    }
    public virtual string SaveGoal()
    {
        string details = _points + "~" + _goalDescription + "~" + _goalName + "~" + _completed;
        return details;
    }
    public Goal(int points, string goalDes, string goalName)
    {
        _points = points;
        _goalDescription = goalDes;
        _goalName = goalName;
    }
}