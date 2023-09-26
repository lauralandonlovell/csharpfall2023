using System;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection.Metadata;
using System.Windows.


using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program. Enjoy keeping track of your day!");
        Console.WriteLine();
        //code for Signature
        
        Console.Write("What is your first name? ");
        string _firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string _lastName = Console.ReadLine();

        //code for JournalMenu
        Console.WriteLine("Please choose from the following menu items: ");
        
        if (grade >= 90)
        {
            gradeLetter = "A";
            //Console.WriteLine(gradeLetter);
        }
        else if (grade >= 80 && grade < 90 )
        {
            gradeLetter = "B";
            //Console.WriteLine(gradeLetter);
        }
            
        else if (grade >= 70 && grade < 80)
        {
            gradeLetter = "C";
            //Console.WriteLine(gradeLetter);
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeLetter = "D";
            //Console.WriteLine(gradeLetter);
        }
            //Console.WriteLine("Congratulations you passed!");
        //}
        else /*if*/
        {
            gradeLetter = "F";
            //Console.WriteLine(gradeLetter);    
        }
        
        Console.WriteLine($"Your grade is: {gradeLetter}.");

        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
           Console.WriteLine($@"Sorry you didn't pass. Don't give up! Better luck next time!"); 
        }


        Prompts
            
    }

}
