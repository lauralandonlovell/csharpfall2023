using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gPercentage = Console.ReadLine();
        int grade = (Convert.ToInt32(gPercentage));
        Console.WriteLine(grade);

        if (grade >= 60 && grade < 90)
        {
            if (grade >= 80 && grade < 90 )
            {
                string letterGrade = "B";
                Console.WriteLine($"{letterGrade}");
            }
            else if (grade >= 70 && grade < 80)
            {
                string midgrade = "C";
                Console.WriteLine($"{midgrade}");
            }
        }
        

        


       


        

        


            


    }
}