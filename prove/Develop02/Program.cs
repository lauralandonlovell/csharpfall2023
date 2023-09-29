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
       
        {"Today was wonderful because...", "Today I felt the Spirit with me when...", "I enjoyed helping when I...", "Today I was grateful for...", "Today I had a really good day because...",};
        
        //code for Prompt
        Prompt prompt1 = new Prompt();
        prompt1._weatherPrompt = "Today was wonderful because...";
        prompt1._spiritualPrompt = "Today I felt the Spirit with me when...";
        prompt1._helpfulPrompt = "I enjoyed helping when...";
        prompt1._gratefulPrompt = "Today I was grateful for...";
        prompt1._goodDayPrompt = "Today I had a good day because...";
        prompt1._walkingOnSunshinePrompt = "The songs that helped me get up in the morning today were...";
        prompt1._badDayPrompt = "Today I had a bad because...";
        prompt1._badDayAgainPrompt = "I had a bad day again, but today I...";
        prompt1._problemSolvedPrompt = "I prayed that I would be helped through my problems and ...";
        prompt1._lifeIsAmazingPrompt = "I saw my prayers answered today because...";

       
        //code for Entry
        Entry entry1 = new Entry();
        entry1._date = DateTime.Today;

        entry1._prompts.Add(prompt1);
        entry1._prompts.Add(prompt2);
        entry1._prompts.Add(prompt3);
        entry1._prompts.Add(prompt4);
        entry1._prompts.Add(prompt5);
        entry1._prompts.Add(prompt6);
        entry1._prompts.Add(prompt7);
        entry1._prompts.Add(prompt8);
        entry1._prompts.Add(prompt9);
        entry1._prompts.Add(prompt10);
        //Prompts added to List 
        
        entry1._textEntry = Console.WriteLine();
        entry1.Display();
        //other features
        
        
        
        
        
        
        
        
        //code for Signature
        Signature signature1 = new Signature();
        Console.Write("What is your first name? ");
        string _firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string _lastName = Console.ReadLine();

        
        
            
    }

}
