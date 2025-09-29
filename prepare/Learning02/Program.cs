using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "store support";
        job1._company = "wallyworld";
        job1._startYear = 2026;
        job1._endYear = 2027;
        job1.DisplayJob();
        Job job2 = new Job();
        job2._jobTitle = "Cashier";
        job2._company = "mcdondalds";
        job2._startYear = 2018;
        job2._endYear = 2019;
        job2.DisplayJob();

        Resume resume = new Resume();
        resume._job.Add(job1);
        resume._job.Add(job2);
        resume._name = "ricky";
        Console.WriteLine(resume._job[0]._jobTitle);
        resume.DisplayResume();
    }
}