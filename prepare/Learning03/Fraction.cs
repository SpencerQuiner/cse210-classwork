using System.ComponentModel.DataAnnotations;

public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int top)
    {
        _topNum = top;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }
    public int GetTop()
    {
        return _topNum;
    }
    public void SetTop(int top)
    {
        _topNum = top;
    }
    public int GetBottom()
    {
        return _bottomNum;
    }
    public void SetBottom(int bottom)
    {
        _bottomNum = bottom;
    }
    public string Getfractionstring()
    {
        string fractionString = _topNum + "/" + _bottomNum;
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decTop = _topNum;
        double decBottom = _bottomNum;
        double decValue = decTop / decBottom;
        return decValue;
    }


}