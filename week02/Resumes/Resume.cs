using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Method to display resume details
    public void DisplayResumeDetails()
    {
        // Display the person's name
        Console.WriteLine($"Name: {_name}");

        // Loop through each job and display it
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}