using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
class Program
{
    static void Main(string[] args)
    {   //I exceeded requirements by adding extra classes and trying to have the program open to where they left off writing so they don't put off journaling because of having to restart the program everytime.My program runs but has a lot of logic errors!
        //Journal Class
        Console.WriteLine("\nWelcome to the Journal Program. Enjoy keeping track of your day!\n");

        Console.WriteLine("Journal Menu");

        Journal journal1 = new Journal(); 
        Console.WriteLine();
        journal1._writeEntry = "1. Write Entry";
        journal1._readEntry = "2. Read Entry";
        journal1._saveEntry = "3. Save Entry";
        journal1._loadEntry = "4. Load Entry";
        journal1._quitJournal = "5. Quit Journal Program\n";

        journal1.Display();

        // int menuChoice = int.Parse(Console.ReadLine());
        // switch (menuChoice)
        // {
        //     case 1:
                
        // //         break;
        // //     case 2:

        // //         break;
        // //     case 3:

        // //         break;
        // //     case 4:

        // //         break;
        // //     case 5:

        // //     break;
        // // }

        //code for Prompt
        Prompt prompt0 = new Prompt();
        prompt0._weatherPrompt = "Today was wonderful because...";
        Prompt prompt1 = new Prompt();
        prompt1._spiritualPrompt = "Today I felt the Spirit with me when...";
        Prompt prompt2 = new Prompt();
        prompt2._helpfulPrompt = "I enjoyed helping when...";
        Prompt prompt3 = new Prompt();
        prompt3._gratefulPrompt = "Today I was grateful for...";
        Prompt prompt4 = new Prompt();
        prompt4._goodDayPrompt = "Today I had a good day because...";
        Prompt prompt5 = new Prompt();
        prompt5._walkingOnSunshinePrompt = "The songs that helped me get up in the morning today were...";
        Prompt prompt6 = new Prompt();
        prompt6._badDayPrompt = "Today I had a bad because...";
        Prompt prompt7 = new Prompt();
        prompt7._badDayAgainPrompt = "I had a bad day again, but today I...";
        Prompt prompt8 = new Prompt();
        prompt8._problemSolvedPrompt = "I prayed that I would be helped through my problems and ...";
        Prompt prompt9 = new Prompt();
        prompt9._lifeIsAmazingPrompt = "I saw my prayers answered today because...";

        //code for Entry
        Entry entry1 = new Entry();
        entry1._date = DateTime.Today;
        entry1._textEntry = "";
        Console.WriteLine($"Enter a file name: ");
        entry1._fileName = Console.ReadLine();
        Console.WriteLine("Enter a filepath: ");
        entry1._filePath = Console.ReadLine();
        Console.WriteLine($"Save to file: {entry1._fileName}");
        
        //code for FileSign
        FileSign fileSign1 = new FileSign();
        Console.WriteLine("Enter a file path: ");
        fileSign1._filePath = Console.ReadLine();
        Console.WriteLine("Enter a file name: ");
        fileSign1._fileName = Console.ReadLine();       
    }

}
