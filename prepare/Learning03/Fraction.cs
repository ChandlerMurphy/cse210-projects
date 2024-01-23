public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        // Default to user_top/1
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        // Default to user_top/user_bot
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        // Had to change the _top and _bottom variables from int to double so that we could get decimal precision
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }

    // Getters and Setters Enclosed here for any future need --------------- vvv
    public int GetTop() 
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    // ---------------------------------------------------------------------- ^^^
}