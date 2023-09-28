using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {   int item = "";
        int i = 0;
        while ();
        //Journal Class
        Console.WriteLine("Welcome to the Journal Program. Enjoy keeping track of your day!");
        Console.WriteLine();

        //code for JournalMenu
        JournalMenu journalMenu = new JournalMenu();
        journalMenu._writeEntry = "1. Write";
        journalMenu._readEntry = "2. Read";
        journalMenu._fetchEntry = "3. Load";
        journalMenu._saveEntry = "4. Save";
        journalMenu._quitJournal = "5. Quit";

        Console.WriteLine("Please type the item number of your choice from the menu: ");
        string item = Console.ReadLine();
        do
        {
            if (item == )
        }while(item != "5");
       
        
        
        //code for Prompt
        Prompt prompt1 = new Prompt();
        prompt1._entryPrompt = "Today was wonderful because...";
        Prompt prompt2 = new Prompt();
        prompt2._entryPrompt = "Today I felt the Spirit with me when...";
        Prompt prompt3 = new Prompt();
        prompt3._entryPrompt = "I enjoyed helping when I...";
        Prompt prompt4 = new Prompt();
        prompt4._entryPrompt = "Today I was grateful for...";
        Prompt prompt5 = new Prompt();
        prompt5._entryPrompt = "Today I had a really good day because...";
        Prompt prompt6 = new Prompt();
        prompt6._entryPrompt = "One challenge I overcame today was...";
        Prompt prompt7 = new Prompt();
        prompt7._entryPrompt = "I really like myself because...";

        //code for Entry
        Entry entry1 = new Entry();
        entry1._date = DateTime.Today;
        //random prompt
        entry1._prompts.Add(prompt1);
        entry1._prompts.Add(prompt2);
        entry1._prompts.Add(prompt3);
        entry1._prompts.Add(prompt4);
        entry1._prompts.Add(prompt5);
        entry1._prompts.Add(prompt6);
        entry1._prompts.Add(prompt7);
        //other features
        
        entry1._textEntry = Console.WriteLine(${prompt})
        entry1.Display();
        
        
        
        
        
        //code for Signature
        Signature signature1 = new Signature();
        Console.Write("What is your first name? ");
        string _firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string _lastName = Console.ReadLine();

        
        
            
    }

}
