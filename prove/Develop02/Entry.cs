using System;
using System.Collections.Generic;

public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _signature;
    public Array[] _entryPrompts = new Array[9];
    
    public Entry()
    {
    }
    public void Display()
    {
       Console.WriteLine($"Date: {_date}");
       
       
    }
    
    
}