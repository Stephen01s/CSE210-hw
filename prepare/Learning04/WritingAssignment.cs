public class WritingAssignment : Assignment
{
    private string _title;
    public string GetWritingTitle()
    {
        return _title + " by " + GetStudentName();
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
}