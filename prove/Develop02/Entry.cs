using System;
using System.Collections.Generic;
using static System.Math;
//displays date, random prompt, text entry, and signature.
public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _filePath;
    public string _fileName;
    public string _saveEntry;
    public string _loadEntry;
    public string _randomPrompt;
    public Prompt[] _entryPrompts = new Prompt[9];

    

    public Entry()
    {
    }
    public void Display()
    {
       Console.WriteLine($"Date: {_date}");
       foreach (Prompt prompt in _entryPrompts)
       {
        Random random = new Random();
        var _randomPrompt = random.Next(0, _entryPrompts.Length);
        Console.WriteLine(_randomPrompt);
       }   
    }
       
}
    
    
