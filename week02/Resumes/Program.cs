using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._company = "Apple";
        job3._jobTitle = "Software Engineer";
        job3._startYear = 2023;
        job3._endYear = 2024;
        
        Resume myResume = new Resume();
        myResume.name = "Immanuel Njibie";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);  
        myResume._jobs.Add(job3);
        
        myResume.DisplayResume();
    }
}