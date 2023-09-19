using System;

class Program
{
    static void Main(string[] args)
    {
    
        
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("Enter a magic number: ");
        string magicNum = Console.ReadLine();
        Console.Write("Enter a guess: ");
        string userNum = Console.ReadLine();
        int magNum = Convert.ToInt32(magicNum);
        int guess = Convert.ToInt32(userNum);
        Console.WriteLine(magNum);
        Console.WriteLine(guess);

        string response = "yes";
        while (response == "yes")
        {
          
        }
    }    
}