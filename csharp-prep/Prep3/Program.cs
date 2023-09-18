using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Getting user input
        Console.Write("Enter a magic number: ");
        int magicNum = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter a guess: ");
        int userNum = Convert.ToChar(Console.ReadLine());

        //Console.WriteLine(Double.Parse(magicNum));
        //Console.WriteLine(Double.Parse(userNum));

        //converting data type to int and printing to console to test
        //int mNum = ;
        //Console.WriteLine(magicNum); 
        //int guessNum = Int32.Parse(userNum);
        //Console.WriteLine(guessNum);

        //Getting input and converting to int
        //Console.WriteLine("Enter the magic number: ");
        //int magicNum = Int32.Parse(Console.ReadLine());
        //var magNum = Console.ReadLine();
        //var magicNum = Console.ReadLine();
        //Console.WriteLine("Enter a guess: ");
        //var userNum = Convert.To(Console.ReadLine());
        //var guessNum = Console.ReadLine();
        

        //if statement
        if(userNum != magicNum)
        {
            int guess = Convert.ToInt32(userNum);
            int magNum = Convert.ToInt32(magicNum);
            if (guess < magNum)
            {
                Console.WriteLine("Guess higher!");
            }
            else if (guess > magNum)
            {
                Console.WriteLine("Guess lower!");
            }
            else if(guess == magNum)
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }
        //else if(var userNum !> var magicNum && var userNum !< magicNum && var userNum != var magicNum)
        else
        {
            Convert.ToInt32(userNum);
            Convert.ToInt32(magicNum);
            Console.WriteLine("Was that a number? I couldn't tell!");
        }
        
    }
}