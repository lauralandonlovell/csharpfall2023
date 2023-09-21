using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main (string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Console.WriteLine("Guess the magic number in 10 tries or less!\n");
            // Instantiating new Random object to generate magic number
            Random rndNumber = new Random();
            int magNum = rndNumber.Next(1, 100);
            string magic = Convert.ToString(magNum);
            List<int> itries = new List<int>();
            Console.WriteLine("Guess a number: ");
            string guess = Console.ReadLine();
            for (int i = 1; i < itries.Length; i++)
            {
                int randomNumber = magicNum.Next(1,100);
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
            //Conditions
            
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
            Console.WriteLine("Would you like to play again? Type yes or no: ");
            response = Console.ReadLine();
            Console.WriteLine(response);
        }
    }
}
