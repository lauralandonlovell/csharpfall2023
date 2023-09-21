using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!!");
        //Creating list for storing input values <int>
        Console.WriteLine("Enter a list of numbers, enter 0 when you are done.");
        List<int> numbers = new List<int>();
        //looping to add series of numbers to list
        int number = 0;
        int i = 1;
        do
        {
            //Converting data type to int
            Console.WriteLine("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            //Adding input to list
            numbers.Add(number);
            i++;
        }while (number != 0);

        //Foreach loop to print numbers to the console
        foreach (int item in numbers)
        {
            Console.Write(item);
        }
        
    }
}