
using System.Threading.Tasks.Dataflow;

public class Resume
{
    public string name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs: ");
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}