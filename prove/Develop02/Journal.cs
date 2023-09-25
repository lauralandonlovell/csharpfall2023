public class Journal
    public string _fileName = "";
    public string _journalname = "";
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_journalname}");
        Console.WriteLine($"{_entries}");

        // for ()
        // {
        //     .Display();
        //     Console.WriteLine();
        // }
    }
}
    }