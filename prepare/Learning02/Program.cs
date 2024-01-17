using System;
using resume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._job_title= "Software Engineer";
        job1._company="Microsoft";
        job1._start_year="2025";
        job1._end_year="2040";

        // Console.WriteLine(job1._company);

        job1.Display();

        Job job2 = new Job();
        job2._job_title= "Software Engineer";
        job2._company="Apple";
        job2._start_year="2025";
        job2._end_year="2040";

        // Console.WriteLine(job2._company);

        job2.Display();

        Resume resume = new Resume();

        resume._person_name="Akinrolabu Lolade";
        resume._job_list.Add(job1);
        resume._job_list.Add(job2);

        // Console.WriteLine(resume._job_list[0]._job_title);

        resume.DisplayResume();


    }
}