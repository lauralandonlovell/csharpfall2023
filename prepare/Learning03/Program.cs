using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract = new Fraction();
        fract.SetTop(2);
        fract.SetBottom(3);

        Console.WriteLine(fract.GetTop());
        Console.WriteLine(fract.GetBottom());
    }
}