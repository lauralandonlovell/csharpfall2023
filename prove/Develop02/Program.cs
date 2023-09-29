using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {   
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
        
        //code for Prompt
        Prompt prompt1 = new Prompt();
        prompt1._weatherPrompt = "Today was wonderful because...";
        Prompt prompt2 = new Prompt();
        prompt2._spiritualPrompt = "Today I felt the Spirit with me when...";
        Prompt prompt3 = new Prompt();
        prompt3._helpfulPrompt = "I enjoyed helping when...";
        Prompt prompt4 = new Prompt();
        prompt4._gratefulPrompt = "Today I was grateful for...";
        Prompt prompt5 = new Prompt();
        prompt5._goodDayPrompt = "Today I had a good day because...";
        Prompt prompt6 = new Prompt();
        prompt6._walkingOnSunshinePrompt = "The songs that helped me get up in the morning today were...";
        Prompt prompt7 = new Prompt();
        prompt7._badDayPrompt = "Today I had a bad because...";
        Prompt prompt8 = new Prompt();
        prompt8._badDayAgainPrompt = "I had a bad day again, but today I...";
        Prompt prompt9 = new Prompt();
        prompt9._problemSolvedPrompt = "I prayed that I would be helped through my problems and ...";
        Prompt prompt10 = new Prompt();
        prompt10._lifeIsAmazingPrompt = "I saw my prayers answered today because...";

        //code for Entry
        Entry entry1 = new Entry();
        entry1._date = DateTime.Today;

        entry1._entryPrompts.Add(prompt1);
        entry1._entryPrompts.Add(prompt2);
        entry1._entryPrompts.Add(prompt3);
        entry1._entryPrompts.Add(prompt4);
        entry1._entryPrompts.Add(prompt5);
        entry1._entryPrompts.Add(prompt6);
        entry1._entryPrompts.Add(prompt7);
        entry1._entryPrompts.Add(prompt8);
        entry1._entryPrompts.Add(prompt9);
        entry1._entryPrompts.Add(prompt10);
        
        entry1._textEntry =  "0"; 


        //code for Signature
        

        
        
            
    }

}
