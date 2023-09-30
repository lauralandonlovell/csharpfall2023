using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Math;
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
    public string[]_prompts = new string[9];

    
    public Prompt()
    {
    }
    public void Display()
    { 
        _prompts[0] = _weatherPrompt;
        _prompts[1] = _spiritualPrompt;
        _prompts[2] = _helpfulPrompt;
        _prompts[3] = _gratefulPrompt;
        _prompts[4] = _goodDayPrompt;
        _prompts[5] = _walkingOnSunshinePrompt;
        _prompts[6] = _badDayPrompt;
        _prompts[7] = _badDayAgainPrompt;
        _prompts[8] = _problemSolvedPrompt;
        _prompts[9] = _lifeIsAmazingPrompt;
        Console.WriteLine(_prompts);
    } 
}