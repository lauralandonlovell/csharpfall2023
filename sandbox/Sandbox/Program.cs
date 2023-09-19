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

        
       while (magNum != guess)
       {
            
            if (magNum > guess)
            {
                Console.WriteLine("Guess higher!");
            }
            else if (magNum < guess)
            {
                Console.WriteLine("Guess lower!");
            }
        
            else if(magNum == guess)
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
            else
            {
                string magic = Convert.ToString(magNum);
                string userGuess = Convert.ToString(guess);
                Console.WriteLine("Was that a number? I couldn't tell!");
                Console.WriteLine(magic);
                Console.WriteLine(userGuess);
            }
            Console.WriteLine("Guess again!");
        }

    }
    
}