using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main (string[] args)
    {   
        /*Input
          Console.Write("Enter a magic number: ");
          int magicNum = int.Parse(Console.ReadLine());*/
        
            // Instantiating new Random object to generate magic number
            Random rndNumber = new Random();
            int magicNum = rndNumber.Next(1, 11);
            Console.WriteLine(magicNum);
            //Setting variable to contain input
            int guess = 0;
            /*Trying and failing at stretch challenge:(
               string magic = Convert.ToString(magNum);
               List<int> itries = new List<int>();
               Console.WriteLine("Guess a number: ");
               string guess = Console.ReadLine();*/
            //Setting variable to contain tries 
            int tries = -10;
            //Setting variable to contain iteration count to negative value so it will count down the amount of tries. 
            int i = 1;
            //chose do-while loop so that incrementation is the same as input frequency
            do
            {
                Console.WriteLine("Guess a number: ");
                guess = int.Parse(Console.ReadLine());

                if (magicNum == guess)
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
                else if (magicNum > guess)
                {
                    Console.WriteLine("Guess higher next time!");
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("Guess lower next time!");
                }
                else
                {
                    Console.WriteLine("Was that a number? Try again.");
                }
                tries++;
                i++;
                Console.WriteLine($@"Only ({tries}) guess(es) left!");
                /*Console.WriteLine("Would you like to keep guessing? yes or no");
                string response = Console.ReadLine("yes");*/

            } while (guess <= 10);
            //Code above is working from VSCode debugger but not commandline. Build succeeds but run fails to execute. 0 problems are identified in the problem icon in the bar at the bottom. Error said "*You intended to run a global tool, but a dotnet-prefixed executable with this name could not be found on the PATH."
                







            /* for (int i = 1; i < itries.Length; i++)
             {
                int randomNumber = magNum.Next(1,100);
                 string magNum = Convert.ToChar(randomNumber).ToString();
                 //test
                 Console.WriteLine(magNum);
                 .Add(); 
             }
             foreach(string item in )   
             {
                 //Getting user input guess
                 Console.Write("Guess a number: ");
                 string guess = Console.ReadLine();
             }
            Conditions
            
            
           Console.WriteLine("Would you like to play again? Type yes or no: ");
           response = Console.ReadLine();
           Console.WriteLine(response);*/
    }
}

