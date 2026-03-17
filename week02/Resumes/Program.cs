using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2020;
        job1._endYear = 2023;


        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Microsoft";
        job2._startYear = 2018;
        job2._endYear = 2020;

                
        // Call the method instead of printing manually
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

          // Create Resume instance
        Resume myResume = new Resume();
        myResume._name = "John Doe";

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display everything using one method
        myResume.DisplayResumeDetails();
    }

    
}
