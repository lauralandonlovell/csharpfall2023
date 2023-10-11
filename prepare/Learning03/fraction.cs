using System.Diagnostics;
using System.Numerics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
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
        return GetTop(top).ToString;
    }

}