using System;
public class Prompt
{
    //Stores list of writing prompts; returns a random prompt.
    string[] _prompts = {"Today was wonderful because...","Today I felt the Spirit with me when...","I enjoyed helping when I...", "Today I was grateful for...", "Today I had a really good day because...", "One challenge I overcame today was...", "I really like myself because..."};
    public Prompt()
    {
    }
    public void Display()
    {
        {
            //Generating a random index for _prompts array. Found info on Random() at https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-7.0
            Random _entryPrompt = new Random();
            int _promptIndex = _entryPrompt.Next(_prompts.Length);
            //Displaying and returning random prompt to other classes.
            
        }
      
    }
}