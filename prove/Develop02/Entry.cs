public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _signature;
    

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
    }

}