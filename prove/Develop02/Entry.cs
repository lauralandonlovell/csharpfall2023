using System;
using System.Collections.Generic;
using static System.Math;
//displays date, random prompt, text entry, and signature.
public class Entry
{
    public DateTime _date;
    public string _textEntry;
    public string _signature;
    public string _saveEntry;
    public string _loadEntry;
    public Array[] _entryPrompts = new Array[9];
    public Entry()
    {
    }
    public void Display()
    {
       Console.WriteLine($"Date: {_date}");

       //Console.WriteLine($"File Name:{_}");   
    }
    
    
}