using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Insurance Agent";
        job1._company = "IBI";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Center Manager";
        job2._company = "Teleperformance";
        job2._startYear = 2013;
        job2._endYear = 2018;

        Resume resume1 = new Resume();
        resume1._name = "Carden Allen";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}