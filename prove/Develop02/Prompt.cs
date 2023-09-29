using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    


    public Prompt()
    {
    }
    public void allPrompts()
    {
        List<string>_journalPrompts = new List<string>(){_weatherPrompt, _spiritualPrompt, _helpfulPrompt, _gratefulPrompt, _goodDayPrompt, _walkingOnSunshinePrompt, _badDayPrompt, _badDayAgainPrompt, _problemSolvedPrompt, _lifeIsAmazingPrompt};
        Console.WriteLine(_journalPrompts);
    }
}