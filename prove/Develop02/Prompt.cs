using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Prompt
{
    //creating list which will be shuffled in Entry class
    public List<string> _prompts = new List<string>(){"Today was wonderful because...", "Today I felt the Spirit with me when...", "I enjoyed helping when I...", "Today I was grateful for...", "Today I had a really good day because...",};


    public Prompt()
    {
    }
    public void Display()
    {
        Console.WriteLine(_prompts);

        
    }
}