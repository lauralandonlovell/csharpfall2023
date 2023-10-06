using System;
//learn.microsoft.com/indexers
public class Prompt<T>
{
    //public string _writingPrompt {get; set;}
    private T[] _promptArray = new T[9];

    public T this[int i]
    {
        get{return _promptArray[i];}
        set{_promptArray[i] = value;}
    }
    
    // public Prompt(string journalPrompt, string[]prompts)
    // {
    //     this._writingPrompt = journalPrompt;
    //     this._promptArray = prompts;
    // }
    // //got source for how to create pseudo Random index at www.adnanzameer.com
    // public void Display()
    // { 
    //     Random random = new Random();
    //     var randomIndex = random.Next(0, _promptArray.Length);
    //     Console.Write(_promptArray[randomIndex]);
    // }
}