public class MathAssignment : Assignment
{
    private string _textbookSeciton;
    private string _problems;
    public string GetHomeworkList()
    {
        string outp = _textbookSeciton + " " + _problems;
        return outp;
    }
    public MathAssignment(string studentName, string topic, string textbookSeciton, string problems) : base(studentName, topic)
    {
        _textbookSeciton = textbookSeciton;
        _problems = problems;
    }
}