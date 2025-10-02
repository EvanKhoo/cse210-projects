using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Sales Manager";
        job2._startYear = 2017;
        job2._endYear = 2023;
        job2.Display();

        Resume r1 = new Resume();
        r1._name = "Kevin";
        r1._jobs.Add(job1);
        r1._jobs.Add(job2);

        // Console.WriteLine($"{r1._jobs[0]._jobTitle}");
        r1.Display();
    }
}