public class Eternal : Goal
{
    int _timesCompleted;
    public override int RecordEvent()
    {
        _timesCompleted += 1;
        return _points;
    }
    public override string SaveGoal()
    {
        string det = base.SaveGoal();
        det = det  + "~" + _timesCompleted;
        return det;
    }
    public Eternal(int points, string goalDes, string goalName) : base(points, goalDes, goalName)
    {
        _timesCompleted = 0;
    }
}