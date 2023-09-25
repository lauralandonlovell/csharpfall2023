public class Prompt
{
    public List<string>_prompts = new List<string>("Today was beautiful because", "I think Donald Trump wears a tupee because", "Today I struggled a lot because", "I feel smarter today because", "Humans are amazing because", "Conspiracy theorists are crazy because", "Elon Musk is rich because", "You know when you're addicted to social media because", "Writing down your feelings helps you to", "Keeping a journal in another language is a good idea because");

    public void Display()
    {
       int i = 0;
       while (i < _prompts.Count())
       {
            foreach(Prompt prompt in _prompts)
            {
                prompt =_prompts.Next();
                Console.WriteLine($"{prompt}...\n");
                Console.ReadLine();
                i++
            }
        }
       
       
    }
}