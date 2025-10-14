public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        int denominator = 1;
        _bottom = denominator;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
     public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}