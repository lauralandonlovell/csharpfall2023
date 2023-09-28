using System;
using System.Collections.Generic;
public class Prompt
{
    //Stores list of writing prompts; returns a random prompt.
    public string _entryPrompt;

    public Prompt()
    {
    }
    public void Display()
    {
        {
            Console.WriteLine($"\n{_entryPrompt}\n\n");
            Console.ReadLine();        
        }
      
    }
}