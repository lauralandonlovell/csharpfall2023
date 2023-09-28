using System;
public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _signature;
    public List<Prompt> _prompts = new List<Prompt>();

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        foreach(Prompt prompt in _prompts)
            {
            //Generating a random index for _prompts array. Found info on Random() at https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
                Random entryPrompt = new Random();
                Console.WriteLine(prompt);
            }
    }

}