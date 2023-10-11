using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract = new Fraction();
        //fract.SetTop(2);
        //fract.SetBottom(3);

        //Console.WriteLine(fract.GetTop());
        //Console.WriteLine(fract.GetBottom());
        Console.WriteLine(fract.GetFractionString());
        Console.WriteLine(fract.GetDecimalValue());

        Fraction fract2 = new Fraction(5);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());

        Fraction fract3 = new Fraction(3,4);
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());

        Fraction fract4 = new Fraction(1,3);
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());
        
    }
}