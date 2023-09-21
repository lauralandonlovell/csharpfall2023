using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        PrintWelcome();
        string person = UserName();
        int number = UserNumber();

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
    static double UserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string number = Console.ReadLine();
        double numBer = Convert.ToDouble(number);
        
        return ;

    }
}