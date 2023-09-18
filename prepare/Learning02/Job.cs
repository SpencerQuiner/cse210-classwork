
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume
{
    public string _fullName;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        Console.WriteLine($"Names: {_fullName}");
        Console.WriteLine($"Jobs: ");
        for (int i = 0; i < _jobs.Count; i++)
        {
            _jobs[i].DisplayJobDetails();
        }
    }
}