using System;
using System.Globalization;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

/*I think that the conversion to char is causing problems because the program treats magicNum 6, guess 4 the same when values are c and 4. It says guess higher. I don't know why it can compare the number values correctly, but when there is a letter and number it always says guess higher but doesn't have an error.*/

//Getting user input
//Console.Write("Enter a magic number: ");
//string magicNum = Console.ReadLine();//Convert.ToChar(Console.ReadLine());
//Console.Write("Enter a guess: ");
//string userNum = Console.ReadLine();//Convert.ToChar(Console.ReadLine());
//int magNum = Convert.ToInt32(magicNum);
//int guess = Convert.ToInt32(userNum);
// Console.WriteLine(magNum);
// Console.WriteLine(guess);

//Console.WriteLine(Double.Parse(magicNum));
//Console.WriteLine(Double.Parse(userNum));

//converting data type to int and printing to console to test
//int mNum = ;
//Console.WriteLine(magicNum); 
//int guessNum = Int32.Parse(userNum);
//Console.WriteLine(guessNum);

string response = "yes";
while (response == "yes")
{
    Console.WriteLine("Guess the magic number in 10 tries or less!\n");
    // Instantiating new Random object
    Random magicNum = new Random();
    Console.WriteLine(magicNum);
    string
    //tracking guesses in string array
    string[] guesses = new string[10];
    for (int i = 1; i < guesses.Length; i++)
    
    
    {
       
        int rando = Convert.ToChar(magicNum.Next(1,100));
        //converting int value to string so it can be compared to user input value
        string randoNum = Convert.ToString(rando);
        //tests
        Console.WriteLine(i);
        Console.WriteLine(randoNum);

        //Getting user input guess
        Console.Write("Guess a number: ");
        string guess = Console.ReadLine();
        //if statement
        if (string randoNum > string guess)
        {
            Console.WriteLine("Guess higher next time!");
        }
        else if (rando < userGuess)
        {
            Console.WriteLine("Guess lower next time!");
        }
        else if (rando == userGuess)
        {

        }
 


    }Console.WriteLine("Would you like to play again? Type yes or no: ");
    response = Console.ReadLine();
    Console.WriteLine(response);
}
