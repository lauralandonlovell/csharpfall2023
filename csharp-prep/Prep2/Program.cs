using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gPercentage = Console.ReadLine();
        int grade = (Convert.ToInt32(gPercentage));
        Console.WriteLine(grade);

        string gradeLetter = "";

        //if (grade > 60 && grade <= 100)
        //{  
        if (grade >= 90)
        {
            gradeLetter = "A";
            Console.WriteLine(gradeLetter);
        }
        else if (grade >= 80 && grade < 90 )
        {
            gradeLetter = "B";
            Console.WriteLine(gradeLetter);
        }
            
        else if (grade >= 70 && grade < 80)
        {
            gradeLetter = "C";
            Console.WriteLine(gradeLetter);
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeLetter = "D";
            Console.WriteLine(gradeLetter);
        }
            //Console.WriteLine("Congratulations you passed!");
        //}
        else /*if*/
        {
            gradeLetter = "F";
            
        }
        if (gradeLetter >= 70) 
        {
            Console.WriteLine("Cangratulations! You passed!");
        }
        else
        {
           Console.WriteLine($@"Sorry you didn't pass. Don't give up! Better luck next time!"); 
        }


       


        


       


        

        


            


    }
}