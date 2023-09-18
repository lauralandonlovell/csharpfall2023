using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Getting user input
        Console.Write("Enter a magic number: ");
        int magicNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter a guess: ");
        int userNum = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(Double.Parse(magicNum));
        //Console.WriteLine(Double.Parse(userNum));

        //converting data type to int and printing to console to test
        //int mNum = ;
        //Console.WriteLine(magicNum); 
        //int guessNum = Int32.Parse(userNum);
        //Console.WriteLine(guessNum);

        //if statement
        if(userNum < magicNum)
        {
            Console.WriteLine("Guess higher next time!");
        }
        else if(userNum > magicNum)
        {
            Console.WriteLine("Guess lower next time!");
        }
        else if(guessNum == magicNum)
        {
            Console.WriteLine("Congratulations, you guessed it!");
        }
        else
        {
            Console.WriteLine("Sorry, try another number!");
        }





    }
}