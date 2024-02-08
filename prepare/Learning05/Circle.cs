public class Circle : Shape
{
    private double _radious;

    public Circle(string color, double radious) : base(color)
    {
        //_color = color;
        _radious = radious;
    }


    public override double getArea()
    {
        return Math.PI * _radious * _radious;
    }
}