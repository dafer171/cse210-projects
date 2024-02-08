public class Rectangle : Shape
{
    private int _lenght;
    private int _width;

    public Rectangle(string color, int lenght, int width) : base(color)
    {
        //_color = color;
        _lenght = lenght;
        _width = width;
    }


    public override double getArea()
    {
        return _lenght * _width;
    }
}