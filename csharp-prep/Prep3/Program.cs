using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Getting user input
        //Console.Write("Enter a magic number: ");
        //var magicNum = /*Convert.ToChar*/(Console.ReadLine());
        //Console.Write("Enter a guess: ");
        //var userNum = Convert.ToChar(Console.ReadLine());

        //Console.WriteLine(Double.Parse(magicNum));
        //Console.WriteLine(Double.Parse(userNum));

        //converting data type to int and printing to console to test
        //int mNum = ;
        //Console.WriteLine(magicNum); 
        //int guessNum = Int32.Parse(userNum);
        //Console.WriteLine(guessNum);

        //Getting input and coverting to int
        Console.WriteLine("Enter the magic number: ");
        int magicNum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter a guess: ");
        int userNum = Int32.Parse(Console.ReadLine());
        

        //if statement
        if(userNum < magicNum)
        {
            Console.WriteLine("Guess higher next time!");
        }
        else if(userNum > magicNum)
        {
            Console.WriteLine("Guess lower next time!");
        }
        else if(userNum == magicNum)
        {
            Console.WriteLine("Congratulations, you guessed it!");
        }
        else
        {
            Console.WriteLine("Sorry, try another number!");
        }





    }
}