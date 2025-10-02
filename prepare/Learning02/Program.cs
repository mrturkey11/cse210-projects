using System;

class Program
{
    static void Main(string[] args)
    {
        List<Job> jobs = new List<Job>();
        jobs.Add(new Job("Software Engineer", "Microsoft", 2019, 2022));
        jobs.Add(new Job("Manager", "Apple", 2022, 2023));
        // Create two jobs
        // Create resume
        Resume resume = new Resume("Allison Rose", jobs);
        resume.PrintResume();
    }
}