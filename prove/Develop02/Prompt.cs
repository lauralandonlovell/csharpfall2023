using System;
public class Prompt
{
    //Stores list of writing prompts; returns a prompt
    public List<string> _prompts = new List<string>();
    public Prompt()
    {
    }
    public void Display()
    {
        foreach(Prompt prompt in _prompts)
        {
            Random prompt = new Random();
            Console.WriteLine(prompt);
        }
      
    }
}