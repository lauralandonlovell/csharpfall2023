
public class Prompt
{
    //Stores list of writing prompts; returns a prompt
    public List<Prompt>_prompts = new List<Prompt>("Today was beautiful because", "I think Donald Trump wears a toupee because", "Today I struggled a lot because", "I feel smarter today because", "Humans are amazing because", "Conspiracy theorists are crazy because", "Elon Musk is rich because", "You know when you're addicted to social media because", "Writing down your feelings helps you to", "Keeping a journal in another language is a good idea because");

    public void Display()
    {
       for (int i = 0; i < _prompts.Count; i++)
       {
            foreach(Prompt prompt in _prompts)
            {
                prompt.Display();
            }
        }   
    }
}