public class Resume
{
    public string _firstName;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_lastName}, {_firstName}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _jobs)
        {
            job.Display();
        }
    }

}
