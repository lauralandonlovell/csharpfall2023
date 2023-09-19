using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        /*I think that the conversion to char is causing problems because the program treats magicNum 6, guess 4 the same when values are c and 4. It says guess higher. I don't know why it can compare the number values correctly, but when there is a letter and number it always says guess higher but doesn't have an error.*/
        
        //Getting user input
        Console.Write("Enter a magic number: ");
        string magicNum = Console.ReadLine();//Convert.ToChar(Console.ReadLine());
        Console.Write("Enter a guess: ");
        string userNum = Console.ReadLine();//Convert.ToChar(Console.ReadLine());

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
        

        //if statement. (source I used for checking numberic values https://stackoverflow.com/questions/14304591/check-if-user-input-is-a-number)
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
        }
        else if(userNum == magicNum)
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        else
        {
            Convert.ToInt32(userNum);
            Convert.ToInt32(magicNum);
            Console.WriteLine("Was that a number? I couldn't tell!");
        }
        
    }
}