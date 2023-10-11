using System.Diagnostics;
using System.Numerics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;//numerator;
        _bottom = 1;//denominator;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public int SetTop(int top)
    {
        _top = top; 
    }
    
    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";//($"({SetTop(top).ToString()})/({SetBottom(bottom).ToString()}");
        return text;
    }
    public double GetDecimalValue()
    {
        //value = (GetFractionString.ToDouble);
        return (double)_top/ (double)_bottom;//value
    }
}