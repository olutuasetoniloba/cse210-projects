public class Fraction
{
    // Attributes (private)
    private int top;
    private int bottom;

    // Constructor 1: No parameters (defaults to 1/1)
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor 2: One parameter (top, bottom = 1)
    public Fraction(int numerator)
    {
        top = numerator;
        bottom = 1;
    }

    // Constructor 3: Two parameters
    public Fraction(int numerator, int denominator)
    {
        top = numerator;

        if (denominator != 0)
        {
            bottom = denominator;
        }
        else
        {
            bottom = 1; // prevent division by zero
        }
    }

    // Getters
    public int GetTop()
    {
        return top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    // Setters
    public void SetTop(int value)
    {
        top = value;
    }

    public void SetBottom(int value)
    {
        if (value != 0)
        {
            bottom = value;
        }
    }

    // Method: return fraction string
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    // Method: return decimal value
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}