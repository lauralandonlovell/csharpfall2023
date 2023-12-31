using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
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
            //Foreach loop to do math
            int total = 0;
            foreach (int item in numbers)
            {
                total += item;    
            }
            Console.WriteLine($"The total is: {total}.");
            int length = numbers.Count;
            Console.WriteLine(length);
            Console.WriteLine($"Total: {total} Average: {((float)total)/length} Max Value: {numbers.Max()}");
            i++;
        }while (number != 0);
        //Console.WriteLine($"Total: {total} Average: {((float)total)/length} Max Value: {numbers.Max()}");
    }
}