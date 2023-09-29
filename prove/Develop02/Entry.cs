using System;
using System.Collections.Generic;
public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _signature;
    public List<Prompt>_prompts = new List<Prompt>();

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        //found shuffle list info at https://codelikeadev.com/blog/shuffle-list-csharp
        
        for(Prompt prompt in _prompts)
        {

        }
    }
    
}