/* Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs. */

//List<Job>

using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job jobListElement in _jobs)
        {
            //Console.WriteLine(jobListElement._jobTitle);
            jobListElement.DisplayJob();
        }
    }
}


