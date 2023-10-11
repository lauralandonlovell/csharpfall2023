using System;
public class Prompt
{
    private List<string> _prompts = new List<string>(){"Today is a great day because...", "My prayers were answered today when...", "I know God loves me because...", "Today was fun because...", "I am going to graduate in...", "I picked applied technology for my major because..."};

    public void Display();
    {
        forEach(string Prompt prompt in _prompts);
        _prompts.Add(prompt);
        Console.WriteLine(prompt);
    }
}
