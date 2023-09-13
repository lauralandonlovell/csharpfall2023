using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gPercentage = Console.ReadLine();
        int grade = (Convert.ToInt32(gPercentage));
        Console.WriteLine(grade);

        if (grade > 60 && grade >= 100)
        {  
            if (grade >= 90)
            {
                string hiGrade = "A";
                Console.WriteLine(hiGrade)
            }
            else if (grade >= 80 && grade < 90 )
            {
                string letterGrade = "B";
                Console.WriteLine(letterGrade);
            }
            
            else if (grade >= 70 && grade < 80)
            {
                string midgrade = "C";
                Console.WriteLine(midgrade);
            }
            else if (grade >= 60 && grade < 70)
            {
                string lowGrade = "D";
                Console.WriteLine(lowGrade);
            }
            Console.WriteLine("Congratulations you passed!");
        else 
        {
            string badGrade = "F";
            Console.WriteLine(badGrade);
            Console.WriteLine("Sorry you didn't pass this time.");
        }
       


        


       


        

        


            


    }
}