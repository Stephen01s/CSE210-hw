using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public int NumberOfComments()
    {
        int num = _comments.Count();
        return num;
    }
    public void Display()
    {
        Console.WriteLine($"{_title}, {_author} [{_length} mins]");
    }
    public void DisplayComment()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.Displayinfo());
        }
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
}