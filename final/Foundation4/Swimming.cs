public class Swimming : Activity
{
    private double _lapNumber;

    public Swimming(string date, double length, double lapNumber) : base(date, length)
    {
        _lapNumber = lapNumber;
    }

    public override double GetDistance()
    {
        return _lapNumber * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
