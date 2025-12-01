public class File
{
    private List<Goal> _goals;
    private int _totalpoints;
    public void Save()
    {
        Console.WriteLine("What is the file you want to save to?");
        string filename = Console.ReadLine();
        // string filename = "listgoal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.SaveGoal());
            }
        }
        Console.WriteLine("Save complete");
    }
    public (List<Goal>, int)Load()
    {
        Console.WriteLine("What is the file you want to load from?");
        string filename = Console.ReadLine();
        // string filename = "listgoal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Goal> goals = new List<Goal>();
        foreach (string line in lines)
        {
            string[] part = line.Split("~");
            int type = part.Count();
            if (type == 4)
            {
                int point = int.Parse(part[0]);
                bool c = bool.Parse(part[3]);
                Simple simple = new Simple(point,part[1], part[2]);
                if (c)
                {
                    _totalpoints = simple.RecordEvent();
                }
                goals.Add(simple);
            }
            else if (type == 5)
            {
                int point = int.Parse(part[0]);
                int comp = int.Parse(part[4]);
                Eternal eternal = new Eternal(point, part[1], part[2]);
                for(int i = 0; i < comp; i++)
                {
                    _totalpoints += eternal.RecordEvent();
                }
                goals.Add(eternal);
            }
            else
            {
                int point = int.Parse(part[0]);
                int total = int.Parse(part[4]);
                int bonus = int.Parse(part[5]);
                int completed = int.Parse(part[6]);
                Checklist checklist = new Checklist(point, part[1], part[2], total, bonus);
                for(int i = 0; i < completed; i++)
                {
                    _totalpoints += checklist.RecordEvent();
                }
                goals.Add(checklist);

            }
        }
        Console.WriteLine("load complete");
        return (goals, _totalpoints);
    }
    public File(List<Goal> goal)
    {
        _goals = goal;
        _totalpoints = 0;
    }
}