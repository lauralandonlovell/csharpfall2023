using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
class Program
{
    static void Main(string[] args)
    {   //I exceeded requirements by adding extra classes and trying to have the program open to where they left off writing so they don't put off journaling because of having to restart the program everytime.My program runs but has a lot of logic errors!
        //Journal Class
        Console.WriteLine("\nWelcome to the Journal Program. Enjoy keeping track of your day!\n");
        string[] menuChoice = new string[]{"1. Write", "2. Read", "3. Save", "4. Load", "5. Delete", "6. Quit"};
        foreach (string item in menuChoice)
        {
            Console.WriteLine(item);
        }
        for (int i = 1; i < menuChoice.Length; i++)
        {
            Console.WriteLine(i);
        }
        var writingPrompts = new Prompt<string>();
        writingPrompts[0] = "Today was wonderful because...";
        writingPrompts[1] = "Today I felt the Spirit with me when...";
        writingPrompts[2] = "I enjoyed helping when...";
        writingPrompts[3] = "Today I was grateful for...";
        writingPrompts[4] = "Today I had a good day because...";
        writingPrompts[5] = "The songs that helped me get up in the morning today were...";
        writingPrompts[6] = "I prayed that I would be helped through my problems and ...";
        writingPrompts[7] = "I saw my prayers answered today because...";
        Console.WriteLine("Please type the number of your choice: ");
        int choice = int.Parse(Console.ReadLine());
            // if (choice == 1)
            // {
            //     Prompt prompt1 = new Prompt;
            //     Entry entry1 = new Entry();
            //     entry1._date = DateTime.Today;
            //     entry1._randomPrompt =    
            // }


        //     
        //     string retrieveEntry = "2";
        //     string saveEntry = "3";
        //     string loadEntry = "4";
        //     string deleteEntry = "5";
        //     string quitJournal = "6";
        // }
        
        /*switch (journalMenu)
        {
            case 1:
                
            {
                    string fileName = "journalEntry1.txt";
    //                using (StreamWriter outputfile = new StreamWriter(fileName))
    //                {
    //                     outputfile.WriteLine($"{Entry._entryPrompts}");
    //                }        
    //             } 
    //             Console.WriteLine(1);
    //             break;
    //         case 2:
    //             {
    //                 {
                        
    //                     string filename = "journalEntry1.txt";
    //                     string [] lines = System.IO.File.ReadAllLines(filename);

    //                     foreach (string line in lines)
    //                     {
    //                         string[] parts = line.Split(",");

    //                         string _date = parts[0];
    //                         string _entryPrompts = parts[1];
    //                         string _fileName = parts[2];
    //                         string _filePath = parts[3];
    //                         string _loadEntry = parts[4]; 
    //                     }
    //                 }
    //             }

    //             break;
    //         case 3: 
    //         {
    //             SaveToFile(List<journalMenu> (Journal.journalEntry1.txt));
    //             Console.WriteLine("Saving to File");

    //             string filename = "journalEntry1.txt";
    //             using (StreamWriter outputFile = new StreamWriter(filename));
    //             {
    //                 StreamWriter outputFile = File.AppendText(Journal.journalEntry1.txt);
    //             }
    //         }
    //             break;
    //         case 4:
    //         {   using (StreamReader loadFile = new StreamReader ("journal1.txt"))
    //             {
    //                 string _journalEntry = loadFile.ReadAllText("journal1.txt");
    //             }
    //         }
    //             break;
    //         case 5:
    //         {
    //             Console.WriteLine("Type 5 to quit: ");
    //             if (int menuChoice = 5)
    //             {
    //                 break;
    //             }
    //         }
                
    //     }
    // }
    //     //code for Prompt
    //     // Prompt prompt0 = new Prompt();
    //     // prompt0._weatherPrompt = "Today was wonderful because...";
    //     Prompt prompt1 = new Prompt();
    //     prompt1._spiritualPrompt = "Today I felt the Spirit with me when...";
    //     Prompt prompt2 = new Prompt();
    //     prompt2._helpfulPrompt = "I enjoyed helping when...";
    //     Prompt prompt3 = new Prompt();
    //     prompt3._gratefulPrompt = "Today I was grateful for...";
    //     Prompt prompt4 = new Prompt();
    //     prompt4._goodDayPrompt = "Today I had a good day because...";
    //     Prompt prompt5 = new Prompt();
    //     prompt5._walkingOnSunshinePrompt = "The songs that helped me get up in the morning today were...";
    //     Prompt prompt6 = new Prompt();
    //     prompt6._badDayPrompt = "Today I had a bad day because...";
    //     Prompt prompt7 = new Prompt();
    //     prompt7._badDayAgainPrompt = "I had a bad day again, but today I...";
    //     Prompt prompt8 = new Prompt();
    //     prompt8._problemSolvedPrompt = "I prayed that I would be helped through my problems and ...";
    //     Prompt prompt9 = new Prompt();
    //     prompt9._lifeIsAmazingPrompt = "I saw my prayers answered today because...";

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
        fileSign1._fileName = Console.ReadLine();*/       
    }

}
