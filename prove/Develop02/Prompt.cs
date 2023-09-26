
public class Prompt
{
    //Stores list of writing prompts; returns a prompt
    public List<Prompt>_prompts = new List<Prompt>;
    public Prompt()
    {
    }

    public void Display()
    {
       for (int i = 0; i < _prompts.Count; i++)
       {
            foreach(Prompt prompt in _prompts)
            {
                Random prompt = new Random();
                Console.WriteLine(prompt);
            }
        }   
    }
}