internal class Point2D
{
    public double _x;
    public double _y;

    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 20);
            _x = value;
        }
    }

    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertValueInRange(value, 0, 20);
            _y = value;
        }
    }
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
}

