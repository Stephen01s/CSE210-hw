public class Checklist : Goal
{
    private int _bonusPoints;
    private int _currentlyCompleted;
    private int _goalTotal;
    private int Bonus()
    {
        int total = _bonusPoints + _points;
        return total;
    }
    public override int RecordEvent()
    {
        int point = CompleteTask();
        return point;
    }
    public override string DisplayGoal()
    {
        string dis = base.DisplayGoal();
        dis = dis + $" Currently completed: {_currentlyCompleted}/{_goalTotal}";
        return dis;
    }
    private int CompleteTask()
    {
        if (_currentlyCompleted < _goalTotal - 1)
        {
            _currentlyCompleted += 1;
            return _points;
        }
        else if (_currentlyCompleted == _goalTotal - 1)
        {
            _currentlyCompleted += 1;
            _completed = true;
            int total = Bonus();
            return total;
        }
        else
        {
            Console.WriteLine("this task was already completed.");
            return 0;
        }
    }
    public override string SaveGoal()
    {
        string det = base.SaveGoal();
        det = det  + "~" + _goalTotal + "~" + _bonusPoints + "~" + _currentlyCompleted;
        return det;
    }
    public Checklist( int points, string goalDes, string goalName, int goaltotal, int bonusPoints) : base(points, goalDes, goalName)
    {
        _bonusPoints = bonusPoints;
        _goalTotal = goaltotal;
        _currentlyCompleted = 0;
    }
}