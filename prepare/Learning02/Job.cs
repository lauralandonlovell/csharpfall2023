public class Job
{
    public string _jobTitle;
    public string _company;

    public string _startYear;/*Example solution shows data type as int. I was thinking that the year would be taken as input from the user, so that is why I have it as string. I was thinking that I would need to do a data conversion method as one of the class methods to change the year to an int, and if that worked, a field that calculated the duration at each job could be an option.*/
    public string _endYear;

    public Job()
    {   
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}


