public class Simple : Goal
{
    public override int RecordEvent()
    {
        _completed = true;
        return _points;
    }
    
    public Simple(int points, string goalDes, string goalName) : base(points, goalDes, goalName)
    {
        
    }
}