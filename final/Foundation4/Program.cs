using System;

class Program
{
    static void Main(string[] args)
    {
        Bicicles bicicles = new Bicicles(60, 20);
        Running run = new Running(30, 4.8);
        Swim swim = new Swim(60, 13);
        bicicles.Summary();
        run.Summary();
        swim.Summary();
    }
}