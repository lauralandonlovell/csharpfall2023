//Contains menu options for the user to choose from
public class JournalMenu
{
    public string _writeEntry;
    public string _readEntry;
    public string _saveEntry;
    public string _fetchEntry;
    public string _quitJournal;
    public JournalMenu()
    {
    }

    public void Display()
    {
        foreach (JournalMenu choice in _choices)
        {
           
        if ()
        // {
        //     gradeLetter = "A";
        //     //Console.WriteLine(gradeLetter);
        // }
        // else if (grade >= 80 && grade < 90 )
        // {
        //     gradeLetter = "B";
        //     //Console.WriteLine(gradeLetter);
        // }
            
        // else if (grade >= 70 && grade < 80)
        // {
        //     gradeLetter = "C";
        //     //Console.WriteLine(gradeLetter);
        // }
        // else if (grade >= 60 && grade < 70)
        // {
        //     gradeLetter = "D";
        //     //Console.WriteLine(gradeLetter);
        // }
        //     //Console.WriteLine("Congratulations you passed!");
        // //}
        // else /*if*/
        // {
        //     gradeLetter = "F";
        //     //Console.WriteLine(gradeLetter);    
        // }
        
        // Console.WriteLine($"Your grade is: {gradeLetter}.");

        // if (grade >= 70) 
        // {
        //     Console.WriteLine("Congratulations! You passed!");
        // }
        else
        {
            Console.WriteLine($@"Would you like to quit the program? Type yes or no."); 
        }


        // Prompts
           choice.Display();
        }
    }
    

}