public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume(string name, List<Job> jobs)
    {
        _name = name;
        _jobs = jobs;
    }

    public void PrintResume()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            Console.WriteLine($"{job._jobName} ({job._company}) {job._startYear}-{job._endYear}");
        }
    }
}  