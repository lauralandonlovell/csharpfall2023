using System;
using System.Collections.Generic;
public class Prompt
{
    //creating a way to get a list of prompts into Entry class
    public string _entryPrompt;

    public Prompt()
    {
    }
    public void Display()
    {
        {
            Console.WriteLine($"\n{_entryPrompt}\n\n");        
        }
      
    }
}