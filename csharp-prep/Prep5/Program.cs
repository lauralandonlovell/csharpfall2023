using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        PrintWelcome();
        string person = UserName();
        int number = UserNumber();
        int square = SquareNum(number);
        
        Result(person, square);
    }

    static void PrintWelcome()
    {
        Console.WriteLine("Welcome!!");
    }

    static string UserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int UserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string number = Console.ReadLine();
        int numBer = Convert.ToInt32(number);
        
        return numBer;
    }
    static int SquareNum(int numSquare)
    {
        int sqr = numSquare * numSquare;
        return sqr;
    }
    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, the number squared is {square}.");
    }
}