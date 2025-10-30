using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mas1 = new MathAssignment("jimbo", "differential calculus", "section 3", "4-7");
        string name;
        name = mas1.GetSummary();
        string sec;
        sec = mas1.GetHomeworkList();
        Console.WriteLine(name);
        Console.WriteLine(sec);
        WritingAssignment was1 = new WritingAssignment("jimbo1", "beginner writer", "Moby Dick");
        string name2;
        name2 = was1.GetSummary();
        string sec2;
        sec2 = was1.GetWritingTitle();
        Console.WriteLine(name2);
        Console.WriteLine(sec2);

    }
}