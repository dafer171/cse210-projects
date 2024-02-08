public class Square : Shape
{
    //private string _color;
    private int _side;

    public Square(string color, int side) : base(color)
    {
        //_color = color;
        _side = side;
    }

    public override double getArea()
    {
        return _side * _side;
    }
}