using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Getting user input
        Console.Write("Enter a magic number: ");
        string magicNum = Console.ReadLine();
        Console.Write("Enter a guess: ");
        string userNum = Console.ReadLine();

        //converting data type to int and printing to console to test
        int magNum = Int32.Parse(magicNum);
        //Console.WriteLine(magNum); 
        int guessNum = Int32.Parse(userNum);
        //Console.WriteLine(guessNum);

        



    }
}