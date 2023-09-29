using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Prompt
{
    //creating list which will be shuffled in Entry class. info source: https://stackoverflow.com/questions/36401282/passing-listobject-between-classes.

    //creating generic prompt ideas.Trying to keep OOP principles.
    public string _weatherPrompt;
    public string _spiritualPrompt;
    public string _helpfulPrompt;
    public string _gratefulPrompt;
    public string _goodDayPrompt;
    public string _walkingOnSunshinePrompt;
    public string _badDayPrompt;
    public string _badDayAgainPrompt;
    public string _problemSolvedPrompt;
    public string _lifeIsAmazingPrompt;
    public List<string>_prompts = new List<string>();
    
    public Prompt()
    {
    }
    public void Display()
    { 
        _prompts.Add(_weatherPrompt);
        _prompts.Add(_spiritualPrompt);
        _prompts.Add(_helpfulPrompt);
        _prompts.Add(_gratefulPrompt);
        _prompts.Add(_goodDayPrompt);
        _prompts.Add(_walkingOnSunshinePrompt);
        _prompts.Add(_badDayPrompt);
        _prompts.Add(_badDayAgainPrompt);
        _prompts.Add(_problemSolvedPrompt);
        _prompts.Add(_lifeIsAmazingPrompt);
        Console.WriteLine(_prompts);
        Array _promptArray = _prompts.ToArray();
        Console.WriteLine(_promptArray);
    }
}